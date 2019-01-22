using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStripKrajinovicMatija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void desnoulijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox2.Text;
        }

        private void lijevoudesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             textBox2.Text = textBox1.Text;
        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StripMenu_Click(object sender, EventArgs e)
        {
            Form2 nForm = new Form2();
            nForm.TopLevel = true;
            nForm.Show();
        }
       
    }
}
