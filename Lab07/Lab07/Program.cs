using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is Lab 7 for Ryan Dunphy in IT1050, Object-Oriented Programming.

// 1. Before adding the constructor method, I am just creating a new instance of class Book
// in memory, that I can enter information into. 
// 2. If we created two new constructor methods, we would be practicing overloading constructors. 
// 3. Error handling is important because it is very difficult to anticipate all of the things a user can
// do to our programs and it's very likely an error will occur. It first lets the user know something has gone wrong,
// and second, we can put in notices that will aid us in fixing the issues at a later date. 
// 4. The purpose of private vs public is so that we can determine what information will be accessible outside
// of the scope of our work. This applies to information hiding because it can simplify the code for other users
// who don't need to see the behind the scenes work that goes on in the code, making it easier for them to work. 
// 5. Composition is essentially creating an instance of a class in terms of a "is-a-part-of" relationship.
// It is useful if you are going to have many sub-classes of a type Book. 
// 6. Data abstraction is the idea of limiting information to the outside world to only the essentials
// of a program's details, in order to simplify the programs being worked on. 

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {                                  
            Book BookTest = new Book()
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "JK Rowling",
                Year = 1997
            };
            
            BookTest.Display(); 
        }
    }
     class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; } 

        public void Display()
        {
            Console.WriteLine("This book is called {0}, and it was written by {1}. ", Title, Author);
            Console.ReadLine();
        } 
    } 
}
