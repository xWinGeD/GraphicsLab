using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using ImageResizer;

namespace Lab.ZondMethod
{
    public partial class ZondForm : Form
    {
        private Bitmap _mapZond,_mapImage;
        private int[,] zondMass,imageMass;

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
            zondMass = CommonMethods.ReadData(_mapZond);
            // zondMass = CommonMethods.ReadData(_mapZond,true);
            // zondMass = Methods.Binarization(_mapZond, initialMass, 128);
            CommonMethods.FillGrid(_mapZond, zondMass, dataGridView1);
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

        private void ThinningButton_Click(object sender, EventArgs e)
        {
            int[,] finalMass;
            imageMass = CommonMethods.ReadData(_mapImage);
            var skelet = new Skeletonizator(imageMass);
            finalMass = skelet.SkeletonZhangSuen();

            var map = CommonMethods.FilBitmap(finalMass, _mapImage.Height, _mapImage.Width);
            CommonMethods.SaveAndShow(map, pictureBox4);
            CommonMethods.FillGrid(map, imageMass, dataGridView1);
        }

       

        

       


    }
}
