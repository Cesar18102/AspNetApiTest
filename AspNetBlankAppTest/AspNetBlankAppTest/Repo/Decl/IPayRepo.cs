using System.Threading.Tasks;

using AspNetBlankAppTest.Models;

namespace AspNetBlankAppTest.Repo.Decl
{
    public interface IPayRepo
    {
        Task Add(PaymentInfo paymentInfo);
    }
}
