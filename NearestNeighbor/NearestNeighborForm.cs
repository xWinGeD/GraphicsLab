using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Lab.NearestNeighbor
{
    public partial class NearestNeighborForm : Form
    {
        private Bitmap[] _bitmaps;
        private Bitmap _newMap;
        //private List<MassObj> _grayScaleList; 
        private MassObj[] _grayScaleList;
        private ShowMethods _showObj;

        public NearestNeighborForm()
        {
            InitializeComponent();

            _showObj = new ShowMethods();
        }

        private void OpenImagesButton_Click(object sender, EventArgs e)
        {
            _bitmaps = _showObj.OpenFile(
                                            pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                                            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                                            pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15,
                                            pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                                            pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25
                                         );

        }

      
        private void ToGrayScaleBtn_Click(object sender, EventArgs e)
        {
            var count = _bitmaps.Count(t => t != null);

            var pTask = new Task<MassObj[]>(() =>
            {
                var result = new MassObj[count];
                var tsk = new Task<MassObj>[count];

                for (int i = 0; i < count; i++)
                {
                    int i1 = i;
                    
                    var @class = (i >= 0 && i <= 4) ? 1
                        : (i > 4 && i <= 9)   ? 2
                        : (i > 9 && i <= 14)  ? 3
                        : (i > 14 && i <= 19) ? 4
                        : (i > 19 && i <= 24) ? 5
                        : 0;

                    
                    tsk[i] = new Task<MassObj>(() => result[i1] = GrayScaleOperations.ToGrayScale(_bitmaps[i1],i1+1,@class), TaskCreationOptions.AttachedToParent);
                    tsk[i].Start();
                }

                return result;
            });

            pTask.Start();
            pTask.Wait();

            _grayScaleList = pTask.Result;

            //var map = GrayScaleOperations.FilBitmap(_grayScaleList[0].Mass, _grayScaleList[0].Height, _grayScaleList[0].Width);
            // _showObj.SaveAndShow(map,pictureBox26);

        }

        private void OpenNewImageButton_Click(object sender, EventArgs e)
        {
            _newMap = _showObj.OpenImage(pictureBox26);

            var newImage = new MassObj();
            newImage = GrayScaleOperations.ToGrayScale(_newMap, 26, 0);

            _grayScaleList = GrayScaleOperations.EuclideanDistance(_grayScaleList, newImage);

        }

        private void ToGrayBtn_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows.Clear();

            var Rsr = _grayScaleList.Max(t => t.R) / 2;
            var cl =  GrayScaleOperations.FindClass(_grayScaleList, Rsr);

            label26.Text = Rsr.ToString();
            label27.Text = cl.ToString();

            _showObj.BuildGrid(dataGridView1);

            for (int i = 0; i < _grayScaleList.Length; i++)
            {
                int i1 = i;
                _showObj.AddResultToGrid(_grayScaleList[i1], dataGridView1);
            }



        }
    }
}
