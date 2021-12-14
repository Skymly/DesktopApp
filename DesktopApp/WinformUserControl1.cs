using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class WinformUserControl1 : UserControl
    {
        public WinformUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
