using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ryan Dunphy's Midterm Take Home Test

// A. 3 Types of control structures that we use in programming are:
   // 1. The if/else condition statement. 
   // 2. The while repetition statement. 
   // 3. The for repetition statement.
   // 4. Extra* The switch statement. 

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int squared = 2;
            while (squared <= 128)
            {
                Console.WriteLine("{0}", squared);
                squared = squared * 2;
            }
            Console.ReadLine();

            // for loop printing 49 through 1 separated by a comma.
            for (int startingNum = 49; startingNum > 1;)
            {
                Console.Write("{0}, ", startingNum);
                startingNum--;

                if (startingNum == 1)
                    Console.Write("{0}", startingNum);
            }            
            Console.ReadLine();
            Console.WriteLine();

            // While loop that prints all odd numbers 1 through 21 separated by spaces.
            int secondNum = 1;
            while (secondNum <= 21)
            {
                Console.Write("{0} ", secondNum);
                secondNum += 2;
            }
            Console.ReadLine();
            Console.WriteLine();

            // The output for this will be *, and nothing else because i will never be less than n
            int n = 8;
            int i = 10; // initialize
            do {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition
            Console.ReadLine();
            Console.WriteLine();

            // The output for this will be nothing at all, because the loop doesn't run even once. 
            int b = 8;
            int x = 10; // initialize
            while (x < b) // test condition
            {
                Console.Write("*");
                x++; // update!
            }
            Console.ReadLine();

            // Combining multiple boolean variables
            // We combine boolean values by using and/or operators, such as below. 
            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain || tornadoWarning)
            {
                Console.WriteLine("Let's stay inside!");
            }
            else
                Console.WriteLine("Let's go outside!");

            Console.ReadLine();

            // Set variables for reverse number pyramid
            int loops;
            int count;
            int space;

            // Begin loops to create 5 rows 
            for (loops = 5; loops >= 1; loops--)               
            {
                // Inner loop to create spacing
                for (space = 4; space >= loops; space--)
                {
                    Console.Write(" ");
                }
                // Loop to print left side of pyramid
                for (count = 1; count < loops; count++)
                {
                    Console.Write("{0}", count);
                }
                // Loop to print right side of pyramid
                for (count = loops; count > 0; count--)
                {
                    Console.Write("{0}", count);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Infinite while loops
            bool keepLooping = true; // set variable for infinite loops

            while (keepLooping) // start infinite loop
                Console.WriteLine("Press CTRL+C to Exit");
        }
    }
}
