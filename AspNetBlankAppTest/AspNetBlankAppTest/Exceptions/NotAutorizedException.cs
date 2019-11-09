using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class NotAutorizedException : ResponseException
    {
        public NotAutorizedException() : base("Not authorized", HttpStatusCode.Unauthorized) { }
    }
}