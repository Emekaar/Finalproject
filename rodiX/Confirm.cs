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
        public Confirm(string got, Color a, Color b,string real)
        {
            ab = got;
            this.BackColor = a;
            this.ForeColor = b;
            button3.ForeColor = b;
            ri = real;
        }
        string ab = "";
        private string ri = "";
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
        bool po = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (po == false)
            {
                if ((new EncodePanel()).finalencryption(password.Text) == pas)
                {
                    (new Settings(username, pas, pat, this.BackColor, this.ForeColor)).ShowDialog();
                }
            }else
            {
                if (ab.StartsWith((new EncodePanel()).finalencryption(password.Text)))
                {
                    //input old password
                    string hi = (new EncodePanel()).finalencryption(password.Text);
                    string n = ab.Replace(hi, ri);
                    old = hi;
                    neu = ri;
                }
            }
        }
        public string old = "";
        public string neu = "";


    }
}
