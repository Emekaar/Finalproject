using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace rodiX
{
    public partial class Main : Form
    {
        string path = "";
        string fpath = "";
        string pas = "";
        private string key = "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv";
        public Main(string na, string ext, string hui)
        {
            InitializeComponent(); g.textBox1.KeyDown += (KeyEventHandler)tex;
            string name = (new EncodePanel()).byteit(na);
            caller = name;//name used for account
            rcaller = name;//name used for account...back up of the name used to rename files
            path = $@"10\Users\{name}\";
            fpath = fullpath = string.Format(@"10\Users\{0}\20\", name);//data path
            List(fullpath, key);
            pas = hui;
            //ext is the whole string with the username and the password
            chk = ext;
            log("Loged in");
            SetTVfont("start");
            v.textBox1.KeyDown += (KeyEventHandler)TextBox1KeyDown;
            if(treeView1.Nodes.Count == 1) { MessageBox.Show(treeView1.Nodes[0].Name); }
        }
        private string caller = "";
        private string rcaller = "";
        private string fullpath = "";
        string chk = "";
        Dictionary<string, TreeNode> looker = new Dictionary<string, TreeNode>();
        void SetTVfont(string a)
        {
            try
            {
                if (a == "start")
                {
                    if (File.Exists(fullpath + "12.dll"))
                    {
                        treeView1.Font = (new FontConverter()).ConvertFromString(File.ReadAllText(fullpath + "12.dll")) as Font;
                    }
                    else
                    {
                        File.WriteAllText(fullpath + "12.dll", (new FontConverter()).ConvertToString(treeView1.Font));
                    }
                }
                else
                {
                    File.WriteAllText(fullpath + "12.dll", (new FontConverter()).ConvertToString(treeView1.Font));
                }
            }
            catch (Exception g)
            {
                Console.WriteLine("Failed Action");
                Console.WriteLine(g.Message);
            }
        }
        private void changeNoteTextFontToolStripMenuItem_Click(object sender, EventArgs e) {
            var t = new FontDialog();
            if (t.ShowDialog() == DialogResult.OK) treeView1.Font = t.Font;
            SetTVfont("random");
        }
        void log(string re)
        {
            try
            {
                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                string date = DateTime.Now.Date.ToString();
                if (File.Exists(fullpath + "11.dll"))
                {
                    string action = date + " " + time + ":" + " Loged in";
                    File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));

                }
                else
                {
                    re = date + " " + time + " : " + re;
                    File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(re).Replace("=", "AAAAAAAAAAA"));
                }
            }
            catch
            {

            }
        }

        void police(string where, string and)
        {
            try
            {
                string[] yim = Directory.GetFiles(where.Substring(0, where.Length - 1));
                foreach (var a in yim)
                {
                    if (a.Split(' ').Length > 2) File.Delete(a);
                    if (a.Split(' ').Length < 2 && !a.Contains(".dll")) File.Delete(a);
                }
                string[] fz = Directory.GetFiles(and);
                foreach (var a in fz)
                {
                    if (a.Split(' ').Length > 2) File.Delete(a);
                    if (a.Split(' ').Length < 2 && !a.Contains(".dll")) File.Delete(a);
                    if (!yim.Contains(a)) File.Delete(a);
                }
            }
            catch
            {

            }
        }

        void List(string pwit, string decoder)
        {
            //get files in root
            police(pwit, pwit + @"s");
            try
            {
                string[] filesatb = Directory.GetFiles(pwit);
                Array.Sort(filesatb);
                foreach (string aq in filesatb)
                {
                    try
                    {
                        //Could not find file 'C:\Users\ra\Desktop\rodiX\rodiX\bin\Debug\10\Users\w\20\j5mT0UWbxkXYHdXP'.j5mT0UWbxkXYHdXP
                        string y = aq.Replace("AAAAAAAAAA", "?").Replace(fullpath, "");
                        TreeNode a = new TreeNode((new EncodePanel()).finaldecryption(y.Split(' ')[1], decoder));
                        a.Name = y;

                        string frf = y.Split(Char.Parse(@"\"))[y.Split(Char.Parse(@"\")).Length - 1];
                        frf = frf.Replace("'", "");
                        frf = frf.Replace(".", "");
                        var r = frf.Split();
                        r[0] = (new EncodePanel()).finalencryption(caller);

                        a.Name = string.Join(" ", r);

                        if (y.Split(' ').Length < 3)
                        {
                            treeView1.Nodes.Add(a);
                        } else
                        {
                            File.Delete(pwit + @"20\" + a.Name);
                        }
                    }
                    catch (Exception d)
                    {
                        Console.WriteLine("i'm probably not a big deal");
                        Console.WriteLine(d.Message);
                    }
                }
                treeView1.SelectedNode = treeView1.Nodes[0];
                looker.Clear();

            }
            catch (Exception AA)
            { Console.WriteLine(AA.Message); }
            try
            {
                AutoCompleteStringCollection suggesName = new AutoCompleteStringCollection();
                foreach (TreeNode suode in treeView1.Nodes) { suggesName.Add(suode.Text); }
                textBox1.AutoCompleteCustomSource = suggesName;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //fill in suggestuons for notes
            }
            catch (Exception g) { Console.Write(g.Message); }

            foreach (TreeNode item in treeView1.Nodes)
            {
                try { looker.Add(item.Text, item); } catch { }
            }



        }

        private void Main_Load(object sender, EventArgs e) => timer1.Start();
        Flier v = new Flier();//textbox useed to add new notes
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            v.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(v);
            v.Show();
            v.Focus();
            v.textBox1.Focus();
        }
        void TextBox1KeyDown(object sender, KeyEventArgs e)
        {
            //event handler for when enter is pressed to add notes
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string b1 = "";
                    string b2 = "";
                    b1 = v.newname(v.textBox1.Text).Replace("?", "AAAAAAAAAA");
                    this.Text = b2 = v.textBox1.Text;
                    string fnam = (new EncodePanel()).finalencryption(caller).Replace("?", "AAAAAAAAAA") + " " + b1;
                    File.WriteAllText(fullpath + fnam, "");
                    treeView1.Nodes.Clear();
                    List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                    treeView1.SelectedNode = treeView1.Nodes[treeView1.Nodes.IndexOfKey(fnam.Replace("AAAAAAAAAA", "?"))];
                    log(b2 + " added");
                    looker.Add(b2, treeView1.SelectedNode);
                }
                catch { Console.Write("kai"); }

            }
        }
        string renamed = "";
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //clear tree view 
            //open selected not in notereader
            //make treeview settings
            //set treeview propetries to match the note
            //display note
            
            try
            {
                splitContainer1.Panel2.Controls.Clear();
                NoteReader va = new NoteReader(treeView1.SelectedNode.Name, fullpath, (new EncodePanel()).finalencryption(caller), pas) { Dock = DockStyle.Fill };
                splitContainer1.Panel2.Controls.Add(va);
                va.Show();
                va.Focus();
                Text = treeView1.SelectedNode.Text;
            }
            catch (Exception)
            {

            }

        }




        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => Delete();

        private void Delete()
        {
            try
            {
                if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    splitContainer1.Panel2.Controls.Clear();
                    File.Delete(fullpath + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA"));
                    File.Delete(fullpath + @"s\" + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA"));
                    treeView1.Nodes.Clear();
                    List(fullpath, key);
                    log(treeView1.SelectedNode.Text + " deleted");
                }
            }
            catch { }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        string Nrena = "";
        string ty = "";
        Flier g = new Flier();
        void tex(object d, KeyEventArgs gj)
        {
            if (gj.KeyCode == Keys.Enter)
            {
                //write new file with old data
                //create node for it 
                //open it
                //remove old node
                //delete old file
                try
                {
                    string k = g.newname(g.textBox1.Text).Replace("?", "AAAAAAAAAA");
                    string h = g.textBox1.Text;
                    string yui = File.ReadAllText(fullpath + renamed);
                    File.WriteAllText(fullpath + (new EncodePanel()).finalencryption(caller).Replace("?", "AAAAAAAAAA") + " " + k, yui);
                    TreeNode aq = new TreeNode(Nrena);
                    aq.Name = renamed;
                    treeView1.Nodes.Remove(aq);
                    File.Delete(fullpath + renamed);
                    treeView1.Nodes.Clear();
                    log(Nrena + "renamed to " + h);
                    List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                    string index_check = (new EncodePanel()).finalencryption(caller) + " " + g.newname(g.textBox1.Text);
                    TreeNode ag = treeView1.Nodes[treeView1.Nodes.IndexOfKey(index_check)];
                    treeView1.SelectedNode = ag;
                } catch { }
            }
        }
        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                g.Name = "g";
                splitContainer1.Panel2.Controls.Clear();
                g.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(g);
                renamed = treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA");
                ty = renamed.Split()[1];
                Nrena = treeView1.SelectedNode.Text;
                g.Show();
                g.Focus();
                g.textBox1.Focus();
                // check the eventhandler
                //if name == g.....

            }
        }

      

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){ try{this.treeView1.SelectedNode = looker[textBox1.Text]; }catch (Exception){}}
        }
        
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e) => new Calculator { ForeColor = this.ForeColor, BackColor = this.BackColor }.ShowDialog();

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ForeColor == Color.White)
            {
                new Calender(BackColor, Color.Gray).ShowDialog();
            }
            else
            {
                new Calender(BackColor, this.ForeColor).ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            police(where: fpath , and: fpath + @"s");
            label1.Text = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Confirm(chk,fullpath.Replace(@"\20",""),this.BackColor,this.ForeColor)).ShowDialog();
            log("Opened settings");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                log("Loged out");
                Application.Restart();
            }
        }

        private void memoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(fullpath + "11.dll")
            Memo x = new Memo(fullpath + "11.dll")
            {
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            x.textBox1.BackColor = this.BackColor;
            x.textBox1.ForeColor = this.ForeColor;
            x.ShowDialog();
        }

        private void saveAccountToFileToolStripMenuItem_Click(object sender, EventArgs e) => saveacc();

        void saveacc()
        {
            string que = File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            string ans = File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];
            string total = chk + Environment.NewLine + que + Environment.NewLine + ans;
            foreach (TreeNode d in treeView1.Nodes)
            {
                total += Environment.NewLine + "*"
                      + Environment.NewLine + d.Name + "#" + Environment.NewLine
                      + File.ReadAllText(fpath + d.Name.Replace("?", "AAAAAAAAAA"));
            }
            //.rox
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "|*.rox";
            if (op.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(op.FileName, total);
            }

        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }
        
       

        private void newNoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2.Controls.Clear();
                v.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(v);
                v.Show();
                v.Focus();
                v.textBox1.Focus();
            }
            catch (Exception)
            {

            }
        }

        private void splitContainer1_Panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                treeView1.ForeColor = e.Control.ForeColor;
                treeView1.BackColor = e.Control.BackColor;
                this.ForeColor = e.Control.ForeColor;
                this.BackColor = e.Control.BackColor;
                textBox1.BackColor = e.Control.BackColor;
                textBox1.ForeColor = e.Control.ForeColor;
                contextMenuStrip1.BackColor = e.Control.BackColor;
                contextMenuStrip1.ForeColor = e.Control.ForeColor;
                e.Control.ForeColorChanged += Control_ForeColorChanged;
                e.Control.BackColorChanged += Control_BackColorChanged;
                v.textBox1.ForeColor = e.Control.ForeColor;
                v.textBox1.BackColor = e.Control.BackColor;
                g.textBox1.ForeColor = e.Control.ForeColor;
                g.textBox1.BackColor = e.Control.BackColor;
                label1.ForeColor = e.Control.ForeColor;
                newNoteToolStripMenuItem.ForeColor = e.Control.ForeColor;
                renameNoteToolStripMenuItem.ForeColor = e.Control.ForeColor;
                deleteToolStripMenuItem.ForeColor = e.Control.ForeColor;
               
                calculatorToolStripMenuItem.ForeColor = e.Control.ForeColor;
                calenderToolStripMenuItem.ForeColor = e.Control.ForeColor;
                settingsToolStripMenuItem.ForeColor = e.Control.ForeColor;
                logoutToolStripMenuItem.ForeColor = e.Control.ForeColor;
                memoToolStripMenuItem.ForeColor = e.Control.ForeColor;
                saveAccountToFileToolStripMenuItem.ForeColor = e.Control.ForeColor;
                newNoteToolStripMenuItem1.ForeColor = e.Control.ForeColor;
                changeNoteTextFontToolStripMenuItem.ForeColor = e.Control.ForeColor;
                calculatorToolStripMenuItem.BackColor = e.Control.BackColor;
                calenderToolStripMenuItem.BackColor = e.Control.BackColor;
                settingsToolStripMenuItem.BackColor = e.Control.BackColor;
                logoutToolStripMenuItem.BackColor = e.Control.BackColor;
                memoToolStripMenuItem.BackColor = e.Control.BackColor;
                saveAccountToFileToolStripMenuItem.BackColor = e.Control.BackColor;
                newNoteToolStripMenuItem1.BackColor = e.Control.BackColor;
                changeNoteTextFontToolStripMenuItem.BackColor = e.Control.BackColor;

            }
            catch (Exception)
            {
                
            }
        }

        private void Control_BackColorChanged(object sender, EventArgs e)
        {
            try
            {
                var i = sender as UserControl;
                this.BackColor = i.BackColor;
                treeView1.BackColor = i.BackColor;
                textBox1.BackColor = i.BackColor;
                v.textBox1.BackColor = i.BackColor;
                g.textBox1.BackColor = i.BackColor;
                contextMenuStrip1.BackColor = i.BackColor;
                calculatorToolStripMenuItem.BackColor = i.BackColor;
                calenderToolStripMenuItem.BackColor = i.BackColor;
                settingsToolStripMenuItem.BackColor = i.BackColor;
                logoutToolStripMenuItem.BackColor = i.BackColor;
                memoToolStripMenuItem.BackColor = i.BackColor;
                saveAccountToFileToolStripMenuItem.BackColor = i.BackColor;
                newNoteToolStripMenuItem1.BackColor = i.BackColor;
                changeNoteTextFontToolStripMenuItem.BackColor = i.BackColor;
            }
            catch (Exception)
            {
                
            }
        }

        private void Control_ForeColorChanged(object sender, EventArgs e)
        {
            try
            {
                var i = sender as UserControl;
                this.BackColor = i.BackColor;
                treeView1.ForeColor = i.ForeColor;
                textBox1.ForeColor = i.ForeColor;
                v.textBox1.ForeColor = i.ForeColor;
                g.textBox1.ForeColor = i.ForeColor;
                newNoteToolStripMenuItem.ForeColor = i.ForeColor;
                renameNoteToolStripMenuItem.ForeColor = i.ForeColor;
                deleteToolStripMenuItem.ForeColor = i.ForeColor;
                contextMenuStrip1.ForeColor = i.ForeColor;
                calculatorToolStripMenuItem.ForeColor = i.ForeColor;
                calenderToolStripMenuItem.ForeColor = i.ForeColor;
                settingsToolStripMenuItem.ForeColor = i.ForeColor;
                logoutToolStripMenuItem.ForeColor = i.ForeColor;
                memoToolStripMenuItem.ForeColor = i.ForeColor;
                saveAccountToFileToolStripMenuItem.ForeColor = i.ForeColor;
                newNoteToolStripMenuItem1.ForeColor = i.ForeColor;
                changeNoteTextFontToolStripMenuItem.ForeColor = i.ForeColor;
            }
            catch (Exception)
            {
            }
        }

        
    }
}
