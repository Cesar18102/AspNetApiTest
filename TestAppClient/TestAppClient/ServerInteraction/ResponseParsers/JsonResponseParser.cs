using System.Collections.Generic;

using Newtonsoft.Json;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.ServerInteraction.ResponseParsers
{
    public class JsonResponseParser : IResponseParser
    {
        public T Parse<T>(IServerResponse modelElementJSON) where T : ModelElement
        {
            ResponseException ex = null;

            try { ex = JsonConvert.DeserializeObject<ResponseException>(modelElementJSON.Data); }
            catch { return JsonConvert.DeserializeObject<T>(modelElementJSON.Data); }

            throw ex;
        }

        public IEnumerable<T> ParseCollection<T>(IServerResponse modelElementJSON) where T : ModelElement
        {
            ResponseException ex = null;

            try { ex = JsonConvert.DeserializeObject<ResponseException>(modelElementJSON.Data); }
            catch { return JsonConvert.DeserializeObject<IEnumerable<T>>(modelElementJSON.Data); }

            throw ex;
        }
    }
}
