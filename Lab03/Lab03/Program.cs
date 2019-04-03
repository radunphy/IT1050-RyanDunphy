using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    // Comparing if statements and while statements
    class Program
    {
        static void Main(string[] args)
        {
            /* The if single-selection statement is a statement that is useful for a set 
             calculation. It is like a gate, where it only does something if it's conditions are passed.
             The while statement will continuously run until it's conditions are passed, so it
             is essentially the opposite. However they both act as gates, which the program will run checks
             on and react to their conditions being passed. 
            */
            
            // Declaring two int variables
            int speedLimit = 35;
            int speed = 42;

            if ( speed > speedLimit )
                Console.WriteLine( "SLOW NOW" );
                Console.ReadLine();

            // Assign a boolean value to isTrue, use condition to output
            // true or false based on assigned value

            bool isTrue = true;
            isTrue = (speed >= speedLimit);

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }
            Console.ReadLine();

            // A Program to convert Fahreinheit temperatures to Celsius
            // User input temperature at Command Prompt and output converted temperature
            // If F value < 40 "It is cold". If F value > 90, "It is hot". 

            // User Input
            Console.WriteLine("Temperature Converter from Fahreinheit to Celsius");
            Console.Write("Please enter a temperature in Fahreinheit. ");

            // Converting Console.ReadLine so math can be performed. 
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Set celsius variable and perform conversion from fahreinheit. 
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine(celsius);

            if (fahrenheit >= 90)
                Console.WriteLine("It is hot!");
            else if (fahrenheit <= 40)
                Console.WriteLine("It is cold!");

            Console.ReadLine();

            // Creating a while loop outputting values 1 to 10. Incrementing by 1
            int myValue = 1;
            while (myValue <= 10)
            {
                Console.WriteLine(myValue++);
            }
            Console.ReadLine();

            // Creating a while loop outputting values 60 to 20. Decrement by 5.
            int value2 = 60;
            Console.WriteLine(value2);
            while (value2 > 20)
            {
                Console.WriteLine(value2 -= 5);
            }
            Console.ReadLine();

            // Creating a while loop outputting values 10 to 20. Increment by 2.
            int value3 = 10;
            Console.WriteLine(value3);
            while (value3 < 20)
            {
                Console.WriteLine(value3 += 2);
            }
            Console.ReadLine();
        }
    }
}
