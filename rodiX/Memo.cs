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
    public partial class Memo : Form
    {
        public Memo(string file)
        {
            InitializeComponent();
            textBox1.Text = System.IO.File.ReadAllText(file).Replace("AAAAAAAAAAA", "=");
            string kai = (new EncodePanel()).decrypt64(textBox1.Lines[0]);
            for (int i = 1; i < textBox1.Lines.Length; i++)
            {
                try
                {
                    kai += Environment.NewLine + (new EncodePanel()).decrypt64(textBox1.Lines[i]);
                }
                catch (Exception)
                {
                    
                }
            }
            textBox1.Text = kai.Replace("12:00:00 AM ","").Replace(":"," : ").Replace(":  :",": ");
            textBox1.Text = textBox1.Text.Replace(": 0 :", ": 00 :");
            textBox1.Text = textBox1.Text.Replace(": 1 :", ": 01 :");
            textBox1.Text = textBox1.Text.Replace(": 2 :", ": 02 :");
            textBox1.Text = textBox1.Text.Replace(": 3 :", ": 03 :");
            textBox1.Text = textBox1.Text.Replace(": 4 :", ": 04 :");
            textBox1.Text = textBox1.Text.Replace(": 5 :", ": 05 :");
            textBox1.Text = textBox1.Text.Replace(": 6 :", ": 06 :");
            textBox1.Text = textBox1.Text.Replace(": 7 :", ": 07 :");
            textBox1.Text = textBox1.Text.Replace(": 8 :", ": 08 :");
            textBox1.Text = textBox1.Text.Replace(": 9 :", ": 09 :");
            textBox1.Text = textBox1.Text.Replace("   ", " ");
            button3.ForeColor = textBox1.ForeColor;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Memo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_ForeColorChanged(object sender, EventArgs e)
        {
            button3.ForeColor = textBox1.ForeColor;
        }
    }
}
