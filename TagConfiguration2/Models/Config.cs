using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TagConfiguration2.Models
{
  
    public class Config
    {
        public ObjectId _id { get; set; }
        public string format { get; set; }
        public string model { get; set; }
        public string version { get; set; }
        public ConfigBase configBase { get; set; }

    }
}
