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
        private Bitmap _mapZond,_mapImage;
        private int[,] initialMass;

        public ZondForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            _mapZond = CommonMethods.OpenFile(pictureBox1);
        }

        private void BuildMatrix_Click(object sender, EventArgs e)
        {
            initialMass = CommonMethods.ReadData(_mapZond);
            CommonMethods.FillGrid(_mapZond,initialMass,dataGridView1);
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            Methods.FindZond(_mapZond.Height, _mapZond.Width, initialMass);
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            _mapImage = CommonMethods.OpenFile(ImagePictureBox);
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            int[,] mass;
            mass = CommonMethods.ReadData(_mapImage);
            CommonMethods.FillGrid(_mapImage,mass,dataGridView1);
            _mapImage = Methods.CutAndScalling(mass,_mapImage.Height,_mapImage.Width);
            CommonMethods.SaveAndShow(_mapImage,pictureBox3);
        }

       


    }
}
