using System.Threading.Tasks;

namespace POC_UserService.Commons.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}
