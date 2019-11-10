using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;

using TestAppClient.Model;

namespace TestAppClient.ServerInteraction.QueryFactories
{
    public abstract class QueryFactory
    {
        protected async Task<IDictionary<string, string>> ExtractQueryParameters<T>(T item) where T : ModelElement
        {
            IDictionary<string, string> data = new Dictionary<string, string>();

            await Task.Run(() =>
            {
                foreach (PropertyInfo PI in item.GetType().GetProperties())
                {
                    string propertyValue = JsonConvert.SerializeObject(PI.GetValue(item)).Trim('\"');
                    data.Add(PI.Name, propertyValue);
                }
            });

            return data;
        }
    }
}
