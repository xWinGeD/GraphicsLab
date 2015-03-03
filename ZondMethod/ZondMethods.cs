using System.Collections.Generic;
using Lab.ZondMethod.Data;

namespace Lab.ZondMethod
{
    public static class ZondMethods
    {
        public static int Key = 0;
        public static Dictionary<int, List<Points>> Dictionary;
        public static List<Points> List;
        public static Dictionary<int, List<Points>> FindZond(int height, int width, int[,] mass)
        {
            Dictionary = new Dictionary<int, List<Points>>();

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
                        List = new List<Points> { new Points { Y = i - 1, X = j - 1 } };
                        Rec(tempMass, i, j);
                        Key++;
                        Dictionary.Add(Key, List);
                    }
                }
            }

            return Dictionary;
        }

        public static int Rec(int[,] tempMass, int i, int j)
        {
            int corx, cory;

            if (tempMass[i - 1, j - 1] == 1)
            {
                List.Add(new Points { Y = i - 2, X = j - 2 });
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i - 1, j] == 1)
            {
                List.Add(new Points { Y = i - 2, X = j - 1 });
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i - 1, j + 1] == 1)
            {
                List.Add(new Points { Y = i - 2, X = j });
                tempMass[i, j] = 0;
                cory = i - 1;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i, j - 1] == 1)
            {
                List.Add(new Points { Y = i - 1, X = j - 2 });
                tempMass[i, j] = 0;
                cory = i;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }

            else if (tempMass[i, j + 1] == 1)
            {
                List.Add(new Points { Y = i - 1, X = j });
                tempMass[i, j] = 0;
                cory = i;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j - 1] == 1)
            {
                List.Add(new Points { Y = i, X = j - 2 });
                tempMass[i, j] = 0;
                cory = i + 1;
                corx = j - 1;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j] == 1)
            {
                List.Add(new Points { Y = i, X = j - 1 });
                tempMass[i, j] = 0;
                cory = i + 1;
                corx = j;
                Rec(tempMass, cory, corx);
            }
            else if (tempMass[i + 1, j + 1] == 1)
            {
                List.Add(new Points { Y = i, X = j });
                tempMass[i, j] = 0;
                cory = i + 1;
                corx = j + 1;
                Rec(tempMass, cory, corx);
            }

            tempMass[i, j] = 0;

            return 1;
        }

        public static Dictionary<string, string> FindLetter(Dictionary<int, int> compareDictionary)
        {
            var resultDictionary = new Dictionary<string, string>();
            if ((compareDictionary[1] == 0 || compareDictionary[1] == 1) && (compareDictionary[2] >= 1
                && compareDictionary[2] <= 6) && compareDictionary[3] == 1 || compareDictionary[3] == 2
                || compareDictionary[3] == 0)
            {
                resultDictionary.Add("У", "A");
                return resultDictionary;
            }
            if ((compareDictionary[1] >= 5 && compareDictionary[1] >= 13)
                && (compareDictionary[2] == 2 || compareDictionary[2] == 1)
                && compareDictionary[3] >= 3 && compareDictionary[3] <= 12)
            {
                resultDictionary.Add("Х", "B");
                return resultDictionary;
            }
            if ((compareDictionary[1] == 3 && compareDictionary[2] == 2 && compareDictionary[3] == 1) ||
                (compareDictionary[1] == 10) || compareDictionary[1] > 10)
            {
                resultDictionary.Add("Ф", "C");
                return resultDictionary;
            }

            resultDictionary.Add("-", "not class");

            return resultDictionary;
        }
    }
}
