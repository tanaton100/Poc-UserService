using System.Threading.Tasks;

namespace AdvancedInfoService.Mimo.gitlabservice.Commons.Mongo
{
    public interface IMongoDbSeeder
    {
        Task SeedAsync();
    }
}
