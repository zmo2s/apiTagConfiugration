using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TagConfiguration2.Models
{
    public class Config400
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool dataToDownload { get; set; }
        public bool dtm { get; set; }
        public bool eventDTM1 { get; set; }
        public bool eventPeriod1 { get; set; }
        public bool eventPeriod2 { get; set; }
        public bool eventTx { get; set; }
        public bool eventTxSeconde { get; set; }
        public bool framePlayloadNumber { get; set; }
        public bool periodeEmssionSecondaire { get; set; }
        public bool periodeMesurCapteur { get; set; }
        public int _idConfigBase { get; set; }
    }
}
