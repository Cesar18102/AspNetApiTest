using System.Net;

namespace AspNetBlankAppTest.Exceptions
{
    public class UserConflictException : ResponseException
    { 
        public UserConflictException() : base("User already exists", HttpStatusCode.Conflict) { }
    }
}