using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AForge;
using AForge.Imaging.Filters;
using ImageResizer;

namespace Lab.ZondMethod
{
    public static class ImageOperation
    {
        
        //cut image and scalling it
        public static Bitmap CutImage(int[,] mass,int height, int width)
        {
            //find parts image
           var listW = new List<Points>();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (mass[i, j] == 1)
                    {
                        listW.Add(new Points { X = j, Y = i });
                    }          
                }
            }
            var temp = listW.Min(t => t.X);
            var minW = listW.First(t => t.X == temp);
             temp = listW.Max(t => t.X);
            var maxW = listW.First(t => t.X == temp);

             temp = listW.Min(t => t.Y);
            var minH = listW.First(t => t.Y == temp);
             temp = listW.Max(t => t.Y);
            var maxH = listW.First(t => t.Y == temp);

            //cut
            int x = 0, y = -1;

            //var map = new Bitmap((maxW.X - minW.X) + 1, (maxH.Y - minH.Y) + 1);
            var map = new Bitmap((maxW.X - minW.X) + 1, (maxH.Y - minH.Y) + 1);

            for (int i = 0; i < height; i++)
            {
                if (i >= minH.Y && i <= maxH.Y)
                {
                    y++;
                    x = 0;
                }
                    
                for (int j = 0; j < width; j++)
                {
                    if (i >= minH.Y && i <= maxH.Y && j >= minW.X && j<= maxW.X)
                    {
                        map.SetPixel(x, y, mass[i, j] == 1 ? Color.Black : Color.White);
                        x++;
                    }
                }
            }
            
           return map;
        }

        //scaling image
        public static Bitmap ScaleImage(Bitmap map)
        {
            var settings = new ResizeSettings
            {
                Height = 50,
                Width = 50,
                Mode = FitMode.Pad,
                Format = "jpg",
                Scale = ScaleMode.Both,
                Quality = 100,
            };

            var scalingImage = ImageBuilder.Current.Build(map, settings);
            return scalingImage;
        }
       
        
    }
}
