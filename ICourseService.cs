/// <summary>
/// Defines methods for managing courses.
/// </summary>
public interface ICourseService
{
    /// <summary>
    /// Retrieves a course by its unique identifier.
    /// </summary>
    /// <param name="courseId">The unique identifier of the course.</param>
    /// <returns>The course with the specified identifier.</returns>
    Course GetCourseById(int courseId);

    /// <summary>
    /// Adds a new course.
    /// </summary>
    /// <param name="course">The course to add.</param>
    void AddCourse(Course course);

    /// <summary>
    /// Retrieves all courses.
    /// </summary>
    /// <returns>A collection of all courses.</returns>
    IEnumerable<Course> GetAllCourses();
}
