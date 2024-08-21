# Online Course Management System

## Project Overview

The **Online Course Management System** is a simple C# console application designed to manage course enrollments and withdrawals for students. The project demonstrates the use of Inversion of Control (IoC) and Dependency Injection (DI) to decouple classes and enhance code maintainability. Also exception handling is done por possible exceptions scenarios. The application provides a menu-based interface for users to interact with the system.

## Roles/Team Members:

- **Vishant**: Core Developer responsible for logic building, IoC, Dependency Injection and Exception Handling.
- **Sunil**: Handled documentation and helped in creating classes and exception handling.
- **Vidhya Shree**: Focused on documentation and building of classes and methods.
- **Vinay**: Helped in exception handling and creating methods and classes.

## Features

- **IoC and DI Implementation**: The project utilizes Microsoft.Extensions.DependencyInjection to manage dependencies, promoting loose coupling between classes.
- **Course Management**: Ability to create, list, and manage courses.
- **Student Enrollment**: Students can enroll in courses. The system checks for duplicate student IDs and handles exceptions accordingly.
- **Withdrawal Functionality**: Students can withdraw from courses they are enrolled in.
- **Display Enrollments**: The system can display a list of current enrollments.

## Project Structure

### Classes and Interfaces

- **Program**: The entry point of the application, which sets up the IoC container and manages user interaction through a menu system.
- **ICourseService**: Interface defining the operations for managing courses.
- **IEnrollmentService**: Interface defining the operations for managing student enrollments.
- **CourseService**: Implementation of `ICourseService`, responsible for managing the list of available courses.
- **EnrollmentService**: Implementation of `IEnrollmentService`, responsible for managing student enrollments and withdrawals.
- **Course**: A class representing a course with properties like `CourseId`, `CourseName`, and `CourseFee`.
- **Student**: A class representing a student with properties like `Id`, `Name`, and `Email`.
- **Enrollment**: A class that links a student to a course, representing an enrollment.
- **DuplicateStudentIdException**: A custom exception class used to handle cases where a duplicate student ID is detected during enrollment.

### Basic Logic and Features

#### 1. **IoC Container Setup**
   The IoC container is set up using the `Microsoft.Extensions.DependencyInjection` library. Services for `ICourseService` and `IEnrollmentService` are registered in the container.

   ```csharp
   var serviceProvider = new ServiceCollection()
       .AddSingleton<ICourseService, CourseService>()
       .AddSingleton<IEnrollmentService, EnrollmentService>()
       .BuildServiceProvider();
  ```

#### 2. Course Management
Courses are created and added to the system by instantiating Course objects and using the AddCourse method of ICourseService.

```csharp
var course1 = new Course { CourseId = 1, CourseName = "C#", CourseFee = 12000 };
var course2 = new Course { CourseId = 2, CourseName = ".NET", CourseFee = 15000 };
courseService.AddCourse(course1);
courseService.AddCourse(course2);
```

#### 3. Enrollment and Withdrawal
Students can enroll in courses through a menu system. The system checks if the student ID already exists in the enrollment list, throwing a DuplicateStudentIdException if necessary.

```csharp
try
{
    var existingEnrollment = enrollmentService.GetEnrollments().FirstOrDefault(e => e.student.Id == studentId);
    if (existingEnrollment != null)
    {
        throw new DuplicateStudentIdException($"Student with ID {studentId} already exists.");
    }
    // Enrollment logic...
}
catch (DuplicateStudentIdException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

Students can also withdraw from courses by entering their name.

```csharp
Console.Write("Enter Student Name to Withdraw: ");
string studentName = Console.ReadLine();
enrollmentService.WithdrawStudent(studentName);
```

#### 4. Displaying Enrollments
The system provides a feature to display all current enrollments, listing each student and their respective course.

```csharp
var enrollments = enrollmentService.GetEnrollments();
if (enrollments.Any())
{
    foreach (var enrollment in enrollments)
    {
        Console.WriteLine($"{enrollment} Student: {enrollment.student}");
    }
}
```

### How to Run
- Clone the repository.
- Open the solution in Visual Studio.
- Build the project to restore the necessary packages.
- Run the application. You will be presented with a menu to interact with the system.

