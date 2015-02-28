using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab.ZondMethod.ShowMetods;

namespace Lab.ZondMethod
{
    public partial class ZondForm : Form
    {
        private Bitmap _mapZond,_mapImage;
        private int[,] zondMass,imageMass,thiningMass;
        private string fileName;
        private Dictionary<int, List<Points>> dictionary;


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

        private void ReadZondBtn_Click(object sender, EventArgs e)
        {
            zondMass = CommonMethods.ReadData(_mapZond);
            dictionary = ZondMethods.FindZond(_mapZond.Height, _mapZond.Width, zondMass);
            ShowResult.BuildGrid(dictionary.Count, dataGridView2);
        }

        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            _mapImage = CommonMethods.OpenFile(pictureBox2,out fileName);
        }

        private void CutAndScalingBtn_Click(object sender, EventArgs e)
        {
            imageMass = CommonMethods.ReadData(_mapImage);
            var cutImage = ImageOperation.CutImage(imageMass, _mapImage.Height, _mapImage.Width);
           _mapImage = ImageOperation.ScaleImage(cutImage);
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            var scaleImageMass = CommonMethods.ReadData(_mapImage);
            var skeletObj = new Skeletonizator(scaleImageMass);
            thiningMass = skeletObj.SkeletonZhangSuen();//change
            var map = CommonMethods.FilBitmap(thiningMass, _mapImage.Height, _mapImage.Width);
            CommonMethods.SaveAndShow(map, pictureBox2);
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> compareResult;//key - zondNumber, value - intersect count

            var imagePointList = thiningMass.BlackPxToList(_mapImage.Height, _mapImage.Width);
            compareResult = ImageOperation.CompareResult(dictionary,imagePointList);
            ShowResult.AddResultToGrid(fileName,compareResult,dataGridView2);
           
        }

      

       

        

        

       

        

       


    }
}
