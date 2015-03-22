using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.NearestNeighbor
{
    public class ShowMethods
    {
        private static int _count;

        public  Bitmap[] OpenFile(params PictureBox[] boxes)
        {
            var imageMass = new Bitmap[25];

            using (StreamReader srReader = File.OpenText(@"E:\Lab2\FilePath.txt"))
            {
                int i = 0;
                string line = null;

                while ((line = srReader.ReadLine()) != "")
                {
                    imageMass[i] = (Bitmap)Image.FromFile(line);
                    boxes[i].Image = imageMass[i];
                    boxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    i++;
                }
                
            }

            
            return imageMass;
        }

        public  Bitmap OpenImage(PictureBox box)
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

       
        public void SaveAndShow(Bitmap map, PictureBox box)
        {
            var saveImage = new SaveFileDialog { Filter = " bmp files (*.bmp ) | *.bmp | All files (*. * ) | * . * " };
            saveImage.ShowDialog();
            map.Save(saveImage.FileName);
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.ImageLocation = saveImage.FileName;

        }

        public void BuildGrid(DataGridView grid)
        {
            grid.ColumnCount = 403;
            grid.ColumnHeadersVisible = true;
            grid.RowHeadersVisible = false;

            var columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 10, FontStyle.Bold)
            };

            grid.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Width = 60;
            }

            grid.Columns[0].Name = "N";
            grid.Columns[1].Name = "Class";
            grid.Columns[2].Name = "R";

            for (int i = 3; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Name = (i-2).ToString();
            }

            //TODO Hard
       }

        public void AddResultToGrid(MassObj obj, DataGridView grid)
        {
            grid.Rows.Add();

            var t = 3;

            for (var i = _count; i < grid.RowCount-1; i++)
            {
                grid.Rows[i].Cells[0].Value = obj.Number;
                grid.Rows[i].Cells[1].Value = obj.Class;
                grid.Rows[i].Cells[2].Value = obj.R;

                  for (int k = 0; k < obj.Height; k++)
                  {
                        for (int l = 0; l < obj.Width; l++)
                        {
                            grid.Rows[i].Cells[t].Value = obj.Mass[k,l];
                            t++;
                        }
                   }
               //}
                
            }
            //TODO HARDCORE

            _count++;//для того чтобы записывать в новую строку
        }

    }
}
