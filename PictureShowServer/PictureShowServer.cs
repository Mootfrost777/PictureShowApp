using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace PictureShowServer
{
    public partial class PictureShowServer : Form
    {
        private string[] fileNames;   // массив имен картинок
        private object filesLock = new object();  // синхронизация
        private UnicodeEncoding encoding = new UnicodeEncoding();

        // Multicast
        private IPAddress groupAddress = IPAddress.Parse("231.4.5.11");
        private int groupPort = 8765;
        private IPEndPoint groupEP;
        private UdpClient udpClient;

        private Thread senderThread;
        private Image currentImage;  // картинка, которую отправляет поток

        private int pictureIntervalSeconds = 3; // время между отправлением картинок


        public PictureShowServer()
        {
            InitializeComponent();

            
        }
        
        private void UIEnableStart(bool flag)
        {
            if (flag)
            {
                buttonStart.Enabled = true;
                miFileStart.Enabled = true;
                buttonStart.BackColor = Color.LightGreen;
            }
            else
            {
                buttonStart.Enabled = false;
                miFileStart.Enabled = false;
                buttonStart.BackColor = Color.LightGray;
            }
        }

        private void UIEnableInit(bool flag)
        {
            if (flag)
            {
                buttonInit.Enabled = true;
                miFileInit.Enabled = true;
                miConfigureMulticast.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
                miFileStart.Enabled = false;
                miConfigureMulticast.Enabled = false;
            }
        }

        private void UIEnableStop(bool flag)
        {
            if (flag)
            {
                buttonStop.Enabled = true;
                miFileStop.Enabled = true;
                buttonPictures.Enabled = true;
                miConfigurePictures.Enabled = true;
                buttonStop.BackColor = Color.Red;
            }
            else
            {
                buttonStop.Enabled = false;
                miFileStop.Enabled = false;
                buttonPictures.Enabled = false;
                miConfigurePictures.Enabled = false;
                buttonStop.BackColor = Color.LightGray;
            }
        }

        private void OnInit(object sender, EventArgs e)
        {
            InfoServer info = new InfoServer(groupAddress, groupPort);
            info.Start();

            UIEnableStart(true);
            UIEnableInit(false);    
        }

        private void OnStart(object sender, EventArgs e)
        {
            if (fileNames == null)
            {
                MessageBox.Show("Import pictures before!");
                return;
            }

            senderThread = new Thread(SendPictures);
            senderThread.Start();

            UIEnableStart(false);
            UIEnableStop(true);
        }

        private void SendPictures()
        {
            
        }

        private void OnStop(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            statusBar.Text = "";

            senderThread.Abort();

            UIEnableStart(false);
            UIEnableStop(true);
        }

        private void OnExit(object sender, EventArgs e)
        {

        }

        private void OnConfigureMulticast(object sender, EventArgs e)
        {
            ConfigureMulticastDialog dialog = new ConfigureMulticastDialog();
            dialog.GroupPort = groupPort;
            dialog.GroupAddress = groupAddress;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                groupAddress = dialog.GroupAddress;
                groupPort = dialog.GroupPort;
            }
        }

        private void OnConfigureShow(object sender, EventArgs e)
        {
            ConfigureShowDialog dialog = new ConfigureShowDialog();
            dialog.TimeInterval = pictureIntervalSeconds;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureIntervalSeconds = dialog.TimeInterval;
            }
        }

        private void OnConfigurePictures(object sender, EventArgs e)
        {
            ConfigurePicturesDialog dialog = new ConfigurePicturesDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lock (filesLock)
                {
                    fileNames = dialog.FileNames;
                    progressBar.Maximum = fileNames.Length;
                }
            }
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {

        }
    }
}
