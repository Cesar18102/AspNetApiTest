using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace AspNetBlankAppTest.Dto
{
    [JsonObject]
    public class UserLogInFormDto : IForm
    {
        [Required]
        public string login { get; private set; }

        [Required]
        public string passwordEncoded { get; private set; }

        public string seed { get; private set; }

        public UserLogInFormDto(string login, string passwordEncoded, string seed)
        {
            this.login = login;
            this.passwordEncoded = passwordEncoded;
            this.seed = seed;
        }
    }
}