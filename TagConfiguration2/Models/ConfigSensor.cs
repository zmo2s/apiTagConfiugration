using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TagConfiguration2.Models
{
    public class ConfigSensor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool dureeAiTotOut { get; set; }
        public bool modeMag { get; set; }
        public bool sesibilitePir { get; set; }
        public int _idConfigBase { get; set; }
    }
}
