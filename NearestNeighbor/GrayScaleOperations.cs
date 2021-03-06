﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.NearestNeighbor
{
    public static class GrayScaleOperations
    {
        public static MassObj ToGrayScale(Bitmap map,int n,int cl)
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

            return new MassObj {Number =  n,Class = cl,Mass = finalMass,Height = map.Height,Width = map.Width };

        }

        public static MassObj[] EuclideanDistance(MassObj[] massImages,MassObj image)
        {
            var pTask = new Task<MassObj[]>(() =>
            {
                var rMass = new MassObj[massImages.Length];
                var tsk = new Task<MassObj>[massImages.Length];
                double R = 0, sum = 0;

                for (int i = 0; i < massImages.Length; i++)
                {
                    MassObj temp = massImages[i];
                    int i1 = i;

                    tsk[i] = new Task<MassObj>(() =>
                    {
                        for (int j = 0; j < temp.Height; j++)
                        {
                            for (int k = 0; k < temp.Width; k++)
                            {
                                sum += Math.Pow((image.Mass[j, k] + temp.Mass[j, k]), 2);
                            }

                        }

                        R = Math.Sqrt(sum);
                        temp.R = R;
                        return rMass[i1] = temp;

                    }, TaskCreationOptions.AttachedToParent);

                    tsk[i].Start();

                   
                }

                return rMass;
            });

            pTask.Start();
            pTask.Wait();

            return pTask.Result;

        }

        public static int FindClass(MassObj[] mass,double r)
        {
            var list = mass.Select(t => t.R < r ? t : null).Where(temp => temp != null).ToList();

            var max = list.GroupBy(x => x.Class).Max(x => x.Count());

            var result = list.GroupBy(x => x.Class).Where(m => m.Count() == max).Select(q => q).ToList();

           var orDefault = result[0].FirstOrDefault();

           if (orDefault != null)
                return orDefault.Class;
            else
            {
                return 0;
            }
        }

        public static Bitmap FilBitmap(double[,] temp, int height, int width)
        {
            var map = new Bitmap(width, height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(temp[i, j]), Convert.ToInt32(temp[i, j]), Convert.ToInt32(temp[i, j])));
                }
            }


            return map;
        }


    }
}
