using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Settings : Form
    {
        private string ying = "";
        public Settings(string username,string password,string path,Color aa,Color bb)
        {
            InitializeComponent();
            //get data and display on textboxes
            this.BackColor = aa;
            this.ForeColor = bb;
            button3.ForeColor = bb;
            try
            {
                ying = oldpassword = username + " " + password;
                pathh = path;
                string a = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                string b = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];
                Ra.Text = a = (new EncodePanel()).finaldecryption(a, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");//recovery question
                ans.Text = b = (new EncodePanel()).finaldecryption(b, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");//recovery answer
                ame.Text = (new EncodePanel()).finaldecryption(username, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                Password.Text = (new EncodePanel()).finaldecryption(password, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            }
            catch 
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
                
               
                string newpassword = (new EncodePanel()).finalencryption(ame.Text) + " " + (new EncodePanel()).finalencryption(Password.Text);
                string complex = File.ReadAllText(@"10/mover.dll").Replace(oldpassword,newpassword);
                File.WriteAllText(@"10/mover.dll", complex);
                string req = (new EncodePanel()).finalencryption(Ra.Text);
                string rans = (new EncodePanel()).finalencryption(ans.Text);
                string newrecovery = req + Environment.NewLine + rans;
                File.WriteAllText(@"10\Users\" + this.ame.Text + @"\30.dll", newrecovery);
                foreach (var item in Directory.GetFiles(@"10\Users\" + this.ame.Text + @"\20"))
                {
                    string u = File.ReadAllText(item);
                     u = u.Replace(oldpassword.Split(' ')[1], newpassword.Split(' ')[1]);
                   
                    File.WriteAllText(item, u);
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Are You Sure You want to do this? ","Are You Sure?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show(this, "Are You Really Sure You want to do this? ", "Are You Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string complex = File.ReadAllText(@"10/mover.dll").Replace(Environment.NewLine + ying, "");
                    File.WriteAllText(@"10/mover.dll", complex);
                    while (Directory.Exists(@"10\Users\" + this.ame.Text))
                    {
                        try
                        {
                            Directory.Delete(@"10\Users\" + this.ame.Text, true);
                        }
                        catch { }
                        try
                        {
                            Directory.Delete(@"10\Users\" + this.ame.Text + @"\20", true);
                        }
                        catch { }
                        try
                        {
                            Directory.Delete(@"10\Users\" + this.ame.Text + @"\20" + @"\s", true);
                        }
                        catch { }
                    }
                    Application.Restart();

                }
            }
        }
    }
}
