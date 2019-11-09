using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class NoSuchUserException : ResponseException
    {
        public NoSuchUserException() : base("User doesn't exist", HttpStatusCode.NotFound) { }
    }
}