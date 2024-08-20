public class Course{
    public int CourseId{get;set;}

    public string CourseName{get;set;}

    public int CourseFee{get;set;}

    public Course(){
        
    }
    // public Course(int course,string coursename,int coursefee){
    //     this.CourseFee = course;
    //     this.CourseName=CourseName;
    //     this.CourseFee=CourseFee;
    // }

    public Course(int coursefee)
    {
        CourseFee = coursefee;
    }

    public void CourseMode(){
        System.Console.WriteLine("Course Mode");
    }
    public override string ToString()
    {
        return $"CourseId:{CourseId} CourseName:{CourseName} CourseFee:{CourseFee}";
    }
}