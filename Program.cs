using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Student instances
        Student student1 = new Student
        {
            Id = 1,
            Name = "Vidhya",
            Email = "Vidhya@gmail.com"
        };
        Student student2 = new Student
        {
            Id = 2,
            Name = "Vinay",
            Email = "Vinay@gmail.com"
        };

        // Creating Course instances
        Course course1 = new Course
        {
            CourseId = 1,
            CourseName = "C#",
            CourseFee = 12000
        };
        Course course2 = new Course
        {
            CourseId = 2,
            CourseName = ".NET",
            CourseFee = 15000
        };

        // Creating Enrollment instances and associating them with students and courses
        Enrollment enroll1 = new Enrollment(course1.CourseFee, 1, DateTime.Today.AddDays(-30))
        {
            student = student1
        };

        Enrollment enroll2 = new Enrollment(course2.CourseFee, 2, DateTime.Now)
        {
            student = student2
        };

        // Printing Student details
        Console.WriteLine(student1);
        Console.WriteLine(student2);

        // Printing Course details
        Console.WriteLine(course1);
        Console.WriteLine(course2);

        // Printing Enrollment details along with associated student
        Console.WriteLine($"{enroll1} Student: {enroll1.student}");
        Console.WriteLine($"{enroll2} Student: {enroll2.student}");

        // Demonstrating the course modes
        enroll1.OnlineCourse();
        enroll2.OfflineCourse();
    }
}
