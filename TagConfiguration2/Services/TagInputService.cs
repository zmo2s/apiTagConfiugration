

namespace TagConfiguration2.Services
{
    using Microsoft.Extensions.Options;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using TagConfiguration2.Models;
    public class TagInputService
    {

         private readonly IMongoCollection<Config> _tagInputCollection;

        Task<List<BsonDocument>> docs;
        //   var doc1;




        public TagInputService(
            IOptions<TagsConfigurationDatabaseSettings> tafgConfigurationDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                tafgConfigurationDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                tafgConfigurationDatabaseSettings.Value.DatabaseName);

            _tagInputCollection = (IMongoCollection<Config>?)mongoDatabase.GetCollection<Config>(
                tafgConfigurationDatabaseSettings.Value.TagInputCollectionName);



            var collection = mongoDatabase.GetCollection<ConfigBase>("ConfigBase");
            var collection1 = mongoDatabase.GetCollection<TagInput>("TagInput");

        /*    Transaction transaction = new Transaction();

            var result = collection.Aggregate()
              .Lookup<ConfigBase, TagInput, Transaction>(collection, a => a._idTagInput, a => a._idConfigBase);

            */

        }
        public async Task<List<Config>> GetAsync() =>
          await _tagInputCollection.Find(_ => true).ToListAsync();
     /*   public async Task<TagInput?> GetAsync(ObjectId id) =>
            await _tagInputCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(TagInput newTaginput) =>
            await _tagInputCollection.InsertOneAsync(newTaginput);

        public async Task UpdateAsync(ObjectId id, TagInput updatedTagInput) =>
            await _tagInputCollection.ReplaceOneAsync(x => x.Id == id, updatedTagInput);

        public async Task RemoveAsync(ObjectId id) =>
            await _tagInputCollection.DeleteOneAsync(x => x.Id == id);
     */
    }
}
