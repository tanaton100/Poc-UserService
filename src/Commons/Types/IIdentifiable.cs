using MongoDB.Bson;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public interface IIdentifiable
    {
    }
    public interface IObjectIdIdentifiable : IIdentifiable
    {
        ObjectId Id { get; set; }
    }

    public interface IIntIdentifiable : IIdentifiable
    {
        int Id { get; set; }

    }
    
    public interface IStringIdentifiable : IIdentifiable
    {
        string Id { get; set; }

    }
}