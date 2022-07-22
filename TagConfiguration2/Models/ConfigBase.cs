using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TagConfiguration2.Models
{
    public class ConfigBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool dureeEvent { get; set; }
        public bool isActivateTag { get; set; }
        public bool isLoggerActivate { get; set; }
        public bool puissanceDbm { get; set; }
        public bool recurrenceAdvertising { get; set; }
        public bool recurrenceEvent { get; set; }
        public bool recurrenceLog { get; set; }
        public bool useBUzzer { get; set; }
        public bool useLED { get; set; }
        public bool useModConnected { get; set; }
        public int _idTagInput { get; set; }
        public int _idConfig400 { get; set; }
        public int _idConfigSensor { get; set; }
    }
}
