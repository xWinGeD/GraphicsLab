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
        public  Bitmap[] OpenFile(params PictureBox[] boxes)
        {
            var imageMass = new Bitmap[25];

            using (StreamReader srReader = File.OpenText(@"E:\Lab2\FilePath.txt"))
            {
                int i = 0;
                string line = null;

                while ((line = srReader.ReadLine()) != null)
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

       
        public  void SaveAndShow(Bitmap map, PictureBox box)
        {
            var saveImage = new SaveFileDialog { Filter = " bmp files (*.bmp ) | *.bmp | All files (*. * ) | * . * " };
            saveImage.ShowDialog();
            map.Save(saveImage.FileName);
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.ImageLocation = saveImage.FileName;

        }
    }
}
