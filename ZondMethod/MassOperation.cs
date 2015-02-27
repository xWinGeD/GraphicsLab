using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.ZondMethod
{
    public static class MassOperation
    {
        //binarization
        public static int[,] GlobalMethod(Bitmap map, int[,] mass, int porog)
        {
            var finalMass = new int[map.Height, map.Width];

            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {
                    if (mass[i, j] <= porog)
                    {
                        finalMass[i, j] = 1;
                    }
                    else
                    {
                        finalMass[i, j] = 0;
                    }
                }
            }
            return finalMass;

        }
    }
}
