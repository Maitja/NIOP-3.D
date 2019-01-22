using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKrajinovicMatija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelVrijeme2.Text = DateTime.Now.ToShortTimeString();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelVrijeme_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelVrijeme2_Click(object sender, EventArgs e)
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
