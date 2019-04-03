using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Addition
    {
        public static void Main(string[] args)
        {
            int num1; // declare first number to add
            int num2; // declare second number to add
            int sum; // declare the sum of 1 and 2

            Console.Write("Enter first integer:");  // prompt user
            //read first number from user
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:"); // prompt user
            // read second number from user
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2; // add numbers

            Console.WriteLine("Sum is {0}", sum); // display sum
            Console.ReadLine();

            //Break between Operations

            Console.WriteLine("{0}\n{1}", "Hello world!", "From Ryan Dunphy");
            Console.ReadLine();

            //Break between Operations

            Console.WriteLine("Hello World!     From Ryan Dunphy");
            Console.ReadLine();

            //Answering Questions - 
            /*
             a. The program executes in the Main method.
             b. An integer type variable has to be a whole number,
             and a double/floating-point can have decimal places.
             c. public string CourseName was an example of a method.
             d. To read the value of an instance variable, we create
             a method called a "get" accessor.
             To assign a value to an instance variable, we use a 
             method called a "set" accessor.
             e. A class is the the actual "housing" of the code, 
             the object is what causes the "housing" to execute
             the methods inside and describe how they function.
             You can create as many instances of a class as you want
             , you just cannot put the "static" variable on your 
             class. If you simply have a class like 
             public class CourseName
                public CourseName()
             You can use an unlimited number of instances as long
             as you keep defining those instances. 
     
            */

            
        }  // End Main Method
    } // End class Addition
}
