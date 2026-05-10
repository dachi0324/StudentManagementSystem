namespace StudentManagerSystem.Models;

public class Course
{
    public List<Student> Students {get; set;}
    public string Name {get; set;}
    public Teacher Teacher {get; set;}

    public Course (string name, Teacher teacher)
    {
        this.Name = name;
        this.Teacher = teacher;

        Students = new List<Student>();
    }
}