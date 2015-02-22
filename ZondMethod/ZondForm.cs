using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.ZondMethod
{
    public partial class ZondForm : Form
    {
        private Bitmap _map;
        private double[,] initialMass;

        public ZondForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            _map = CommonMethods.OpenFile(pictureBox1);
        }

        private void BuildMatrix_Click(object sender, EventArgs e)
        {
            initialMass = CommonMethods.ReadData(_map);
            CommonMethods.FillGrid(_map,initialMass,dataGridView1);
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            
        }


    }
}
