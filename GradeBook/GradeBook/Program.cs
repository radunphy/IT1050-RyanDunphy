// Fig. 4.1: GradeBook.cs
// Class declaration with one method.
using System;

public class GradeBook
{
    // auto-implemented property CourseName implicitly created
    // an instance variable for this GradeBook's course name

    public string CourseName { get; set; }
    
    // constructor initializes auto-implemented property
    // CourseName with string supplied as argument
    public GradeBook( string name)
    {
        CourseName = name; // set CourseName to name
    } // end constructor

    // display a welcome message to GradeBook user
    public void DisplayMessage()
    {
        // use auto-implemented property CourseName to get the
        // name of the course that this GradeBook represents
        Console.WriteLine("Welcome to the grade book for\n{0}!",
            CourseName ); // display property CourseName
        Console.ReadLine();
    }   // end method DisplayMessage
}   // end class GradeBook
