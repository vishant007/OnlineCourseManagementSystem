public class Enrollment : Course
{
    public Enrollment(int coursefee,int EnrollmentId,DateTime EnrollmentTime):base(coursefee)
    {
        this.EnrollmentId=EnrollmentId;
        this.CourseFee=coursefee;
        this.EnrollmentTime=EnrollmentTime;
        
    }

    public int EnrollmentId{get;set;}
    
    public Student student{get;set;}
    public DateTime EnrollmentTime{get;set;}

    public void OnlineCourse(){
        base.CourseMode();
        System.Console.WriteLine("Online Course");
    }
    public void OfflineCourse(){
        base.CourseMode();
        System.Console.WriteLine("Offline Course");
    }
    public override string ToString()

    {
        
        return $"Enrollment Id{EnrollmentId} Course Fee:{CourseFee} Enrollment Time:{EnrollmentTime}";
    }
    public Enrollment(){
        
    }
}