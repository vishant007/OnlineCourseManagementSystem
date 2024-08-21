public interface ICourseService
{
    Course GetCourseById(int courseId);
    void AddCourse(Course course);
    IEnumerable<Course> GetAllCourses();
}
