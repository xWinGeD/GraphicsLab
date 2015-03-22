using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab.ZondMethod.ShowMetods
{
    public static class ShowResult
    {
        private static int _count;
        public static void BuildGrid(int zondCount, DataGridView grid)
        {
            grid.ColumnCount = zondCount + 3;//кол-во зондов + имя файла + результат + класс изображения
            grid.ColumnHeadersVisible = true;
            grid.RowHeadersVisible = false;

            var columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 10, FontStyle.Bold)
            };

            grid.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Width = 90;
            }

            grid.Columns[0].Name = "FileName";

            for (int i = 1; i <= zondCount; i++)
            {
                grid.Columns[i].Name = i.ToString();
            }

            //TODO Hard
            grid.Columns[4].Name = "Letter";
            grid.Columns[5].Name = "Class";
        }

        public static void AddResultToGrid(string fileName, Dictionary<int, int> compareResult, DataGridView grid)
        {
            grid.Rows.Add();

            for (var i = _count; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = fileName;

                for (var j = 1; j <= compareResult.Count; j++)
                {
                    int intersect;  //intersect count
                    compareResult.TryGetValue(j, out intersect);
                    grid.Rows[i].Cells[j].Value = intersect;
                }
                var letter = ZondMethods.FindLetter(compareResult);

                foreach (var let in letter)
                {
                    grid.Rows[i].Cells[4].Value = @let.Key;
                    grid.Rows[i].Cells[5].Value = @let.Value;
                }
                
            }
            //TODO HARDCORE
           
           _count++;//для того чтобы записывать в новую строку
        }
    }
}
