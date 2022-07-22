namespace TagConfiguration2.Models
{
    public class TagsConfigurationDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string TagInputCollectionName { get; set; } = null!;
    }
}
