using System;
using System.Linq;
using System.Reflection;
using System.Data.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AspNetBlankAppTest.Repo.Impl
{
    public abstract class Repo
    {
        protected async Task<IEnumerable<T>> GetRecords<T>(DbCommand command, params (Type type, string field)[] map)
        {
            using (DbDataReader dataReader = await command.ExecuteReaderAsync())
            {
                List<T> result = new List<T>();

                if (!dataReader.HasRows)
                    return result;

                ConstructorInfo constructor = typeof(T).GetConstructor(map.Select(m => m.type).ToArray());

                while (dataReader.Read())
                    result.Add((T)constructor.Invoke(map.Select(m => dataReader[m.field].Equals(DBNull.Value) ? null : dataReader[m.field]).ToArray()));

                return result;
            }
        }
    }
}