using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace pisV228._4.Controllers
{
    public static class ReportMaker
    {
        public static void MakeReport(List<string> data)
        {
            var absolutePath = Path.GetFullPath("newBook.xltx");

            Excel.Application ex = new Excel.Application();
            ex.Workbooks.Add(absolutePath);

            double sum = 0;//Вычисляемая статистика
            int countColumns = 7;
            int countRows = data.Count / countColumns;
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    var cell = data[i * countRows + countColumns];
                    /*if (j == dataGridView1.Columns.Count - 1)
                    {
                        sum += Convert.ToDouble(cell);
                        ex.Cells[j + 1][i + 1] = Convert.ToDouble(cell);
                    }
                    else ex.Cells[j + 1][i + 1] = cell;*/
                    ex.Cells[j + 1][i + 1] = cell;
                }
            }

            //ex.Cells[countColumns][countRows + 2] = sum;
            //ex.Cells[countColumns - 1][countRows + 2] = "Расход горючего:";
            //ex.Range[$"E{countRows + 2}", $"F{countRows + 2}"].Font.Bold = true;
            //ex.Cells[countColumns][countRows + 2].Interior.Color = 65535;

            ex.Columns.AutoFit();
            ex.Visible = true;
        }
    }
}
