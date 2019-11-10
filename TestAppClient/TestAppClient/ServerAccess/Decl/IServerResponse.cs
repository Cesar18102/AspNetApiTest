using System.Collections.Generic;

namespace TestAppClient.ServerAccess.Decl
{
    public interface IServerResponse
    {
        string Data { get; }
        IDictionary<string, string> Headers { get; }
    }
}
