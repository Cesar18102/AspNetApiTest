using System;

using Newtonsoft.Json;

namespace TestAppClient.ServerAccess.Impl
{
    [JsonObject]
    public class ResponseException : Exception
    {
        [JsonRequired]
        public string message { get; private set; }

        [JsonConstructor]
        public ResponseException() { }
        
        public ResponseException(string message) { this.message = message; }

        public override string ToString() => "{ \"message\" : \"" + message + "\" }";
    }
}
