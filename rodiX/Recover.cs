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
    public partial class Recover : Form
    {
        public Recover()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            //overridden method to move a borderless form
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Recover_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = ame.Text;
            string ansa = ans.Text;
            string path = @"10\Users\"+ name +@"\";
            string[] data = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine },StringSplitOptions.None);
            string aR = data[1];
            string complex = System.IO.File.ReadAllText(@"10/mover.dll");
            //for each user
            //do as if you wanna log in then get the user name
           
            aR = (new EncodePanel()).finaldecryption(aR, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            string pass = "";
            if (ansa.ToLower() == aR.ToLower())
            {
                try
                {
                    foreach (string wow in complex.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                    {
                        string main = wow;
                        string user = main.Split(' ')[0];
                        user = (new EncodePanel()).finaldecryption(user, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                        string passw = main.Split(' ')[1];

                        if (user == name)
                        {
                            pass = passw;
                        }
                    }
                }
                catch (Exception cd)
                {
                    MessageBox.Show(cd.Message);
                }
                MessageBox.Show("Password = " + (new EncodePanel()).finaldecryption(pass, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv"));
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"10\Users\" + ame.Text + @"\";
            string d = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            d = (new EncodePanel()).finaldecryption(d, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            MessageBox.Show(d);
        }

        private void ame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                ans.Focus();
            }
        }

        private void ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                ame.Focus();
            }
        }
    }
}
