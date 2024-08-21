public interface IEnrollmentService
{
    void EnrollStudent(Student student, Course course);
    void WithdrawStudent(string studentName);
    IEnumerable<Enrollment> GetEnrollments();
}
