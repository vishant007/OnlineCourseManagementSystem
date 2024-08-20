using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Predefined students and courses
        Student student1 = new Student { Id = 1, Name = "Vidhya", Email = "Vidhya@gmail.com" };
        Student student2 = new Student { Id = 2, Name = "Vinay", Email = "Vinay@gmail.com" };

        Course course1 = new Course { CourseId = 1, CourseName = "C#", CourseFee = 12000 };
        Course course2 = new Course { CourseId = 2, CourseName = ".NET", CourseFee = 15000 };

        // Initial enrollments
        Enrollment enroll1 = new Enrollment(course1.CourseFee, 1, DateTime.Today.AddDays(-30)) { student = student1 };
        Enrollment enroll2 = new Enrollment(course2.CourseFee, 2, DateTime.Now) { student = student2 };

        Enrollment.Enrollments.Add(enroll1);
        Enrollment.Enrollments.Add(enroll2);

        // Display menu to user
        while (true)
        {
            Console.WriteLine("1. Enroll in a course");
            Console.WriteLine("2. Withdraw from a course");
            Console.WriteLine("3. Display enrollments");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EnrollStudent(course1, course2);
                    break;
                case 2:
                    WithdrawStudent();
                    break;
                case 3:
                    DisplayEnrollments();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void EnrollStudent(Course course1, Course course2)
    {
        Console.Write("Enter Student Id: ");
        int studentId = int.Parse(Console.ReadLine());
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();
        Console.Write("Enter Student Email: ");
        string studentEmail = Console.ReadLine();

        Console.WriteLine("Select Course:");
        Console.WriteLine($"1. {course1.CourseName}");
        Console.WriteLine($"2. {course2.CourseName}");
        int courseChoice = int.Parse(Console.ReadLine());

        Course selectedCourse = courseChoice == 1 ? course1 : course2;
        Student newStudent = new Student { Id = studentId, Name = studentName, Email = studentEmail };

        Enrollment newEnrollment = new Enrollment(selectedCourse.CourseFee, Enrollment.Enrollments.Count + 1, DateTime.Now)
        {
            student = newStudent
        };

        Enrollment.Enrollments.Add(newEnrollment);
        Console.WriteLine($"{newStudent.Name} has been enrolled in {selectedCourse.CourseName}.");
    }

    static void WithdrawStudent()
    {
        Console.Write("Enter Student Name to Withdraw: ");
        string studentName = Console.ReadLine();

        var enrollment = Enrollment.Enrollments.FirstOrDefault(e => e.student.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

        if (enrollment != null)
        {
            Enrollment.Enrollments.Remove(enrollment);
            Console.WriteLine($"{studentName} has been withdrawn from the course.");
        }
        else
        {
            Console.WriteLine($"{studentName} is not found in the enrolled list.");
        }
    }

    static void DisplayEnrollments()
    {
        foreach (var enrollment in Enrollment.Enrollments)
        {
            Console.WriteLine($"{enrollment} Student: {enrollment.student}");
        }
    }
}
