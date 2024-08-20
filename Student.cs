using System.Diagnostics.Metrics;

public class Student {
    public int Id{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}

    public Student(){
        
    }

    // public Student(int id,string name,string email){
    //     this.Id=id;
    //     this.Name=name;
    //     this.Email=Email;
    // }
    public override string ToString()

    {
        return $"Id:{Id} Name:{Name} Email:{Email}";
    }

}