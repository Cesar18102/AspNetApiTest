using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class InvalidDataException : ResponseException
    {
        public InvalidDataException() : base("Invalid data presented", HttpStatusCode.BadRequest) { }
    }
}