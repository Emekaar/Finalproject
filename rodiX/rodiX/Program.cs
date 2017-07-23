using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace rodiX
{
    static class Program
    {
        //if there is no account created, show the form to create one
        //move to Login Page if the file is readonly and hidden
        static Mutex mutex = new Mutex(true, "0omomoomomommmomomoooomomommmomomoooomomommmomomooommomomomomomomomiininininininimimimimimininininimimimi");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //rodiX.exe
           
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("Error");
                Application.Exit();
            }
            else
            {
                if (!Directory.Exists("10"))
                {
                    Directory.CreateDirectory("10");
                    Directory.CreateDirectory(@"10\Users");
                    string admin = (new EncodePanel()).finalencryption("admin");
                    File.WriteAllText(@"10\mover.dll", admin + " " + admin);
                    FileInfo q = new FileInfo(@"10\mover.dll");
                    q.Attributes = FileAttributes.Normal;

                    (new CreateAccount()).ShowDialog();
                }
                

                Application.Run(new Form1());
            }

        }
    }
}
