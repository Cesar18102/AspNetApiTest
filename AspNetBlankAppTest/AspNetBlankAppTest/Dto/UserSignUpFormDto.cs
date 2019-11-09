using Newtonsoft.Json;

namespace AspNetBlankAppTest.Dto
{
    [JsonObject]
    public class UserSignUpFormDto
    {
        public string login { get; private set; }
        public string password { get; private set; }

        public UserSignUpFormDto(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}