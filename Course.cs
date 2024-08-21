/// <summary>
/// Represents a course with an ID, name, and fee.
/// </summary>
public class Course{
    /// <summary>
    /// get or set for CourseId
    /// </summary>
    public int CourseId{get;set;}
    /// <summary>
    /// get or set for CourseName
    /// </summary>
    public string CourseName{get;set;}
    /// <summary>
    /// get or set for CourseName
    /// </summary>
    public int CourseFee{get;set;}

    public Course(){
        
    }
    // public Course(int course,string coursename,int coursefee){
    //     this.CourseFee = course;
    //     this.CourseName=CourseName;
    //     this.CourseFee=CourseFee;
    // }

    /// <summary>
    /// Intilizes a new instance of the class with specified course fee
    /// </summary>
    /// <param name="coursefee"></param>
    public Course(int coursefee)
    {
        CourseFee = coursefee;
    }

    /// <summary>
    /// Displays the mode of the course
    /// </summary>
    public void CourseMode(){
        System.Console.WriteLine("Course Mode");
    }
    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string thar respresnts the current object.</returns>
    public override string ToString()
    {
        return $"CourseId:{CourseId} CourseName:{CourseName} CourseFee:{CourseFee}";
    }
}