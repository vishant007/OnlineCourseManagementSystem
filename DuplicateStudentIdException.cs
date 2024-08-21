/// <summary>
/// Represents an exception that is thrown when a duplicate student ID is encountered.
/// </summary>
public class DuplicateStudentIdException : Exception
{
    /// <summary>
    /// Initializes a new instance of the DuplicateStudentIdException class with a default error message.
    /// </summary>
    public DuplicateStudentIdException() : base("A student with this ID already exists.")
    {
    }
    /// <summary>
    /// Initializes a new instance of the DuplicateStudentIdException class with a specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public DuplicateStudentIdException(string message) : base(message)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DuplicateStudentIdException class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public DuplicateStudentIdException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
