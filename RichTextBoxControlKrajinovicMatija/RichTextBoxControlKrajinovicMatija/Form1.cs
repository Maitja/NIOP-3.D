using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxControlKrajinovicMatija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void spremi_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");

        }

        private void citaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void StripMenu_Click(object sender, EventArgs e)
        {
            Form2 nForm = new Form2();
            nForm.TopLevel = true;
            nForm.Show();
        }

    }
}
