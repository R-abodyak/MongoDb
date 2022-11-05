using MongoDB.Driver;
using MongoDB.Bson;

namespace LearnMongoDb;

public class MongoCRUD
{
    private readonly IMongoDatabase db;
    public MongoCRUD(string DBname)
    {
        var client = new MongoClient();
        db = client.GetDatabase(DBname);
    }

    public void InsertRecord<T>(string collectionName, T record)
    {
        var collection = db.GetCollection<T>(collectionName);
        collection.InsertOne(record);
    }
    public List<T> FindRecordsbyName<T> (string table, string name)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("UserName", name);
        
        return collection.Find(filter).ToList();
    }

    public void upsert <T> (string table, string name, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.ReplaceOne(new BsonDocument("UserName", name), record, new UpdateOptions{IsUpsert= true} );
    }
    
}

