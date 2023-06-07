using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace pisV228._4
{
    public static class ReportMaker
    {
        public static void MakeReportOrganzation(List<Organization> organizations, string pathFile)
        {
            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)excel.ActiveSheet;

            var organizationType = typeof(Organization);
            var propertys = organizationType.GetProperties();
            for (int i = 0; i < organizations.Count; i++)
            {
                for (int j = 0; j < propertys.Length; j++)
                    wsh.Cells[i + 2, j + 1] = propertys[j].GetValue(organizations[i]);
            }

            for (int j = 0; j < propertys.Length; j++)
            {
                wsh.Cells[1, j + 1] = propertys[j].Name;
                wsh.Columns[j + 1].AutoFit();
            }
            excel.Visible = true;
            wsh.SaveAs(pathFile);
        }

        public static void MakeReportContracts(List<MunicipalContract> contracts, string pathFile)
        {
            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)excel.ActiveSheet;

            var organizationType = typeof(Organization);
            var propertys = organizationType.GetProperties();
            for (int i = 0; i < contracts.Count; i++)
            {
                for (int j = 0; j < propertys.Length; j++)
                    wsh.Cells[i + 2, j + 1] = propertys[j].GetValue(contracts[i]);
            }

            for (int j = 0; j < propertys.Length; j++)
            {
                wsh.Cells[1, j + 1] = propertys[j].Name;
                wsh.Columns[j + 1].AutoFit();
            }
            excel.Visible = true;
            wsh.SaveAs(pathFile);
        }

        public static void MakeReportAnimals(List<Animal> animals, string pathFile)
        {
            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)excel.ActiveSheet;

            var organizationType = typeof(Organization);
            var propertys = organizationType.GetProperties();
            for (int i = 0; i < animals.Count; i++)
            {
                for (int j = 0; j < propertys.Length; j++)
                    wsh.Cells[i + 2, j + 1] = propertys[j].GetValue(animals[i]);
            }

            for (int j = 0; j < propertys.Length; j++)
            {
                wsh.Cells[1, j + 1] = propertys[j].Name;
                wsh.Columns[j + 1].AutoFit();
            }
            excel.Visible = true;
            wsh.SaveAs(pathFile);
        }
    }
}
