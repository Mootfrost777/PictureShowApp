using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShowServer
{
    public partial class ConfigurePicturesDialog : Form
    {
        private string[] fileNames;

        public string[] FileNames
        {
            get { return fileNames; }
        }

        public ConfigurePicturesDialog()
        {
            InitializeComponent();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog.FileNames;

                int imageIndex = 0;
                foreach(string fileName in fileNames)
                {
                    Image image = Image.FromFile(fileName);
                    imageList.Images.Add(image);
                    listViewPictures.Items.Add(fileName, imageIndex++);
                }
            }
        }

        private void OnClearPictures(object sender, EventArgs e)
        {
            listViewPictures.Items.Clear();
        }
    }
}
