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
        public Main(string na,string ext)
        {
            InitializeComponent(); g.textBox1.KeyDown += (KeyEventHandler)tex;
            string name = (new EncodePanel()).byteit(na);
            caller = name;//name used for account
            rcaller = name;//name used for account...back up of the name used to rename files
            path = string.Format(@"10\Users\{0}\", name);
            fpath =fullpath = string.Format(@"10\Users\{0}\20\",name);//data path
            List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            //ext is the whole string with the username and the password
            chk = ext;
            if (File.Exists(fullpath + "11.dll"))
            {
                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                string date = DateTime.Now.Date.ToString();
                string action = date + " " + time + ":" + " Loged in";
                File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=","AAAAAAAAAAA"));
            }
            else
            {
                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                string date = DateTime.Now.Date.ToString();
                string action = date + " " + time + ":" + " Loged in";
                File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
            }
            if (File.Exists(fullpath + "12.dll"))
            {
                treeView1.Font = (new FontConverter()).ConvertFromString(File.ReadAllText(fullpath + "12.dll")) as Font;
            }
            else
            {
                File.WriteAllText(fullpath + "12.dll", (new FontConverter()).ConvertToString(treeView1.Font));
            }
        }
        private string caller = "";
        private string rcaller = "";
        private string fullpath = "";
        string chk = "";
        Dictionary<string, TreeNode> looker = new Dictionary<string, TreeNode>();
        void List(string path,string decoder)
        {
            //get files in root
           
            try
            {
                string[] filesatb = Directory.GetFiles(path);
                Array.Sort(filesatb);
                foreach (string aq in filesatb)
                {
                    try
                    {
                        string y = aq.Replace("AAAAAAAAAA", "?").Replace(fullpath, "");

                        TreeNode a = new TreeNode((new EncodePanel()).finaldecryption(y.Split(' ')[1], decoder));
                        a.Name = y;
                        
                        treeView1.Nodes.Add(a);
                    }
                    catch (Exception)
                    {
                    }
                }
               
            }
            catch (Exception AA)
            {
                MessageBox.Show(AA.Message);
               
            }
            try
            {
                treeView1.SelectedNode = treeView1.Nodes[0];
                looker.Clear();
            }
            catch (Exception)
            {
            }
            try
            {
                AutoCompleteStringCollection suggesName = new AutoCompleteStringCollection();
                foreach (TreeNode suode in treeView1.Nodes) { suggesName.Add(suode.Text); }
                textBox1.AutoCompleteCustomSource = suggesName;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //fill in suggestuons for notes
            }
            catch (Exception)
            {
                
            }
            foreach (TreeNode item in treeView1.Nodes)
            {
                try
                {
                    
                    looker.Add(item.Text, item);
                }
                catch (Exception)
                {

                }
            }

            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        Flier v = new Flier();//textbox useed to add new notes
        Flier a = new Flier();
        Flier l = new Flier();
        void newelder(object sender, KeyEventArgs op)
        {
            if (op.KeyCode == Keys.Enter)
            {
                string k = l.newname(l.textBox1.Text);
                string h = l.textBox1.Text;
                System.IO.File.WriteAllText(fullpath + treeView1.SelectedNode.Name + @"\" + k, "");
                TreeNode q = new TreeNode(h);
                q.Name = fullpath + treeView1.SelectedNode.Name + @"\" + k;
                
                treeView1.SelectedNode.Nodes.Add(q);
                NoteReader lo = new NoteReader(fullpath + treeView1.SelectedNode.Name + @"\" + k,fullpath, (new EncodePanel()).finalencryption(caller));
                splitContainer1.Panel2.Controls.Clear();
                lo.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(lo);
                treeView1.SelectedNode = q;
                this.Text = h;
                lo.Show();
            }
        }
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2.Controls.Clear();
                v.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(v);
                v.Show();
                v.textBox1.KeyDown += (KeyEventHandler)TextBox1KeyDown;
                v.Focus();
                v.textBox1.Focus();
                
            }
            catch (Exception)
            {
               
            }
            
        }
        void TextBox1KeyDown(object sender, KeyEventArgs e)
        {
            //event handler for when enter is pressed
            
            string b1 = "";
            string b2 = "";
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    
                        string k = v.newname(v.textBox1.Text);
                        string h = v.textBox1.Text;
                        k = k.Replace("?", "AAAAAAAAAA");
                        b1 = k;
                        b2 = h;
                        System.IO.File.WriteAllText(fullpath + (new EncodePanel()).finalencryption(caller).Replace("?", "AAAAAAAAAA") + " " + k, "");

                        TreeNode q = new TreeNode(h);
                        q.Name = k;
                        treeView1.Nodes.Add(q);
                    treeView1.Nodes.Clear();
                    List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                    try
                    {
                        try
                        {
                            if (File.Exists(fullpath + "11.dll"))
                            {
                                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                                string date = DateTime.Now.Date.ToString();
                                string action = date + " " + time + ": " + q.Text + " added";
                                File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                            }
                            else
                            {
                                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                                string date = DateTime.Now.Date.ToString();
                                string action = date + " " + time + ": " + q.Text + " added";

                                looker.Add(q.Text, q); File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                            }
                        }
                        catch (Exception)
                        {
                            if (File.Exists(fullpath + "11.dll"))
                            {
                                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                                string date = DateTime.Now.Date.ToString();
                                string action = date + " " + time + ": " + q.Text + " added";
                                File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                            }
                            else
                            {
                                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                                string date = DateTime.Now.Date.ToString();
                                string action = date + " " + time + ": " + q.Text + " added";

                                looker.Add(q.Text, q); File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                    treeView1.SelectedNode = q;
                        this.Text = h;
                    
                    }
                catch (Exception)
                {
                    TreeNode q = new TreeNode(b2);
                    q.Name = b1;
                    try
                    {
                        looker.Add(q.Text, q);
                    }
                    catch (Exception)
                    {

                    }
                    treeView1.SelectedNode = q;

                }
            
            }

            
               
                


            
        }
        string renamed = "";
        TreeNode selected;
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
                selected = treeView1.SelectedNode;
                try
                {
                    (new FileInfo(path + @"20\" + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA"))).Attributes = FileAttributes.Normal;
                }
                catch 
                {
                    
                }
                NoteReader v = new NoteReader(treeView1.SelectedNode.Name, fullpath, (new EncodePanel()).finalencryption(caller));
                v.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(v);
                v.Show();
                v.Focus();
                this.Text = treeView1.SelectedNode.Text;
            }
            catch (Exception)
            {
                
            }
            
        }

       

        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    string y = treeView1.SelectedNode.Text;
                        string qy = fullpath + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA");
                    (new FileInfo(qy)).Attributes = FileAttributes.Normal;
                    File.Delete(qy);
                    treeView1.Nodes.Clear();
                    List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                    if (File.Exists(fullpath + "11.dll"))
                    {
                        string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                        string date = DateTime.Now.Date.ToString();
                        string action = date + " " + time + ":  " + y + " deleted";
                        File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=","AAAAAAAAAAA"));
                    }
                    else
                    {
                        string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                        string date = DateTime.Now.Date.ToString();
                        string action = date + ": " + time + ":" + ": " + y + " deleted";
                        File.WriteAllText((fullpath + "11.dll"),(new EncodePanel()).encrypt64(action).Replace("=","AAAAAAAAAAA"));
                    }
                }
            }
            catch 
            {
                
            }
        }
        
       

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        string Nrena = "";
        string ty = "";
        Flier g = new Flier();
        void tex(object d,KeyEventArgs gj)
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

                    (new FileInfo(fullpath + renamed)).Attributes = FileAttributes.Normal;
                    string yui = File.ReadAllText(fullpath + renamed);

                    System.IO.File.WriteAllText(fullpath + (new EncodePanel()).finalencryption(caller).Replace("?", "AAAAAAAAAA") + " " + k, yui);
                    TreeNode aq = new TreeNode(Nrena);
                    aq.Name = renamed;
                    treeView1.Nodes.Remove(aq);

                    File.Delete(fullpath + renamed);
                    treeView1.Nodes.Clear();


                    if (File.Exists(fullpath + "11.dll"))
                    {
                        string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                        string date = DateTime.Now.Date.ToString();
                        string action = date + " " + time + ": " + Nrena + " renamed to " + h;
                        File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                    }
                    else
                    {
                        string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                        string date = DateTime.Now.Date.ToString();
                        string action = date + " " + time + ":" + " " + Nrena + " renamed to " + h;
                        File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                    }

                    List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                        TreeNode q = new TreeNode(h);
                        q.Name = k;
                    try
                    {
                        looker.Add(q.Text, q);
                    }
                    catch (Exception)
                    {

                    }
                    treeView1.SelectedNode = q;
                    
                }
                catch 
                {
                    
                }


            }
        }
        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                string f = treeView1.SelectedNode.Name;
               
                    g.Name = "g";
                    splitContainer1.Panel2.Controls.Clear();
                    g.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(g);
                    renamed = f.Replace("?", "AAAAAAAAAA");
                    ty = renamed.Split(' ')[1];

                    Nrena = treeView1.SelectedNode.Text;
                    g.Show();
                    
                    g.Focus();
                    g.textBox1.Focus();
                    // check the eventhandler
                    //if name == g.....
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    
                    this.treeView1.SelectedNode = looker[textBox1.Text];
                }
                catch (Exception)
                {
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator i = new Calculator();
            i.ForeColor = this.ForeColor;
            i.BackColor = this.BackColor;
            i.ShowDialog();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ForeColor == Color.White)
            {
                Calender i = new Calender(this.BackColor, Color.Gray);
                i.ShowDialog();
            }
            else
            {
                Calender i = new Calender(this.BackColor, this.ForeColor);
                i.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
        }

        private void splitContainer1_Panel2_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Confirm(chk,fullpath.Replace(@"\20",""),this.BackColor,this.ForeColor)).ShowDialog();
            if (File.Exists(fullpath + "11.dll"))
            {
                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                string date = DateTime.Now.Date.ToString();
                string action = date + " " + time + ": " + " Opened settings";
                File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=","AAAAAAAAAAA"));
            }
            else
            {
                string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                string date = DateTime.Now.Date.ToString();
                string action = date + " " + time + ": " + " Opened settings";
                File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(fullpath + "11.dll"))
                { 
                    string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                    string date = DateTime.Now.Date.ToString();
                    string action = date + " " + time + ":" + " Loged out";
                    File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=","AAAAAAAAAAA"));
                }
                else
                {
                    string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                    string date = DateTime.Now.Date.ToString();
                    string action = date + " " + time + ":" + " Loged out";
                    File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                }
                Application.Restart();
            }
        }

        private void memoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(fullpath + "11.dll")
            Memo x = new Memo(fullpath + "11.dll");
            x.BackColor = this.BackColor;
            x.ForeColor = this.ForeColor;
            x.textBox1.BackColor = this.BackColor;
            x.textBox1.ForeColor = this.ForeColor;
            x.ShowDialog();
        }

        private void saveAccountToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveacc();
         

        }

        void saveacc()
        {
            string total = chk;
            string que = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            string ans = System.IO.File.ReadAllText(path + "30.dll").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];

            total += Environment.NewLine + que + Environment.NewLine + ans;
            foreach (TreeNode d in treeView1.Nodes)
            {
                total += Environment.NewLine + "*";
                total += Environment.NewLine + d.Name + "#" + Environment.NewLine;
                total += File.ReadAllText(fpath + d.Name.Replace("?", "AAAAAAAAAA"));
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
                try
                {
                    if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                    {
                        string y = treeView1.SelectedNode.Text;
                        string qy = fullpath + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA");
                        (new FileInfo(qy)).Attributes = FileAttributes.Normal;
                        File.Delete(qy);
                        treeView1.Nodes.Clear();
                        List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
                        if (File.Exists(fullpath + "11.dll"))
                        {
                            string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                            string date = DateTime.Now.Date.ToString();
                            string action = date + " " + time + ":  " + y + " deleted";
                            File.WriteAllText((fullpath + "11.dll"), File.ReadAllText(fullpath + "11.dll") + Environment.NewLine + (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                        }
                        else
                        {
                            string time = string.Format("{0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours.ToString(), DateTime.Now.TimeOfDay.Minutes.ToString(), DateTime.Now.TimeOfDay.Seconds.ToString());//show time without miliseconds
                            string date = DateTime.Now.Date.ToString();
                            string action = date + ": " + time + ":" + ": " + y + " deleted";
                            File.WriteAllText((fullpath + "11.dll"), (new EncodePanel()).encrypt64(action).Replace("=", "AAAAAAAAAAA"));
                        }
                    }
                }
                catch (Exception)
                {

                }
            }




        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {

        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
           e.Graphics.DrawString(selected.Text, treeView1.Font, Brushes.Crimson, 0, 0);
        }

        private void newNoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2.Controls.Clear();
                v.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(v);
                v.Show();
                v.textBox1.KeyDown += (KeyEventHandler)TextBox1KeyDown;
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
                e.Control.ForeColorChanged += Control_ForeColorChanged;
                e.Control.BackColorChanged += Control_BackColorChanged;
                v.textBox1.ForeColor = e.Control.ForeColor;
                v.textBox1.BackColor = e.Control.BackColor;
                g.textBox1.ForeColor = e.Control.ForeColor;
                g.textBox1.BackColor = e.Control.BackColor;
                label1.ForeColor = e.Control.ForeColor;
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
                v.textBox1.ForeColor = v.ForeColor;
                g.textBox1.ForeColor = v.ForeColor;
                label1.ForeColor = i.ForeColor;
            }
            catch (Exception)
            {
            }
        }

        private void changeNoteTextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    treeView1.Font = fontDialog1.Font;
                    File.WriteAllText(fullpath + "12.dll", (new FontConverter()).ConvertToString(textBox1.Font));
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
