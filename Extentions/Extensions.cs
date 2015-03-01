using System.Collections.Generic;
using Lab.ZondMethod;
using Lab.ZondMethod.Data;

namespace Lab.Extentions
{
    public static class Extensions
    {
        public static List<Points> BlackPxToList(this int[,] mass,int height, int width) 
        {
            var list = new List<Points>();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (mass[i, j] == 1)
                    {
                        list.Add(new Points{X = j, Y = i});
                    }
                }
            }

            return list;
        }
    }
}
