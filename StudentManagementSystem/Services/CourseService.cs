namespace StudentManagerSystem.Services;
using StudentManagerSystem.Models;


public class CourseService
{
    public List<Course> Courses {get; set;}
    
    public CourseService()
    {
        Courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);

    }
     
     public Course GetCourse(string name)
    {
        return Courses.FirstOrDefault(c => c.Name == name);
    }

}