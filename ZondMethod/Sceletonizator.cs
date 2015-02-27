using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.ZondMethod
{
    public  class Skeletonizator
    {
        private int[,] bitmap;

        public Skeletonizator(int[,] bitmap)
        {
            this.bitmap = bitmap;
        }

        public int[,] SkeletonZhangSuen()
        {
            int i, j, w, h, b, a, p1, p2, p3, p4;
            int[] p = new int[8];
            bool flag = true;

            w = bitmap.GetLength(0);
            h = bitmap.GetLength(1);
            int[,] markMap = new int[w, h];

            while (flag)
            {
                flag = false;

                for (i = 1; i < w - 1; i++)
                {
                    for (j = 1; j < h - 1; j++)
                    {
                        if (bitmap[i, j] == 0)
                        {
                            markMap[i, j] = 0;
                            continue;
                        }

                        a = Tla(bitmap, i, j, ref p, out b);   
                        p1 = p[0] * p[2] * p[4];
                        p2 = p[2] * p[4] * p[6];

                        if ((a == 1) && ((b >= 2) && (b <= 6)) &&
                                (p1 == 0) && (p2 == 0))
                        {
                            markMap[i, j] = 1;
                            flag = true;
                        }
                        else
                            markMap[i, j] = 0;
                    }
                }
                DeleteMarked(markMap, ref bitmap);

              
                for (i = 1; i < w - 1; i++)
                {
                    for (j = 1; j < h - 1; j++)
                    {
                        if (bitmap[i, j] == 0)
                        {
                            markMap[i, j] = 0;
                            continue;
                        }

                        a = Tla(bitmap, i, j, ref p, out b);   
                        p1 = p[0] * p[2] * p[6];
                        p2 = p[0] * p[4] * p[6];

                        if ((a == 1) && ((b >= 2) && (b <= 6)) &&
                                (p1 == 0) && (p2 == 0))
                        {
                            markMap[i, j] = 1;
                            flag = true;
                        }
                        else
                            markMap[i, j] = 0;
                    }
                }
                DeleteMarked(markMap, ref bitmap);
            }

            for (i = 1; i < w - 1; i++)
            {
                for (j = 1; j < h - 1; j++)
                {
                    if (bitmap[i, j] == 0)
                    {
                        markMap[i, j] = 0;
                        continue;
                    }

                    Tla(bitmap, i, j, ref p, out b);   

                    p1 = ((p[7] == 1) ? 0 : 1) * p[2] * p[4];
                    p2 = ((p[3] == 1) ? 0 : 1) * p[6] * p[0];
                    p3 = ((p[1] == 1) ? 0 : 1) * p[4] * p[6];
                    p4 = ((p[5] == 1) ? 0 : 1) * p[0] * p[2];

                    if (p1 == 1 || p2 == 1 || p3 == 1 || p4 == 1)
                        bitmap[i, j] = 0;
                }
            }

            return bitmap;
        }

        private int Tla(int[,] image, int i, int j, ref int[] p, out int b)
        {
            int m = 0, n = 0;

            p[0] = image[i - 1, j];
            p[1] = image[i - 1, j + 1];
            p[2] = image[i, j + 1];
            p[3] = image[i + 1, j + 1];
            p[4] = image[i + 1, j];
            p[5] = image[i + 1, j - 1];
            p[6] = image[i, j - 1];
            p[7] = image[i - 1, j - 1];

            for (int k = 0; k < 7; k++)
            {
                if ((p[k] == 0) && (p[k + 1] == 1))
                    m++;
                n += p[k];
            }

            if ((p[7] == 0) && (p[0] == 1))
                m++;

            n += p[7];
            b = n;

            return m;
        }

        private void DeleteMarked(int[,] markBmp, ref int[,] bitMap)
        {
            int w = bitMap.GetLength(0);
            int h = bitMap.GetLength(1);
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    bitMap[i, j] -= markBmp[i, j];
        }
    }

}
