using System;

public class InvalidStudentNameException : Exception
{
    public InvalidStudentNameException(string message) : base(message)
    {
    }
}