

namespace TagConfiguration2.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Driver;
    [BsonIgnoreExtraElements]
    public class TagInput
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string format { get; set; }
        public string model { get; set; }
        public string version { get; set; }
        public MongoDBRef configBase { get; set; }
    }
}
