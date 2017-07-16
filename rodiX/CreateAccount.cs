using System;
using System.IO;
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
                FileInfo q = new FileInfo(@"10\mover.dll");
                
                q.Attributes = FileAttributes.Normal;
            }
            catch (Exception)
            {
                
            }
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
            try
            {
                FileInfo q = new FileInfo(@"10\mover.dll");

                q.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                FileInfo qpwk = new FileInfo((@"10\Users\" + (new EncodePanel()).byteit(this.ame.Text) + @"\30.dll"));

                qpwk.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                rodiX.Properties.Settings.Default.mover = File.ReadAllText(@"10\mover.dll");
                rodiX.Properties.Settings.Default.Save();//backup useranme datafile
            }
            catch (Exception)
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true) { Password.PasswordChar = '•'; Confirm.PasswordChar = '•'; } else { Password.PasswordChar = '\0'; Confirm.PasswordChar = '\0'; }
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
    }
}
