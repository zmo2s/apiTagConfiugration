using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TagConfiguration2.Models
{
   
   [BsonIgnoreExtraElements]
    public class ConfigBase
    {

        public ObjectId _id { get; set; }
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
        public Config400 config400 { get; set; }
       
        
    }
}
