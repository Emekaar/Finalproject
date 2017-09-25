using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace rodiX
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
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

        private void CreateAccount_Load(object sender, EventArgs e)
        {
           
        }
                //File.WriteAllText(@"10\mover.dll", "");
                //File.WriteAllText(@"10\Users\mover.dll", "");
        private void button1_Click(object sender, EventArgs e)
        {
            //write all file data for created user
            //decrypt first
            //create file that will be used to check external modifiction
            //create data files
            
            try
            {
                if (Password.Text == Confirm.Text && Ra.Text != "" && ans.Text != "" && MessageBox.Show(null, "Create Account??", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
                {

                    EncodePanel a = new EncodePanel();
                    string name = a.finalencryption((this.ame.Text));
                    string password = a.finalencryption(Password.Text);
                    if (!File.ReadAllText(@"10\mover.dll").Contains(name))
                    {
                        string recoveryquestion = a.finalencryption(Ra.Text);
                        string recoveryanswr = a.finalencryption(ans.Text);
                        string mover1 = (name + " " + password);
                        
                        try
                        {
                            File.WriteAllText(@"10\mover.dll", File.ReadAllText(@"10\mover.dll") + Environment.NewLine + mover1);
                        }
                        catch (Exception)
                        {

                            File.WriteAllText(@"10\mover.dll", File.ReadAllText(@"10\mover.dll") + Environment.NewLine + mover1);
                        }
                        Directory.CreateDirectory(@"10\Users\" + (new EncodePanel()).byteit(this.ame.Text));
                        Directory.CreateDirectory(@"10\Users\" + (new EncodePanel()).byteit(this.ame.Text) + @"\20");
                        File.WriteAllText(@"10\Users\" + (new EncodePanel()).byteit(this.ame.Text) + @"\30.dll", recoveryquestion + Environment.NewLine + recoveryanswr);

                        string insurance = (new EncodePanel()).finalencryption("wow");
                        MessageBox.Show("Account Created");
                        this.Close();
                    }
                    else { MessageBox.Show("Account Exists"); }
                }

            }
            catch (Exception th)
            {
                MessageBox.Show(th.Message);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                Password.Focus();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                Confirm.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                ame.Focus();
            }
        }

        private void Confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                Ra.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                Password.Focus();
            }
        }

        private void Ra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                ans.Focus();
            }
        }

        private void ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Ra.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = checkBox1.Checked ? Password.PasswordChar = '•' : Password.PasswordChar = '\0';
            Confirm.PasswordChar = checkBox1.Checked ? Password.PasswordChar = '•' : Password.PasswordChar = '\0';
        }

        private void ame_Enter(object sender, EventArgs e)
        {
            
            if(ame.Text == "Insert Username" && ame.ForeColor == Color.Silver)
            {
                ame.Text = "";
                ame.ForeColor = Color.Black;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Insert Password" && Password.ForeColor == Color.Silver)
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Confirm_Enter(object sender, EventArgs e)
        {
            if (Confirm.Text == "Confirm Password" && Confirm.ForeColor == Color.Silver)
            {
                Confirm.Text = "";
                Confirm.ForeColor = Color.Black;
            }
        }

        private void Ra_Enter(object sender, EventArgs e)
        {
            if (Ra.Text == "Insert Recovery Question" && Ra.ForeColor == Color.Silver)
            {
                Ra.Text = "";
                Ra.ForeColor = Color.Black;
            }
        }

        private void ans_Enter(object sender, EventArgs e)
        {
            if (ans.Text == "Insert Answer" && ans.ForeColor == Color.Silver)
            {
                ans.Text = "";
                ans.ForeColor = Color.Black;
            }
        }
    }
}
