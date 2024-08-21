using System;
using System.Collections.Generic;
using System.Linq;

public class EnrollmentService : IEnrollmentService
{
    private readonly List<Enrollment> _enrollments = new List<Enrollment>();

    public void EnrollStudent(Student student, Course course)
    {
        var newEnrollment = new Enrollment(course.CourseFee, _enrollments.Count + 1, DateTime.Now)
        {
            student = student
        };
        _enrollments.Add(newEnrollment);
        Console.WriteLine($"{student.Name} has been enrolled in {course.CourseName}.");
    }

    public void WithdrawStudent(string studentName)
    {
        var enrollment = _enrollments.FirstOrDefault(e => e.student.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

        if (enrollment != null)
        {
            _enrollments.Remove(enrollment);
            Console.WriteLine($"{studentName} has been withdrawn from the course.");
        }
        else
        {
            Console.WriteLine($"{studentName} is not found in the enrolled list.");
        }
    }

    public IEnumerable<Enrollment> GetEnrollments()
    {
        return _enrollments;
    }
}
