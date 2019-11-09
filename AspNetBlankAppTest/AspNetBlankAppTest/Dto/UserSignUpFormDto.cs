using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace AspNetBlankAppTest.Dto
{
    [JsonObject]
    public class UserSignUpFormDto : IForm
    {
        [Required]
        public string login { get; private set; }

        [Required]
        public string password { get; private set; }

        public UserSignUpFormDto(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}