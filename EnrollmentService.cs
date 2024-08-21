using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Provides services for managing student enrollments in courses
/// </summary>
public class EnrollmentService : IEnrollmentService
{
    private readonly List<Enrollment> _enrollments = new List<Enrollment>();
    /// <summary>
    /// Enrolls a student in a specified course.
    /// </summary>
    /// <param name="student">The student to enroll.</param>
    /// <param name="course">The course in which to enroll the student.</param>
    public void EnrollStudent(Student student, Course course)
    {
        var newEnrollment = new Enrollment(course.CourseFee, _enrollments.Count + 1, DateTime.Now)
        {
            student = student
        };
        _enrollments.Add(newEnrollment);
        Console.WriteLine($"{student.Name} has been enrolled in {course.CourseName}.");
    }
    /// <summary>
    /// Withdraws a student from their enrolled course.
    /// </summary>
    /// <param name="studentName">The name of the student to withdraw.</param>
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
    /// <summary>
    /// Retrieves all enrollments.
    /// </summary>
    /// <returns>An enumerable collection of all enrollments.</returns>
    public IEnumerable<Enrollment> GetEnrollments()
    {
        return _enrollments;
    }
}
