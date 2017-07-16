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
    public partial class Confirm : Form
    {
        public Confirm(string full,string path,Color a,Color b)
        {
            InitializeComponent();
            username = full.Split(' ')[0];
            pas = full.Split(' ')[1];
            pat = path;
            this.BackColor = a;
            this.ForeColor = b;
            button3.ForeColor = b;
        }
        //0 = name
        //1 = password
        private void Confirm_Load(object sender, EventArgs e)
        {
            
        }
        private string username = "";//username
        private string pas = "";//password
        private string pat =  "";//path
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((new EncodePanel()).finalencryption(password.Text) == pas)
            {
                (new Settings(username, pas, pat,this.BackColor,this.ForeColor)).ShowDialog();
            }
        }
    }
}
