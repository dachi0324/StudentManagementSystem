using StudentManagerSystem.Models;
using StudentManagerSystem.Services;
using StudentManagerSystem.Interface;


StudentServices studentService = new StudentServices();
CourseService  courseService = new CourseService();
GradingService gradingService = new GradingService();

Student student1 = new Student(1, "student 1");
Student student2 = new Student(2, "Student 2");
Student student3 = new Student(3, "student 3");

Teacher teacher1 = new Teacher(1, "teacher1");
Teacher teacher2 = new Teacher(2, "teacher2");

Course course1 = new Course("course 1", teacher1);
Course course2 = new Course("course 2", teacher2);


studentService.AddStudent(student1);
studentService.AddStudent(student2);
studentService.AddStudent(student3);

courseService.AddCourse(course1);
courseService.AddCourse(course2);
course1.Students.Add(student1);
student1.Courses.Add(course1);
course1.Students.Add(student2);
student2.Courses.Add(course1);
course2.Students.Add(student3);
student3.Courses.Add(course2);

gradingService.AddGrade(student1, course1, 100.0);
gradingService.AddGrade(student2, course1, 80.0);
gradingService.AddGrade(student3, course2, 99.9);


Console.WriteLine($"Student: {student1.Name}, Id: {student1.Id}");
Console.WriteLine($"Student: {student2.Name}, Id: {student2.Id}");
Console.WriteLine($"Student: {student3.Name}, Id: {student3.Id}");

Console.WriteLine($"Course: {course1.Name}, Teacher: {course1.Teacher.Name}");
Console.WriteLine($"Course:{course2.Name}, Teacher: {course2.Teacher.Name}");


Console.WriteLine($"{student1.Name} - Grade: {student1.Grades[0].Grades}");
Console.WriteLine($"{student2.Name} - Grade: {student2.Grades[0].Grades}");
Console.WriteLine($"{student3.Name} - Grade: {student3.Grades[0].Grades}");


Console.WriteLine($"{student1.Name} Average: {gradingService.GetAverage(student1)}");
Console.WriteLine($"{student2.Name} Average: {gradingService.GetAverage(student2)}");
Console.WriteLine($"{student3.Name} Average: {gradingService.GetAverage(student3)}");

