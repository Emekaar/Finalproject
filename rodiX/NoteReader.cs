using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using rodiX;

namespace rodiX
{
    public partial class NoteReader : UserControl
    {
        string pathh = "";
        string full = "";
        string psd = "";
        private string n1 = "";
        string rea;//show if its read only or not
        public NoteReader(string fullname, string path, string caller,string passa)
        {
            InitializeComponent();
            //opened = file being worked on

            new Timer().Tick += Pqp_Tick;
            new Timer().Interval = 30000;
            new Timer().Start();
            psd = passa;
            string a = fullname.Replace("?", "AAAAAAAAAA"); full = a;//real filename
            string b = path;pathh = path;
            if (File.Exists(path + @"s\" +full)){SetUpInterfaceSettings(path);}
            else{UseDefaultSettings(path);}
            n1 = b + a;
            contextMenuStrip1.BackColor = this.BackColor;


            try
            {
                //final path to file
                if (n1.Contains(caller.Replace("?", "AAAAAAAAAA")))//if filename contains username open it
                {
                    //                                      
                    string ee = a + b;     //AAAAAAAAAAAAAAAAAAAAAA ==AA                     
                    string coke = File.ReadAllText(n1).Replace("==AA", "AAAAAAAAAAAAAAAAAAAAAA").Replace("AAAAAAAAAAAAAAAAAAAAAA", "=").Replace("==", "AAAAAAAAAAAAAAAAAAAA");
                    coke = coke.Replace(psd, "");
                    coke = Reverse(coke);
                    textBox1.Text = (new EncodePanel()).decrypt64(coke);
                }
                else
                {
                    string ee = a + b;     //AAAAAAAAAAAAAAAAAAAAAA ==AA                     
                    string coke = File.ReadAllText(n1).Replace("==AA", "AAAAAAAAAAAAAAAAAAAAAA").Replace("AAAAAAAAAAAAAAAAAAAAAA", "=").Replace("==", "AAAAAAAAAAAAAAAAAAAA");

                    if (coke.Contains(psd))
                    {
                        coke = coke.Replace(psd, "");
                        coke = Reverse(coke);
                        textBox1.Text = (new EncodePanel()).decrypt64(coke);
                    }
                    if (coke.Replace(" ", "") == "") textBox1.Text = "";
                }
            }
            catch(Exception ra) { Console.Write(ra.Message); }
        }
        #region Appearance
        private void UseDefaultSettings(string path)
        {
            Directory.CreateDirectory(path + "s");
            string font = (new FontConverter()).ConvertToString(textBox1.Font);
            var back = textBox1.BackColor.ToArgb();
            var fore = textBox1.ForeColor.ToArgb();
            string final = string.Format("{1}{0}{2}{0}{3}{0}r", Environment.NewLine, font, back.ToString(), fore.ToString());
            File.WriteAllText(path + @"s\" + full, final);
        }
        private void SetUpInterfaceSettings(string path)
        {
            string[] y = File.ReadAllText(path + @"s\" + full).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Font = (new FontConverter()).ConvertFromString(y[0]) as Font;
            textBox1.BackColor = Color.FromArgb(int.Parse(y[1]));
            textBox1.ForeColor = Color.FromArgb(int.Parse(y[2]));
            textBox1.LineNumberColor = Color.FromArgb(int.Parse(y[2]));
            ruler1.CaretTickColor = Color.FromArgb(int.Parse(y[2]));
            ruler1.TickColor = Color.FromArgb(int.Parse(y[2]));
            ruler1.ForeColor = Color.FromArgb(int.Parse(y[2]));
            this.BackColor = Color.FromArgb(int.Parse(y[1]));
            rea = y[3];
            if (rea == "rr") { textBox1.ReadOnly = true; }
            if (rea == "r") { textBox1.ReadOnly = false; }
        }
        #endregion
        #region Random Functionality
        string Reverse(string sw)
        {
            char[] od = sw.ToCharArray();
            Array.Reverse(od);
            return new string(od);
        }
        private void textBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = textBox1.Lines.Count.ToString() + " lines";
            toolStripStatusLabel2.Text = textBox1.Text.Replace(Environment.NewLine, " ").Replace("  ", " ").Replace("  ", " ").Trim(' ').TrimStart(' ').TrimEnd(' ').Split(' ').Length.ToString() + " words";
            SaveDoc();
        }
        private void SaveDoc()
        {
            string tring = psd + Reverse((new EncodePanel()).encrypt64(textBox1.Text).Replace("=", "AAAAAAAAAAAAAAAAAAAAAA"));
            try{File.WriteAllText(n1, contents: tring);}catch { }//save file
        }
        private void textBox1_ForeColorChanged(object sender, EventArgs e)
        {
            this.ForeColor = textBox1.ForeColor;
            contextMenuStrip1.ForeColor = textBox1.ForeColor;

        }
        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = textBox1.BackColor;
            contextMenuStrip1.BackColor = textBox1.BackColor;
        }

        #endregion
        #region toolstripmenu items

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Undo();
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Cut();
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Copy();
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Paste();
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectAll();
        private void CapatalizeToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectedText = textBox1.SelectedText.ToUpper();
        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectedText = textBox1.SelectedText.ToLower();
        private void makeAcronymToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Text = String.Join(".", textBox1.Text.ToUpper().ToCharArray());
        private void solveExpressionToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectedText += " = " + new NCalc.Expression(textBox1.SelectedText).Evaluate();
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
        private void findToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.ShowFindDialog();
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.ShowReplaceDialog();
        private void gotoToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.ShowGoToDialog();
        private void endOfLinrToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.GoEnd();
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog q = new FontDialog
            {
                Font = textBox1.Font
            };
            if (q.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = q.Font;
                string ft = (new FontConverter()).ConvertToString(textBox1.Font);
                var bk = textBox1.BackColor.ToArgb();
                var fc = textBox1.ForeColor.ToArgb();
                File.WriteAllText(pathh + @"s\" + full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);

            }
        }
        private void backGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog q = new ColorDialog
            {
                Color = textBox1.BackColor
            };
            if (q.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = q.Color;
                string ft = (new FontConverter()).ConvertToString(textBox1.Font);
                var bk = textBox1.BackColor.ToArgb();
                var fc = textBox1.ForeColor.ToArgb();
                File.WriteAllText(pathh + @"s\" + full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);

            }
        }
        private void foreFroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog q = new ColorDialog
            {
                Color = textBox1.ForeColor
            };

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
                File.WriteAllText(pathh + @"s\" + full, ft + Environment.NewLine + bk + Environment.NewLine + fc + Environment.NewLine + rea);

            }
        }
        private void makeReadOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rea = "rr";
            string font = (new FontConverter()).ConvertToString(textBox1.Font);
            var back = textBox1.BackColor.ToArgb();
            var fore = textBox1.ForeColor.ToArgb();
            string final = string.Format("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, font, back.ToString(), fore.ToString(), rea);
            File.WriteAllText(pathh + @"s\" + full, final);
            textBox1.ReadOnly = true;
        }
        private void enableDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rea = "r";
            string font = (new FontConverter()).ConvertToString(textBox1.Font);
            var back = textBox1.BackColor.ToArgb();
            var fore = textBox1.ForeColor.ToArgb();
            string final = string.Format("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, font, back.ToString(), fore.ToString(), rea);
            File.WriteAllText(pathh + @"s\" + full, final);
            textBox1.ReadOnly = false;
        }


        #endregion
        #region Times when the document is saved

        private void Pqp_Tick(object sender, EventArgs e) => Console.Read();
        private void textBox1_TextChanged(object sender, EventArgs e) => SaveDoc();
        private void textBox1_Leave_1(object sender, EventArgs e) => SaveDoc();
        private void textBox1_Pasting(object sender, FastColoredTextBoxNS.TextChangingEventArgs e) => SaveDoc();
        private void textBox1_MouseMove(object sender, MouseEventArgs e) => SaveDoc();
        #endregion
      
    }
}
