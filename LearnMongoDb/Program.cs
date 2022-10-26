using LearnMongoDb;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        MongoCRUD db = new MongoCRUD("AddressBook");
        db.InsertRecord("Users","rawan");
        db.InsertRecord("Users",new UserModel(){UserName = "Rawan Abodyak",address = new AddressModel(){Address = "Jenin"}});
    }
}