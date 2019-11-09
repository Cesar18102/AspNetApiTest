using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class LogInFailedException : ResponseException
    {
        public LogInFailedException() : base("Log in failed", HttpStatusCode.Forbidden) { }
    }
}