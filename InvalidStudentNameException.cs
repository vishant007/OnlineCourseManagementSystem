using System;

/// <summary>
/// Represents errors that occur when an invalid student name is provided.
/// </summary>
public class InvalidStudentNameException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidStudentNameException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public InvalidStudentNameException(string message) : base(message)
    {
    }
}
