public class DuplicateStudentIdException : Exception
{
    public DuplicateStudentIdException() : base("A student with this ID already exists.")
    {
    }

    public DuplicateStudentIdException(string message) : base(message)
    {
    }

    public DuplicateStudentIdException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
