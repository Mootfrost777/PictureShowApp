using System.Windows.Forms;

namespace PictureShowServer
{
    public partial class ConfigureShowDialog : Form
    {
        public int TimeInterval
        {
            get
            {
                return trackBarInterval.Value;
            }
            set
            {
                trackBarInterval.Value = value;
            }
        }

        public ConfigureShowDialog()
        {
            InitializeComponent();
        }
    }
}
