public class CourseNotFoundException:Exception
{
    public CourseNotFoundException(){}
    public CourseNotFoundException(string message):base(message)
    {}   
    public static bool SelectCourse(int n)
    {
        if(n>2)
            throw new CourseNotFoundException("Course Not Found");
        return true;
    }
}
