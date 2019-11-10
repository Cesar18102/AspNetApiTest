using System.Threading.Tasks;

namespace TestAppClient.ServerAccess.Decl
{
    public interface IServerCommunicator
    {
        string ServerURL { get; set; }
        Task<IServerResponse> SendQuery(IQuery query);
    }
}
