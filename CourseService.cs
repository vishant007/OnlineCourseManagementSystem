using System.Collections.Generic;
using System.Linq;

public class CourseService : ICourseService
{
    private readonly List<Course> _courses = new List<Course>();

    public Course GetCourseById(int courseId)
    {
        return _courses.FirstOrDefault(c => c.CourseId == courseId);
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public IEnumerable<Course> GetAllCourses()
    {
        return _courses;
    }
}
