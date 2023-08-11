using StudentManagement.Models;
using MongoDB.Driver;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)//settings carries the db config info including the db name
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);//this is gonna return the db to us
            _students = database.GetCollection<Student>(settings.StudentCoursesCollectionName);
        }

        public Student Create(Student student) //inserting one student and returns inserted student obj
        {
            _students.InsertOne(student);
            return student;
        }

        public List<Student> Get()//returns the list of all students
        {
            return _students.Find(student => true).ToList();
        }

        public Student Get(string id)//find student where his id == incoming id
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Remove(string id) //delete a student whos id matches the incoming id
        {
            _students.DeleteOne(student => student.Id == id);
        }

        public void Update(string id, Student student)
        {
            _students.ReplaceOne(student => student.Id == id, student);
        }
    }
}
