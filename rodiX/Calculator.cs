using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodiX
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Calculator_Load(object sender, EventArgs e)
        {
            button25.Click += (EventHandler)numbaz;
            button24.Click += (EventHandler)numbaz;
            button23.Click += (EventHandler)numbaz;
            button22.Click += (EventHandler)numbaz;
            button21.Click += (EventHandler)numbaz;
            button20.Click += (EventHandler)numbaz;
            button19.Click += (EventHandler)numbaz;
            button18.Click += (EventHandler)numbaz;
            button17.Click += (EventHandler)numbaz;
            button16.Click += (EventHandler)numbaz;
            button10.Click += (EventHandler)numbaz;
            button1.Click += (EventHandler)numbaz;
            button2.Click += (EventHandler)numbaz;
            button3.Click += (EventHandler)numbaz;
            button4.Click += (EventHandler)numbaz;
            button5.Click += (EventHandler)numbaz;
            button6.Click += (EventHandler)numbaz;
            button7.Click += (EventHandler)numbaz;
            button8.Click += (EventHandler)numbaz;
            button9.Click += (EventHandler)numbaz;
        }
        void numbaz(object sender,EventArgs e)//event handler to add numbers
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text + "-";
            textBox2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text + "+"; textBox2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text + "*"; textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text + "/"; textBox2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    textBox1.Text += (new NCalc.Expression(textBox1.Text)).Evaluate().ToString();
                   }
                catch (Exception)
                {

                    textBox1.Text += textBox2.Text;
                }
                treeView1.Nodes.Add(textBox1.Text + " = " + ("+" + (new NCalc.Expression(textBox1.Text)).Evaluate().ToString()).Replace("+-", "-"));


                textBox2.Text = ("+" + (new NCalc.Expression(textBox1.Text)).Evaluate().ToString()).Replace("+-", "-");
                try
                {
                    textBox1.Text = (new NCalc.Expression(textBox1.Text)).Evaluate().ToString();
                }
                catch (Exception)
                {

                    textBox1.Text = textBox2.Text;
                }
                textBox2.Text = "";
               
            }
            catch (Exception)
            {
                
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void Calculator_ForeColorChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = this.ForeColor;
            textBox2.ForeColor = this.ForeColor;
            treeView1.ForeColor = this.ForeColor;
        }

        private void Calculator_BackColorChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = this.BackColor;
            textBox2.BackColor = this.BackColor;
            treeView1.BackColor = this.BackColor;

        }
    }
}
