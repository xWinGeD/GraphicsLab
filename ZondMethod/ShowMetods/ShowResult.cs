using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Lab.ZondMethod.ShowMetods
{
    public static class ShowResult
    {
        private static int count = 0;
        public static void BuildGrid(int zondCount, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.ColumnCount = zondCount + 3;//кол-во зондов + имя файла + результат + класс изображения

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Width = 90;
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    grid.Rows.Add();
            //}
        }

        public static void AddResultToGrid(string fileName,Dictionary<int, int> compareResult, DataGridView grid)
        {
            int intersect;//intersect count

            count++;//для того чтобы записыватьв новую строку
            grid.Rows.Add();
            for (int i = count; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = fileName;
                for (int j = 1; j <= compareResult.Count; j++)
                {
                    compareResult.TryGetValue(j, out intersect);
                    grid.Rows[i].Cells[j].Value = intersect;
                }             

            }
        }

        
    }
}
