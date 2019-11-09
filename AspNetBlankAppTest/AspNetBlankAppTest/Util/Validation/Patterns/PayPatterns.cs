using System.Text.RegularExpressions;

namespace AspNetBlankAppTest.Util.Validation.Patterns
{
    public static class PayPatterns
    {
        public static readonly Regex FIRST_NAME_PATTERN = new Regex("^[A-Za-zА-Яа-яЁё]{1,20}$");
        public static readonly Regex LAST_NAME_PATTERN = new Regex("^[A-Za-zА-Яа-яЁё]{1,30}$");
        public static readonly Regex PATRONYMIC_PATTERN = new Regex("^[A-Za-zА-Яа-яЁё]{1,20}$");
    }
}