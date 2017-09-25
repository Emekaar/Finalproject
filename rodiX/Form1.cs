using System;
using System.IO;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region moveableform
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

        #endregion//to make the borderless form move
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nap.Hide();
            button1.Hide();
            button3.Hide();
            (new CreateAccount()).ShowDialog();//show dialog for creating account
            nap.Show();
            button1.Show();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }
        //"0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv" is the password to decode a text
        private void button1_Click(object sender, EventArgs e)
        {
            aff();//method to login
        }
        void aff()
        {
            string ame = (new EncodePanel()).finalencryption(name.Text);//encoded text from the textbox ame near the "name" label
            string pass = (new EncodePanel()).finalencryption(password.Text);//encoded text from the textbox password near the "password" label
            string complex = File.ReadAllText(@"10/mover.dll");//data from the mover.dll file
            //for each user
            foreach (string wow in complex.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))//for every line in mover.dll
            {
                //split into two... username and password
                //if the name frome the text box == first text in a line in mover.dll and the password feilds are the same
                //pass data to the login method
                string main = wow;
                string user = main.Split(' ')[0];
                string passw = main.Split(' ')[1];
                if (ame == user && passw == pass)
                {
                    login(ame, pass, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv", wow);
                }
            }
        }
        protected void login(string username, string password, string decodepassword, string full)
        {
            string user = (new EncodePanel()).finaldecryption(username, decodepassword);//username
            string pass = (new EncodePanel()).finaldecryption(password, decodepassword);//password
            MessageBox.Show("Loged into " + user);
            this.Hide();//hide this form
            Main raa = new Main(user, full,password);
            raa.logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;//eventhandler for log out
            raa.Show();//show main form
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) password.PasswordChar = '\0'; else password.PasswordChar = '•';//hide and show password
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nap.Hide();
            button1.Hide();
            button3.Hide();
            (new Recover()).ShowDialog();//show recover dialog
            nap.Show();
            button1.Show();
            button3.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "|*.rox";
            if (o.ShowDialog() == DialogResult.OK)
            {
                
                string tyo = File.ReadAllText(o.FileName).Replace("AAAAAAAAAA", "=");
                string[] cox = tyo.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                //cox[0]
                string main = cox[0];
                string user = main.Split(' ')[0];
                string passw = main.Split(' ')[1];
                string ame = (new EncodePanel()).finalencryption(name.Text);//encoded text from the textbox ame near the "name" label
                string pass = (new EncodePanel()).finalencryption(password.Text);//encoded text from the textbox password near the "password" label
                if (ame == user && passw == pass)
                {
                    (new BringBack()).makeUser(o.FileName);
                }else
                {
                    MessageBox.Show("error probably incorrect username or password");
                }
            }


        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password.Focus();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                aff();
            }
            if (e.KeyCode == Keys.Up)
            {
                name.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { this.Left -= 10; }
            if (e.KeyCode == Keys.Right) { this.Left += 10; }
            if (e.KeyCode == Keys.Down) { this.Top += 10; }
            if (e.KeyCode == Keys.Up) { this.Top -= 10; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nap.Hide();
            button1.Hide();
            button3.Hide();
            (new tut()).ShowDialog();
            nap.Show();
            button1.Show();
            button3.Show();
        }
    }
}
