using MongoDB.Bson.Serialization.Attributes;

namespace LearnMongoDb;


[BsonIgnoreExtraElements]
public class UserModel
{
    public string UserName { get; set; }
    public int Age { get; set; }
    public AddressModel address { get; set; }
}

public class AddressModel
{
    public string Address { get; set; }
    public string ZipCode { get; set; }
}