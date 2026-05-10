using StudentManagerSystem.Models;

namespace StudentManagerSystem.Interface;

public interface IGradingService
{
    void AddGrade(Student student, Course course, double value);
    double GetAverage(Student student);
}