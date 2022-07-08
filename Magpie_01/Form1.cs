using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magpie_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int magpie = int.Parse(textBox1.Text);
                switch(magpie)
                {
                    case 1:
                        label3.Text = "One for sorrow";
                        break;
                    case 2:
                        label3.Text = "Two for joy";
                        break;
                    case 3:
                        label3.Text = "Three for a girl";
                        break;
                    case 4:
                        label3.Text = "Four for a boy";
                        break;
                    case 5:
                        label3.Text = "Five for silver";
                        break;
                    case 6:
                        label3.Text = "Six for gold";
                        break;
                    case 7:
                        label3.Text = "Seven for a secret\nnever to be told";
                        break;
                    default: label3.Text = "Invalid Input";
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(label3 != null)
            {
                label3.Text = "";
                if (textBox1 != null)
                {
                    textBox1.Text = "";
                }
            }
            
        }
    }
}
