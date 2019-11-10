using System.Collections.Generic;

namespace TestAppClient.ServerAccess.Decl
{
    public enum QueryMethod
    {
        GET,
        POST
    };

    public interface IQuery
    {
        QueryMethod Method { get; }
        string ServerMethod { get; }
        IDictionary<string, string> Parameters { get; }
        string ParametersString { get; }
        string QueryBody { get; }
        IList<string> NeededHeaders { get; }
    }
}
