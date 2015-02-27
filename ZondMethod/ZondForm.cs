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
            CommonMethods.FillGrid(_mapZond, zondMass, dataGridView1);
        }

        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            _mapImage = CommonMethods.OpenFile(pictureBox2);
        }

        private void CutAndScalingBtn_Click(object sender, EventArgs e)
        {
            imageMass = CommonMethods.ReadData(_mapImage);
            var cutImage = ImageOperation.CutImage(imageMass, _mapImage.Height, _mapImage.Width);
            cutImage.Save(@"E:\imga.bmp");
            _mapImage = ImageOperation.ScaleImage(cutImage);
            //_mapImage.Save(@"E:\img.jpg");
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            var scaleImageMass = CommonMethods.ReadData(_mapImage, true);
            var treshold = Convert.ToInt32(textBox1.Text);
            var binarizationMass = MassOperation.GlobalMethod(_mapImage, scaleImageMass, treshold);
            var skeletObj = new Skeletonizator(binarizationMass);
            var thiningMass = skeletObj.SkeletonZhangSuen();
            var map = CommonMethods.FilBitmap(thiningMass, _mapImage.Height, _mapImage.Width);
            CommonMethods.SaveAndShow(map, pictureBox2);
        }

        

        

       

        

       


    }
}
