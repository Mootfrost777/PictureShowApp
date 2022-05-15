using System;
using System.Net;
using System.Windows.Forms;

namespace PictureShowServer
{
    public partial class ConfigureMulticastDialog : Form
    {
        public int GroupPort
        {
            get
            {
                return int.Parse(textBoxPort.Text);
            }
            set
            {
                textBoxPort.Text = value.ToString();
            }
        }

        public IPAddress GroupAddress
        {
            get
            {
                return IPAddress.Parse(textBoxIPAddress.Text);
            }
            set
            {
                textBoxIPAddress.Text = value.ToString();
            }
        }

        public string LocalInterface
        {
            get { return comboBoxLocalInterface.Text; }
        }

        public ConfigureMulticastDialog()
        {
            InitializeComponent();

            LoadLocalInterfaces();
        }

        private void LoadLocalInterfaces()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostByName(hostname);
            IPAddress[] addresses = entry.AddressList;

            foreach (IPAddress address in addresses)
            {
                comboBoxLocalInterface.Items.Add(address.ToString());
            }
            comboBoxLocalInterface.SelectedIndex = 0;

            if (comboBoxLocalInterface.Items.Count > 0)
            {

                comboBoxLocalInterface.Items.Add("Any");
            }
            else
            {
                comboBoxLocalInterface.Enabled = false;
            }
        }

        private void textBoxIPAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                IPAddress address = IPAddress.Parse(textBoxIPAddress.Text);

                string[] segments = address.ToString().Split('.');
                int network = int.Parse(segments[0]);
                if (network < 224 || network > 239)
                {
                    throw new FormatException("Multicast address must be in 224.x.x.x - 239.x.x.x");
                }


                if (network == 224 && int.Parse(segments[1]) == 0 && int.Parse(segments[2]) == 0)
                {
                    throw new FormatException("Address already reserved.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }

        private void textBoxPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int port = int.Parse(textBoxPort.Text);

                if (port < 0 || port > 65535)
                {
                    throw new FormatException("Port must be in the range 0 - 65535");
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }
    }
}
