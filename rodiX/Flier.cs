using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Flier : UserControl
    {
        public Flier()
        {
            InitializeComponent();
        }
        public string newname(string hui)
        {
            return (new EncodePanel()).finalencryption(hui);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
