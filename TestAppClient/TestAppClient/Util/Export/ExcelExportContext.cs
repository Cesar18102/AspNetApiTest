using System.Linq;
using System.Drawing;
using System.Reflection;
using System.Collections.Generic;

using Microsoft.Office.Interop.Excel;

namespace TestAppClient.Util.Export
{
    public class ExcelExportContext : IExportContext
    {
        public void Export<T>(string filename, IEnumerable<T> data, string sheetName = "sheet")
        {
            Application App = new Application();
            Workbook Document = App.Workbooks.Add();
            Worksheet Sheet = (Worksheet)Document.Worksheets.Add();

            PropertyInfo[] properties = typeof(T).GetProperties();

            (Sheet.Range[Sheet.Cells[1,1], Sheet.Cells[1, properties.Length]] as Range).Interior.Color = ColorTranslator.ToOle(Color.Gray);
            Range Cells = Sheet.Range[Sheet.Cells[1, 1], Sheet.Cells[data.Count() + 2, properties.Length]] as Range;

            for (int i = 0; i < properties.Length; i++)
                Cells[1, i + 1] = properties[i].Name;

            for (int i = 0; i < data.Count(); i++)
                for (int j = 0; j < properties.Length; j++)
                    Cells[i + 2, j + 1] = properties[j].GetValue(data.ElementAt(i))?.ToString();

            Sheet.Name = sheetName;

            Document.SaveAs(filename);
            Document.Close();
        }
    }
}
