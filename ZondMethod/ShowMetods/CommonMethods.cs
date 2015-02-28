using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public static class CommonMethods
    {
        public static Bitmap OpenFile(PictureBox box)
        {
            var myDialog = new OpenFileDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = myDialog.FileName;

                var bm = new Bitmap(filename, true);
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                box.ImageLocation = filename;
                return bm;

            }
            return null;
        }
        public static Bitmap OpenFile(PictureBox box,out string fileName)
        {
            var myDialog = new OpenFileDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = myDialog.FileName;

                var bm = new Bitmap(fileName, true);
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                box.ImageLocation = fileName;
                return bm;

            }
            fileName = null;
            return null;
        }
        
        public static void SaveAndShow(Bitmap map, PictureBox box)
        {
            var saveImage = new SaveFileDialog { Filter = " bmp files (*.bmp ) | *.bmp | All files (*. * ) | * . * " };
            saveImage.ShowDialog();
            map.Save(saveImage.FileName);

            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.ImageLocation = saveImage.FileName;

        }

        //read px binary image
        public static int[,] ReadData(Bitmap map)
        {
            var mass = new int[map.Height, map.Width];
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    
                    Color srcPixel = map.GetPixel(j, i);
                    mass[i, j] = (int) srcPixel.GetBrightness();
                    if (mass[i, j] == 0)
                    {
                        mass[i, j] = 1;
                    }
                    else
                    {
                        mass[i, j] = 0;

                    }
                }
            }

            return mass;
        }
        //read shadding image
        public static int[,] ReadData(Bitmap map, bool s)
        {
            var mass = new int[map.Height, map.Width];
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    mass[i, j] = map.GetPixel(j, i).R;
                }
            }
            return mass;
        }

        public static void FillGrid(Bitmap map, int[,] mass, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.ColumnCount = map.Width;

            for (int i = 0; i < map.Width; i++)
            {
                DataGridViewColumn column = grid.Columns[i];
                column.Width = 35;
            }

            for (int i = 0; i < map.Height; i++)
            {
                grid.Rows.Add();
            }

            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    grid.Rows[i].Cells[j].Value = mass[i, j];
                }
            }
        }

        public static Bitmap FilBitmap(int[,] temp, int height, int width)
        {
            var map = new Bitmap(width,height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map.SetPixel(j, i, temp[i, j] == 1 ? Color.Black : Color.White);
                }
            }
            return map;
        }

    }
    
}
