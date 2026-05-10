namespace StudentManagerSystem.Models;

public class Teacher : Person
{
    public List<Course> Courses {get; set;}
    public Teacher (int id, string name) : base(id, name)
    {
         Courses = new List<Course>();
    }
}