using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;

namespace AspNetBlankAppTest.Repo.Decl
{
    public interface IUserRepo
    {
        Task Add(UserCredintails credintails);
        Task<IEnumerable<UserInfo>> GetAll();
        Task<UserInfo> FindByLogin(string login);
        Task<UserSession> LogIn(UserCredintails credintails);
    }
}
