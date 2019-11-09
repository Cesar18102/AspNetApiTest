using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class InvalidLoginException : ResponseException
    {
        public InvalidLoginException() : base("Invalid login", HttpStatusCode.BadRequest) { }
    }
}