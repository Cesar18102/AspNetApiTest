using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;

namespace TestAppClient.Util
{
    public static class ObjectCollectionToDataTableConverter
    {
        public static DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo prop in properties)
                dt.Columns.Add(prop.Name, prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = dt.NewRow();

                foreach (PropertyInfo prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
