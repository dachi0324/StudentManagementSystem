namespace StudentManagerSystem.Models;

public  class Student : Person
{
    public List<Course> Courses { get; set; }
    public List<Grade> Grades { get; set; }
   
   public Student (int id, string name) : base(id, name)
    {
        Courses = new List<Course>();
        Grades = new List<Grade>();
    }
}