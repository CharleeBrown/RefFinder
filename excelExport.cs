using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;



namespace ReferencesFind
{
    class excelExport
    {
        public void CreateSpreadsheetWorkbook(int refCount, List<string> references)
        {
            Application excel = new Microsoft.Office.Interop.Excel.Application();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Workbook workbook = excel.Application.Workbooks.Add();
            Worksheet sheet = workbook.Worksheets[1];
            Range A1 = sheet.Cells[1, 1];
            A1.Value = "References";
            for(int i=1; i < references.Count; i++)
            {
                foreach(string refer in  references)
                        {
                sheet.Cells[i, 1].Value = refer;
                            }
              
            }
            workbook.SaveAs(path +@"\Tester.xlsx");
        }
    }
}
