using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
         }
        float a, b;
        float y, x, c, v;
        string k;
        string q, w;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            q = textBox1.Text;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            w = textBox1.Text;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
            a = float.Parse(q);
            b = float.Parse(w);
            c = a + b;
            k = Convert.ToString(c);
            textBox3.Text = k;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
            a = float.Parse(q);
            b = float.Parse(w);
            c = a - b;
            k = Convert.ToString(c);
            textBox3.Text = k;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "*";
            a = float.Parse(q);
            b = float.Parse(w);
            c = a * b;
            k = Convert.ToString(c);
            textBox3.Text = k;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "/";
            a = float.Parse(q);
            b = float.Parse(w);
            c = a / b;
            k = Convert.ToString(c);
            textBox3.Text = k;
        }
    }
}
