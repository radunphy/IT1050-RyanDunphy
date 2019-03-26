// Fig. 4.2: GradeBookTest.cs
// Create a GradeBook object and call its DisplayMessage method.
// its DisplayMessage method.
using System;

public class GradeBookTest
{
    // Main method begins program execution
    public static void Main( string[] args )
    {
        // create a GradeBook object
        GradeBook gradeBook1 = new GradeBook( // invokes constructor
            "IT1050 Programming Logic");
        GradeBook gradeBook2 = new GradeBook( // invokes constructor
            "IT1025 Intro to Web Programming");

        // display initial value of courseName for each GradeBook
        Console.WriteLine("gradeBook1 course name is: {0}",
            gradeBook1.CourseName);
        Console.WriteLine("gradeBook2 course name is: {0}",
            gradeBook2.CourseName);
        Console.ReadLine();
    } // end Main
} // end class GradeBookTest