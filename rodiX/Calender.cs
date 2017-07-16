using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Calender : Form
    {
        public Calender(Color a,Color b)
        {
            InitializeComponent();
            coloa(a, b);
            this.BackColor = a;
            button26.ForeColor = calendar1.ForeColor;
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void coloa(Color a,Color b)
        {
            calendar1.BackColor = a;
            calendar1.ForeColor = b;
            button26.ForeColor = calendar1.ForeColor; ;
        }
        private void Calender_ForeColorChanged(object sender, EventArgs e)
        {
            
        }

        private void Calender_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }
    }
}
