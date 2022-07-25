using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TagConfiguration2.Models
{
    public class Transaction
    {
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

        public bool dureeAiTotOut { get; set; }
        public bool modeMag { get; set; }
        public bool sesibilitePir { get; set; }

        public string format { get; set; } = null!;
        public string modele { get; set; } = null!;
        public string version { get; set; } = null!;
    }
}
