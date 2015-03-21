using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.NearestNeighbor
{
    public static class GrayScaleOperations
    {
        public static MassObj ToGrayScale(Bitmap map)
        {
            //Read data
            var massR = new double[map.Height, map.Width];
            var massG = new double[map.Height, map.Width];
            var massB = new double[map.Height, map.Width];

            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    Color srcPixel = map.GetPixel(j, i);
                    massR[i, j] = srcPixel.R;
                    massG[i, j] = srcPixel.G;
                    massB[i, j] = srcPixel.B;
                }
            }

            //ToGrayScale

            int temp;
            int k = 0;
            var massTemp = new double[3];
            var finalMass = new double[map.Height, map.Width];
            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    k = 0;
                    massTemp[k] = massR[i, j];
                    massTemp[++k] = massG[i, j];
                    massTemp[++k] = massB[i, j];
                    temp = Convert.ToInt32((massTemp.Max() + massTemp.Min()) / 2);
                    finalMass[i, j] = temp;
                }
            }



            return new MassObj {Mass = finalMass};

        }

        //public static Bitmap FilBitmap(double[,] temp, int height, int width)
        //{
        //    var map = new Bitmap(width, height);

        //    for (int i = 0; i < height; i++)
        //    {
        //        for (int j = 0; j < width; j++)
        //        {
        //            map.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(temp[i, j]), Convert.ToInt32(temp[i, j]), Convert.ToInt32(temp[i, j])));
        //        }
        //    }
            

        //    return map;
        //}


    }
}
