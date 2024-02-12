using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_Strıp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();
        }

     

        private void kALINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void pTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Bradley Hand ITC", 12);
        }

        private void pTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Bradley Hand ITC", 15);
        }

        private void pTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Bradley Hand ITC", 20);
        }
    }
}
