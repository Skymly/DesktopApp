using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.elementHost1.Child = new WpfUserControl1();
        }
    }
}
