using System.Threading.Tasks;

namespace POC_UserService.Commons
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }
}
