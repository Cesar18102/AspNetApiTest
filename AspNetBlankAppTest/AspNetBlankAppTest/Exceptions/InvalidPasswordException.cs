using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class InvalidPasswordException : ResponseException
    {
        public InvalidPasswordException() : base("Invalid password", HttpStatusCode.BadRequest) { }
    }
}