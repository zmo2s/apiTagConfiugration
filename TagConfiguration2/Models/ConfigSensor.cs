using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TagConfiguration2.Models
{
    
    public class ConfigSensor
    {
        public ObjectId _id { get; set; }
        public bool dureeAiTotOut { get; set; }
        public bool modeMag { get; set; }
        public bool sesibilitePir { get; set; }
  
    }
}
