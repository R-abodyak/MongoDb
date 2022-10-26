using MongoDB.Driver;

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
}

