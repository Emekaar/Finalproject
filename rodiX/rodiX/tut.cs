using System;
using System.IO;
using System.Windows.Forms;

namespace rodiX
{
    public partial class tut : Form
    {
        public tut()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string w = @"??QZn1TP ??QZn1TP
??QZn1TP
??QZn1TP
*
??QZn1TP ??AZzQ2M#
ainrifcowismkmideAAAAAAAAAAAAAAAAAAAAAAUGdv5GIhBycpBycphGV
*
??QZn1TP ??QYHJ1M#
ainrifcowismkmideAAAAAAAAAAAAAAAAAAAAAAUGdv5GIyVGa09mbhBycpBycphGd";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, w);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
