using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace rodiX
{
    public partial class NoteReader : UserControl
    {
        string pathh = "";
        string full = "";
        public NoteReader(string fullname, string path, string caller)
        {
            InitializeComponent();
            //opened = file being worked on


            string a = fullname.Replace("?", "AAAAAAAAAA");//real filename
            string b = path;
            pathh = path;
            full = a;
            if (File.Exists(path + @"s\" +full))
            {
                string[] y = File.ReadAllText(path + @"s\" +full).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                textBox1.Font = (new FontConverter()).ConvertFromString(y[0]) as Font;
                textBox1.BackColor = Color.FromArgb(int.Parse(y[1]));
                textBox1.ForeColor = Color.FromArgb(int.Parse(y[2]));
                textBox1.LineNumberColor = Color.FromArgb(int.Parse(y[2]));
                ruler1.CaretTickColor = Color.FromArgb(int.Parse(y[2]));
                ruler1.TickColor = Color.FromArgb(int.Parse(y[2]));
                ruler1.ForeColor = Color.FromArgb(int.Parse(y[2]));
                this.BackColor = Color.FromArgb(int.Parse(y[1]));
                rea = y[3];
                if(rea == "rr") { textBox1.ReadOnly = true; }
                if (rea == "r") { textBox1.ReadOnly = false; }
            }
            else
            {
                Directory.CreateDirectory(path + "s");
                string font = (new FontConverter()).ConvertToString(textBox1.Font);
                var back = textBox1.BackColor.ToArgb();
                var fore = textBox1.ForeColor.ToArgb();
                string final = string.Format("{1}{0}{2}{0}{3}{0}r", Environment.NewLine, font, back.ToString(), fore.ToString());
                File.WriteAllText(path +@"s\" +full, final);
                (new FileInfo(path + @"s\" +full)).Attributes = FileAttributes.ReadOnly;
            }
            
            try
            {
                n1 = b+a;//final path to file
                
                FileInfo q = new FileInfo(n1);
                q.Attributes = FileAttributes.Normal;

                if (n1.Contains(caller.Replace("?", "AAAAAAAAAA")))//if filename contains username open it

                {
                    //
                    string ee = a + b;
                    textBox1.Text = (new EncodePanel()).decrypt64(File.ReadAllText(n1).Replace("AAAAAAAAAAAAAAAAAAAAAA","="));

                    q.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                    
                }
            }
            catch (Exception df)
            {
                try
                {
                    n1 = b + caller.Replace("?", "AAAAAAAAAA")+ " " + a;//final path to file

                    FileInfo q = new FileInfo(n1);
                    q.Attributes = FileAttributes.Normal;

                    if (n1.Contains(caller.Replace("?", "AAAAAAAAAA")))//if filename contains username open it

                    {
                        string ee = a + b;
                        textBox1.Text = (new EncodePanel()).decrypt64(File.ReadAllText(n1).Replace("AAAAAAAAAAAAAAAAAAAAAA", "="));

                        q.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                        
                    }
                }
                catch (Exception gg)
                {
                    
                }
            }
        }
        private string n1 = "";
        

        private void NoteReader_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void reverseTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                char[] k = textBox1.SelectedText.ToCharArray();
                Array.Reverse(k);
                textBox1.SelectedText = new string(k);
            }
            catch { }
        }

        private void capatalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.SelectedText.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.SelectedText.ToLower();
        }

        private void makeAcronymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] p = textBox1.SelectedText.ToCharArray();
            string u = "";
            foreach (char k in p)
            {
                u += k.ToString() + ".";
            }
            u = u.Substring(0, u.Length - 1);
            textBox1.SelectedText = u.ToUpper();
        }

        private void solveExpressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NCalc.Expression q = new NCalc.Expression(textBox1.SelectedText);
            textBox1.SelectedText += " = " + q.Evaluate();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog q = new FontDialog();
            q.Font = textBox1.Font;
            if (q.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = q.Font;
                string ft = (new FontConverter()).ConvertToString(textBox1.Font);
                var bk = textBox1.BackColor.ToArgb();
                var fc = textBox1.ForeColor.ToArgb();
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.Normal;
                System.IO.File.WriteAllText(pathh + @"s\" +full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.ReadOnly;
            }
        }
        string rea;//show if its read only or nah
        private void backGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog q = new ColorDialog();
            q.Color = textBox1.BackColor;
            if (q.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = q.Color;
                string ft = (new FontConverter()).ConvertToString(textBox1.Font);
                var bk = textBox1.BackColor.ToArgb();
                var fc = textBox1.ForeColor.ToArgb();
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.Normal;
                System.IO.File.WriteAllText(pathh + @"s\" +full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.ReadOnly;
            }
        }

        private void foreFroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog q = new ColorDialog();
            q.Color = textBox1.ForeColor;

            if (q.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = q.Color;
                textBox1.LineNumberColor = q.Color;
                ruler1.CaretTickColor = q.Color;
                ruler1.TickColor = q.Color;
                ruler1.ForeColor = q.Color;
                string ft = (new FontConverter()).ConvertToString(textBox1.Font);
                var bk = textBox1.BackColor.ToArgb();
                var fc = textBox1.ForeColor.ToArgb();
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.Normal;
                System.IO.File.WriteAllText(pathh + @"s\" +full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);
                (new FileInfo(pathh + @"s\" +full)).Attributes = FileAttributes.ReadOnly;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            try
            {
                FileInfo q = new FileInfo(n1);
                //enable editing of file
                q.Attributes = FileAttributes.Normal;
                File.WriteAllText(n1, (new EncodePanel()).encrypt64(textBox1.Text).Replace("=", "AAAAAAAAAAAAAAAAAAAAAA"));//save file

                q.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.Encrypted;
                //make file readonly,hidden and encrypted
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ShowReplaceDialog();
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ShowGoToDialog();
        }

        private void makeReadOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rea = "rr";
            string font = (new FontConverter()).ConvertToString(textBox1.Font);
            var back = textBox1.BackColor.ToArgb();
            var fore = textBox1.ForeColor.ToArgb();
            string final = string.Format("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, font, back.ToString(), fore.ToString(),rea);
            (new FileInfo(pathh + @"s\" + full)).Attributes = FileAttributes.Normal;
            File.WriteAllText(pathh + @"s\" + full, final);
            (new FileInfo(pathh + @"s\" + full)).Attributes = FileAttributes.ReadOnly;
            textBox1.ReadOnly = true;
        }

        private void enableDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rea = "r";
            string font = (new FontConverter()).ConvertToString(textBox1.Font);
            var back = textBox1.BackColor.ToArgb();
            var fore = textBox1.ForeColor.ToArgb();
            string final = string.Format("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, font, back.ToString(), fore.ToString(), rea);
            (new FileInfo(pathh + @"s\" + full)).Attributes = FileAttributes.Normal;
            File.WriteAllText(pathh + @"s\" + full, final);
            (new FileInfo(pathh + @"s\" + full)).Attributes = FileAttributes.ReadOnly;
            textBox1.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = textBox1.Lines.Count.ToString() + " lines";
            toolStripStatusLabel2.Text = textBox1.Text.Replace(Environment.NewLine, " ").Replace("  "," ").Replace("  ", " ").Trim(' ').TrimStart(' ').TrimEnd(' ').Split(' ').Length.ToString() + " words";
        }

        

        private void endOfLinrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.GoEnd();
            
        }

        
    }
}
