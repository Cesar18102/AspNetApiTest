using System.Collections.Generic;

using TestAppClient.Model;
using TestAppClient.ServerAccess.Decl;

namespace TestAppClient.ServerInteraction.ResponseParsers
{
    public interface IResponseParser
    {
        T Parse<T>(IServerResponse modelElementJSON) where T : ModelElement;
        IEnumerable<T> ParseCollection<T>(IServerResponse modelElementJSON) where T : ModelElement;
    }
}
