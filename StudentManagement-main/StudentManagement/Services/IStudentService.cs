using StudentManagement.Models;

namespace StudentManagement.Services
{
    //this service will perform all CRUD operations
    public interface IStudentService

    {
        List<Student> Get();//get returns list of all students
        Student Get(string id);//returns single student by id
        Student Create(Student student);//creates a new student and returns it
        void Update(string id, Student student);//updates student by id
        void Remove(string id);//deletes student by id

    }
}
