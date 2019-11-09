using System.Text.RegularExpressions;

namespace AspNetBlankAppTest.Util.Validation.Patterns
{
    public static class UserPatterns
    {
        public static readonly Regex LOGIN_PATTERN = new Regex("^[A-Za-z0-9]{5,20}$");
        public static readonly Regex PASSWORD_PATTERN = new Regex("^[A-Za-z0-9]{8,20}$");
    }
}