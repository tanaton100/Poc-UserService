using System;
using MongoDB.Bson.Serialization.Attributes;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public abstract class BaseEntity<T>  : IIdentifiable
    {
        public T Id { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime UpdatedDate { get; set; }

        protected BaseEntity(T id)
        {
            Id = id;
            SetUpdatedDate();
        }

        private void SetUpdatedDate()
            => UpdatedDate = DateTime.Now;
    }
    
}