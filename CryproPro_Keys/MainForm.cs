using System.Windows.Forms;

namespace CryproPro_Keys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.version_Field.Text = Program.CRYPTO_VERSION;
            this.key_Field.Text = Program.KEY;
        }
    }
}
