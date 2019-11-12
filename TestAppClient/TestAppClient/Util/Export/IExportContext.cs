using System.Collections.Generic;

namespace TestAppClient.Util.Export
{
    public interface IExportContext
    {
        void Export<T>(string filename, IEnumerable<T> data, string sheetName = "");
    }
}
