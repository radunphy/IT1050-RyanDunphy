using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ryan Dunphy's Lab04 Submission

// A. The four basic elements of counter-controlled repetions are:
    // 1. They keyword that starts it.
    // 2. The control variable and it's type
    // 3. The Loop-Continuation condition.
    // 4. The incrementer of the control variable. 

// B. The while and for repetition statements have similarities and differences. 
    // 1. The while loop executes its body while the condition it has reads true.
    // 2. The for loop executes its body similarly, while it's conditions read true.
    /* 3. The big difference is that the for loop has all of it's conditions in the body,
       this makes it obvious how many times it is supposed to loop for, but the while loop is 
       more useful for when you're unsure how many times it will loop. Another way to put it
       is that the while loop is useful if you're using a previously declared variable in
       your program, because with the for loop you HAVE to declare the variable in the body.*/

/* C. The do while loop is useful to use when you want to have an exit condition loop going. 
    This means that it will be more useful if you want your loop to run at least once. 
    If you don't know what the value of your variable is going to be, but you want to run
    the loop at least once, you would want to use a do while loop instead of a while loop. */

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("{0} ", i);

                if ((i % 2) == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                    Console.WriteLine("It's odd");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter a temperature: ");

            string input = Console.ReadLine();
            int temp;
            temp = Convert.ToInt32(input);

            if (temp < 90 && temp >= 80)
                Console.WriteLine("Fish");
            else if (temp < 80 && temp >= 70)
                Console.WriteLine("Lion");
            else if (temp < 70 && temp >= 60)
                Console.WriteLine("Turtle");
            else if (temp < 60 && temp >= 50)
                Console.WriteLine("Deer");
            else if (temp < 50 && temp >= 40)
                Console.WriteLine("Reindeer");
            else if (temp < 40 && temp >= 30)
                Console.WriteLine("Moose");
            else if (temp < 20 && temp >= 10)
                Console.WriteLine("Penguin");
            else if (temp < 10 & temp >= 0)
                Console.WriteLine("Polar Bear");
            else
                Console.WriteLine("Bug");

            Console.ReadLine();

            // I have already declared i as a variable earlier in the code, so to fix the error 
            // with this code, I just need to change the variable from i to anything else. 
            // Also, the incrementer was never set, so it wasn't increasing. 
            int x = 10;
            while (x <= 20)
            {               
                Console.WriteLine("{0} ", x);
                x++;
            }
            Console.ReadLine();

            // The problem with this statement, was that the WriteLine with 
            // ("********") was not included in the body of the for loop.
            // This has been changed, it now works fine. 
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            Console.ReadLine();

        }
    }
}
