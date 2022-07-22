

namespace TagConfiguration2.Services
{
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;
    using TagConfiguration2.Models;
    public class TagInputService
    {

        private readonly IMongoCollection<TagInput> _tagInputCollection;

        public TagInputService(
            IOptions<TagsConfigurationDatabaseSettings> tafgConfigurationDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                tafgConfigurationDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                tafgConfigurationDatabaseSettings.Value.DatabaseName);

            _tagInputCollection = mongoDatabase.GetCollection<TagInput>(
                tafgConfigurationDatabaseSettings.Value.TagInputCollectionName);
        }

        public async Task<List<TagInput>> GetAsync() =>
            await _tagInputCollection.Find(_ => true).ToListAsync();

        public async Task<TagInput?> GetAsync(string id) =>
            await _tagInputCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(TagInput newTaginput) =>
            await _tagInputCollection.InsertOneAsync(newTaginput);

        public async Task UpdateAsync(string id, TagInput updatedTagInput) =>
            await _tagInputCollection.ReplaceOneAsync(x => x.Id == id, updatedTagInput);

        public async Task RemoveAsync(string id) =>
            await _tagInputCollection.DeleteOneAsync(x => x.Id == id);

    }
}
