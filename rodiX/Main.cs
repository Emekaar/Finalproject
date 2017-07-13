using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Main : Form
    {
        public Main(string name,string ext)
        {
            InitializeComponent();
            caller = name;//name used for account
            rcaller = name;//name used for account...back up of the name used to rename files
            fullpath = string.Format(@"10\Users\{0}\20\",name);//data path
            List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
            //ext is the whole string with the username and the password
            chk = ext;
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
                    try
                    {
                        looker.Add(q.Text, q);
                    }
                    catch (Exception)
                    {

                    }
                    treeView1.SelectedNode = q;
                        this.Text = h;
                    
                    }
                catch (Exception v)
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
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //clear tree view 
            //open selected not in notereader
            //make treeview settings
            //set treeview propetries to match the note
            //display note
            splitContainer1.Panel2.Controls.Clear();
            
            NoteReader v = new NoteReader(treeView1.SelectedNode.Name, fullpath, (new EncodePanel()).finalencryption(caller));
            v.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(v);
            v.Show();
            v.Focus();
            this.Text = treeView1.SelectedNode.Text;
            
        }

       

        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                (new FileInfo(fullpath + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA"))).Attributes = FileAttributes.Normal;
                File.Delete(fullpath + treeView1.SelectedNode.Name.Replace("?", "AAAAAAAAAA"));
                treeView1.Nodes.Clear();
                List(fullpath, "0aqaqamkdmmkkdmkmkcdalkmemkkmrimfrimcedeoifmirocv");
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
                catch (Exception cd)
                {
                   
                }


            }
        }
        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure?", treeView1.SelectedNode.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                string f = treeView1.SelectedNode.Name;
                try
                {
                    //brung out filer to get new name
                    //transfer node details to the handler 
                    //delete the file of the real node
                    //create new file with old data
                    
                    g.Name = "g";
                    splitContainer1.Panel2.Controls.Clear();
                    g.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(g);
                    renamed = f.Replace("?", "AAAAAAAAAA");
                    ty = renamed.Split(' ')[1];
                    
                    Nrena = treeView1.SelectedNode.Text;
                    g.Show();
                    g.textBox1.KeyDown += (KeyEventHandler)tex;
                    g.Focus();
                    g.textBox1.Focus();
                    // check the eventhandler
                    //if name == g.....
                }
                catch (Exception de)
                {
                    MessageBox.Show("Click the note name well");
                }

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
            (new Calculator()).ShowDialog();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Calender()).ShowDialog();
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
            (new Confirm(chk,fullpath.Replace(@"\20",""))).ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Are you sure??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
