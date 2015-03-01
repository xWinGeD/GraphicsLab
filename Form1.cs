using System;
using System.Windows.Forms;
using Lab.ZondMethod;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zondMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ZondForm().Show();
        }
    }
}
