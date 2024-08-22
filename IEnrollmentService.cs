/// <summary>
/// Defines methods for enrolling and withdrawing students, and retrieving enrollments.
/// </summary>
public interface IEnrollmentService
{
    /// <summary>
    /// Enrolls a student in a course.
    /// </summary>
    /// <param name="student">The student to enroll.</param>
    /// <param name="course">The course to enroll the student in.</param>
    void EnrollStudent(Student student, Course course);

    /// <summary>
    /// Withdraws a student from enrollment using their name.
    /// </summary>
    /// <param name="studentName">The name of the student to withdraw.</param>
    void WithdrawStudent(string studentName);

    /// <summary>
    /// Retrieves all enrollments.
    /// </summary>
    /// <returns>A collection of enrollments.</returns>
    IEnumerable<Enrollment> GetEnrollments();
}
