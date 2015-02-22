﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab.ZondMethod
{
    public static class Methods
    {
        public static HashSet<Points> list  = new HashSet<Points>();
        public static Dictionary<int, List<Points>> FindZond(int height, int width, int[,] mass)
        {
            

            var tempMass = new int[height + 2, width + 2];
            for (int i = 1; i < height + 1; i++)
            {
                for (int j = 1; j < width + 1; j++)
                {
                    tempMass[i, j] = mass[i - 1, j - 1];
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (tempMass[i, j] == 1)
                    {
                        list.Add(new Points{Y = i, X = j});
                        Rec(tempMass, i, j);
                    }
                }
            }
           
            int fg;
            return null;
        }

        public static int Rec(int[,] tempMass, int i, int j)
        {
            int corx, cory;
            if (tempMass[i - 1, j - 1] == 1)
            {
                list.Add(new Points { Y = i-1, X = j-1 });
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i - 1, j] == 1)
            {
                list.Add(new Points { Y = i - 1, X = j });
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i - 1, j + 1] == 1)
            {
                list.Add(new Points { Y = i - 1, X = j + 1});
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i, j - 1] == 1)
            {
                list.Add(new Points { Y = i, X = j - 1 });
                tempMass[i, j] = 0;
                cory = i;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }
           
            else if (tempMass[i, j + 1] == 1)
            {
                list.Add(new Points { Y = i, X = j + 1});
                tempMass[i, j] = 0;
                cory = i;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j - 1] == 1)
            {
                list.Add(new Points { Y = i, X = j - 1 });
                tempMass[i, j] = 0;
                cory = i;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j] == 1)
            {
                list.Add(new Points { Y = i + 1, X = j });
                tempMass[i, j] = 0;
                cory = i + 1;
                corx = j;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j + 1] == 1)
            {
                list.Add(new Points {Y = i + 1, X = j + 1});
                tempMass[i, j] = 0;
                cory = i + 1;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }

            tempMass[i, j] = 0;
            return 1;
        }
        
    }
}
