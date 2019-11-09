using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Util;

namespace AspNetBlankAppTest.Repo.Decl
{
    public interface IUserRepo
    {
        Task Add(UserCredintails credintails);
        Task<List<UserInfo>> GetAll();
        Task<UserInfo> FindByLogin(string login);
        Task<UserInfo> LogIn(UserCredintails credintails);
    }
}
