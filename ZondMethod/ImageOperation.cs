using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using AForge.Imaging.Filters;
using Lab.ZondMethod.Data;

namespace Lab.ZondMethod
{
    public static class ImageOperation
    {

        //cut image and scalling it
        public static Bitmap CutImage(int[,] mass, int height, int width)
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

            var map = new Bitmap((maxW.X - minW.X) + 3, (maxH.Y - minH.Y) + 3, PixelFormat.Format24bppRgb);

            for (int i = 0; i < height; i++)
            {
                if (i >= minH.Y - 1 && i <= maxH.Y + 1)
                {
                    y++;
                    x = 0;
                }

                for (int j = 0; j < width; j++)
                {
                    if (i >= minH.Y - 1 && i <= maxH.Y + 1 && j >= minW.X - 1 && j <= maxW.X + 1)
                    {
                        map.SetPixel(x, y, mass[i, j] == 1 ? Color.Black : Color.White);
                        x++;
                    }
                }
            }

            return map;
        }

        //scaling image
        public static Bitmap ScaleImage(Bitmap mmap)
        {
            var obj = new ResizeNearestNeighbor(50, 50);
            var result = obj.Apply(mmap);
            return result;
        }

        public static Dictionary<int, int> CompareResult(Dictionary<int, List<Points>> zondDictionary, List<Points> imageList)
        {
            var result = new Dictionary<int, int>();
            int key = 1;

            foreach (var temp in zondDictionary)
            {
                IEnumerable<Points> sequence = temp.Value.Intersect(imageList, new ListComparer());
                var intersectCount = sequence.Count();
                result.Add(key, intersectCount);
                key++;
            }

            return result;
        }

    }


}
