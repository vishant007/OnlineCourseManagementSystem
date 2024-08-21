
/// <summary>
/// Representing an enrollment in a course,inheriting from the Course class.
/// </summary>
public class Enrollment : Course
{
    /// <summary>
    /// A static list to hold all enrollments
    /// </summary>
    public static List<Enrollment> Enrollments = new List<Enrollment>(); // Static list to hold enrollments
    /// <summary>
    /// Initializes a new instance of the <see cref="Enrollment"/> class with specified course fee, enrollment ID, and enrollment time.
    /// </summary>
    /// <param name="coursefee">The fee of the course.</param>
    /// <param name="EnrollmentId">The ID of the enrollment.</param>
    /// <param name="EnrollmentTime">The time of the enrollment.</param>
    public Enrollment(int coursefee, int EnrollmentId, DateTime EnrollmentTime) : base(coursefee)
    {
        this.EnrollmentId = EnrollmentId;
        this.CourseFee = coursefee;
        this.EnrollmentTime = EnrollmentTime;
    }
    /// <summary>
    /// get or set for EnrollmentId
    /// </summary>
    public int EnrollmentId { get; set; }
    /// <summary>
    /// Gets or sets the student associated with the enrollment.
    /// </summary>
    public Student student { get; set; }
    /// <summary>
    /// Gets or sets the time of the enrollment.
    /// </summary>
    public DateTime EnrollmentTime { get; set; }
    /// <summary>
    /// Displays the mode of the course as online.
    /// </summary>
    public void OnlineCourse()
    {
        base.CourseMode();
        System.Console.WriteLine("Online Course");
    }
    /// <summary>
    /// Displays the mode of the course as offline.
    /// </summary>
    public void OfflineCourse()
    {
        base.CourseMode();
        System.Console.WriteLine("Offline Course");
    }
    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Enrollment Id: {EnrollmentId} Course Fee: {CourseFee} Enrollment Time: {EnrollmentTime}";
    }
}
