namespace MongoWebAPI.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class Employee
    {
        [BsonId]
        public ObjectId Id{ get; set; }

        [BsonElement("FullName")]
        public string FullName { get; set; }
    }
}