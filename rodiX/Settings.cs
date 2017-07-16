using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Settings : Form
    {
        public Settings(string username,string password,string path,Color aa,Color bb)
        {
            InitializeComponent();
            //get data and display on textboxes
            this.BackColor = aa;
            this.ForeColor = bb;
            button3.ForeColor = bb;
            try
            {
                oldpassword = username + " " + password;
                pathh = path;
                string a = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                string b = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];
                Ra.Text = a = (new EncodePanel()).finaldecryption(a, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");//recovery question
                ans.Text = b = (new EncodePanel()).finaldecryption(b, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");//recovery answer
                ame.Text = (new EncodePanel()).finaldecryption(username, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                Password.Text = (new EncodePanel()).finaldecryption(password, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            }
            catch (Exception hr)
            {
                MessageBox.Show("Error");
                this.Close();
                throw;
            }
        }
        string oldpassword = "";
        string pathh = "";
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show(null,"Are you sure??","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                (new FileInfo(@"10/mover.dll")).Attributes = FileAttributes.Normal;
                (new FileInfo((@"10\Users\" + this.ame.Text + @"\30.dll"))).Attributes = FileAttributes.Normal;
                string newpassword = (new EncodePanel()).finalencryption(ame.Text) + " " + (new EncodePanel()).finalencryption(Password.Text);
                string complex = File.ReadAllText(@"10/mover.dll").Replace(oldpassword,newpassword);
                File.WriteAllText(@"10/mover.dll", complex);
                string req = (new EncodePanel()).finalencryption(Ra.Text);
                string rans = (new EncodePanel()).finalencryption(ans.Text);
                string newrecovery = req + Environment.NewLine + rans;
                File.WriteAllText(@"10\Users\" + this.ame.Text + @"\30.dll", newrecovery);
                try
                {
                    FileInfo q = new FileInfo(@"10\mover.dll");

                    q.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                    FileInfo qpwk = new FileInfo((@"10\Users\" + this.ame.Text + @"\30.dll"));

                    qpwk.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                    rodiX.Properties.Settings.Default.mover = File.ReadAllText(@"10\mover.dll");
                    rodiX.Properties.Settings.Default.Save();//backup useranme datafile
                }
                catch (Exception)
                {

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
