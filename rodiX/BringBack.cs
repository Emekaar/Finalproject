﻿using System;
using System.IO;
using System.Windows.Forms;
namespace rodiX
{
    class BringBack
    {
        public void makeUser(string oui)
        {
                                                 
            string tyo = File.ReadAllText(oui).Replace("AAAAAAAAAA", "="); 
            string[] cox = tyo.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
           
            string tt = cox[1] + Environment.NewLine + cox[2];
            string username = (new EncodePanel()).finaldecryption(cox[0].Split(' ')[0], "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            username = (new EncodePanel()).byteit(username);
            if (Directory.Exists(@"10/Users/" + username)){ MessageBox.Show("account already exists");}
            else
            {
                if (File.Exists(@"10/mover.dll") && File.ReadAllText(@"10/mover.dll") != "")
                {
                    File.WriteAllText(@"10/mover.dll", File.ReadAllText(@"10/mover.dll") + Environment.NewLine + cox[0]);
                }
                else { File.WriteAllText(@"10/mover.dll", cox[0]); }
                Directory.CreateDirectory(@"10/Users/" + username);
                File.WriteAllText(@"10/Users/" + username + @"/" + "30.dll", tt);
                Directory.CreateDirectory(@"10/Users/" + username + @"/" + "20");

                string edetails = File.ReadAllLines(oui)[0]
                                + Environment.NewLine
                                + File.ReadAllLines(oui)[1]
                                + Environment.NewLine
                                + File.ReadAllLines(oui)[2]
                                + Environment.NewLine + "*";

                try
                {
                    string[] notes = tyo.Replace(edetails, "").Split('*');
                    string pathh = Directory.GetCurrentDirectory().ToString() + @"\10/Users\" + username + @"\" + @"20\";
                    (new DirectoryInfo(pathh)).Attributes = FileAttributes.Normal;
                    foreach (var item in notes)
                    {
                        string name = item.Split('#')[0].Replace("?", "AAAAAAAAAA");
                        string data = item.Split('#')[1].Replace(Environment.NewLine, "");
                        File.WriteAllText(pathh + name.Replace(Environment.NewLine,""), data);   
                    }
                    MessageBox.Show(username = username + " recovered");
                }
                catch (Exception fr)
                {
                    MessageBox.Show(fr.ToString());

                }
            }



            
        }
    }
}
