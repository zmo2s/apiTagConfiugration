

namespace TagConfiguration2.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class TagInput
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 
        public string format { get; set; } = null!;
        public string modele { get; set; } = null!;
        public string version { get; set; } = null!;
        public int _idConfigBase { get; set; } 
    }
}
