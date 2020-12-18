using AdvancedInfoService.Mimo.GitLabService.Commons.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace POC_UserService.Models
{
    [BsonIgnoreExtraElements]
    public class User : IObjectIdIdentifiable
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public ObjectId Id { get; set; }
    }

   
}
