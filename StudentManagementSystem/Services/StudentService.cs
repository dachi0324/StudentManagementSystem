using StudentManagerSystem.Models;

namespace StudentManagerSystem.Services;

public class StudentServices
{
    public List<Student> Students {get; set;}

    public StudentServices()
    {
        Students = new List<Student>();
    }
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public Student GetStudent (int id)
    {
        return Students.FirstOrDefault(s => s.Id == id);
    }
}