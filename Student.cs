using System.Diagnostics.Metrics;
/// <summary>
/// Represents a student with an ID, name, and email address.
/// </summary>
public class Student
    {
    /// <summary>
    /// Gets or sets the unique identifier for the student.
     /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the student.
    /// </summary>
     public string Name { get; set; }

    /// <summary>
    /// Gets or sets the email address of the student.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    public Student()
    {
        // Default constructor
    }
    /// <summary>
    /// Returns a string that represents the current <see cref="Student"/> object.
    /// </summary>
    /// <returns>A string that represents the current <see cref="Student"/> object.</returns>
    public override string ToString()
    {
         return $"Id: {Id} Name: {Name} Email: {Email}";
    }
}
