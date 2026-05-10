namespace StudentManagerSystem.Models;

public class Grade
{
    public  Student Student {get; set;}
    public  Course Course {get; set;}
    public double  Grades {get; set;}

    public Grade (double grade, Student student, Course course)
    {
        this.Grades = grade;
        this.Course = course;
        this.Student = student;

    }
}