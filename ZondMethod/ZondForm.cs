﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab.Extentions;
using Lab.ZondMethod.Data;
using Lab.ZondMethod.ShowMetods;

namespace Lab.ZondMethod
{
    public partial class ZondForm : Form
    {
        private Bitmap _mapZond, _mapImage;
        private int[,] _zondMass, _imageMass, _thiningMass;
        private string _fileName;
        private Dictionary<int, List<Points>> _dictionary;


        public ZondForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            _mapZond = CommonMethods.OpenFile(pictureBox1);
        }

        private void ReadZondBtn_Click(object sender, EventArgs e)
        {
            _zondMass = CommonMethods.ReadData(_mapZond);
            _dictionary = ZondMethods.FindZond(_mapZond.Height, _mapZond.Width, _zondMass);
            ShowResult.BuildGrid(_dictionary.Count, dataGridView2);
        }

        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            _mapImage = CommonMethods.OpenFile(pictureBox2, out _fileName);

            if (_mapImage == null)
            {
                return;
            }

            //СutAndScaleImage
            _imageMass = CommonMethods.ReadData(_mapImage);
            var cutImage = ImageOperation.CutImage(_imageMass, _mapImage.Height, _mapImage.Width);
            _mapImage = ImageOperation.ScaleImage(cutImage);

            //Result
            var scaleImageMass = CommonMethods.ReadData(_mapImage);
            var skeletObj = new Skeletonizator(scaleImageMass);
            _thiningMass = skeletObj.SkeletonZhangSuen();//change
            Bitmap map = CommonMethods.FilBitmap(_thiningMass, _mapImage.Height, _mapImage.Width);
                       
            /*map.SaveToFile("result");*/
            CommonMethods.SaveAndShow(map,pictureBox2);

        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            var imagePointList = _thiningMass.BlackPxToList(_mapImage.Height, _mapImage.Width);

            Dictionary<int, int> compareResult = ImageOperation.CompareResult(_dictionary, imagePointList);

            ShowResult.AddResultToGrid(_fileName, compareResult, dataGridView2);

        }




















    }
}
