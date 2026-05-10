namespace StudentManagerSystem.Services;

using StudentManagerSystem.Interface;
using StudentManagerSystem.Models;


public class GradingService : IGradingService
{
    public List<Grade> Grades {get; set;}

    public GradingService()
    {
        Grades = new List<Grade>();
    }

    public void AddGrade(Student student, Course course, double value)
    {
        Grade grade = new Grade(value, student, course);
        Grades.Add(grade);
        student.Grades.Add(grade);
    }

    public double GetAverage(Student student)
    {
        return student.Grades.Average(g => g.Grades);
    }
}