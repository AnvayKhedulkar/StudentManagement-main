using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace StudentManagement.Models
{
    [BsonIgnoreExtraElements]//ignores extra elements inside mongo db
    public class Student
    {
        [BsonId] //student class is mapped with object id field in mongodb
        [BsonRepresentation(BsonType.ObjectId)]// this attribute converts mongo data type to .net data type and vice versa
        public string Id { get; set; } = String.Empty;
        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }
        [BsonElement("courses")]
        public string[]? Courses { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;
        [BsonElement("age")]
        public int Age { get; set; }
    }
}

