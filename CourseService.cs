using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Provides services for managing courses.
/// </summary>
public class CourseService : ICourseService
{
    private readonly List<Course> _courses = new List<Course>();
    /// <summary>
    /// Retrieves a course by its ID
    /// </summary>
    /// <param name="courseId">The ID of the course to retrieve</param>
    /// <returns>The course with the specified ID, or null if not found</returns>
    public Course GetCourseById(int courseId)
    {
        return _courses.FirstOrDefault(c => c.CourseId == courseId);
    }
    /// <summary>
    /// Adds a new course to the list
    /// </summary>
    /// <param name="course">The course to add.</param>
    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }
    /// <summary>
    /// Retrieves all courses.
    /// </summary>
    /// <returns>An enumerable collection of all courses</returns>
    public IEnumerable<Course> GetAllCourses()
    {
        return _courses;
    }
}
