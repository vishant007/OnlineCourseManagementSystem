public class InvalidStudentException : Exception
{
    public InvalidStudentException() : base("A student with this ID already exists.")
    {
    }

    public InvalidStudentException(string message) : base(message)
    {
    }

    public InvalidStudentException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
  public  static bool ValidName(string studentEmail)
{
    int count = 0;

    for (int j = 0; j < studentEmail.Length; j++)
    {
        if (studentEmail[j] == '@')
        {
            count++;
        }
    }

    if (count == 0 || count > 1)
    {
        throw new InvalidStudentException("Enter The Valid Email");
    }

    return true;
}
 public  static bool ValidNameCheck(string studentName)
{
   
        if (studentName.Length<3)
        
             {
        throw new InvalidStudentException("Enter The Valid Name,  It Should have minimum 3 characters");
    

        }
        return true;
    }

   

        
}
