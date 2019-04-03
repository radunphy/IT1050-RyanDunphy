using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_and_Variables
{
    class Testing
    {
        static void Main( string[] args)
        {

            /*Console.WriteLine("Ryan's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")          
                 message = "You won a new car!";          
            else if (userValue == "2")
                 message = "You won a new boat!";                          
            else if (userValue == "3")          
                 message = "You won a new cat!";                         
            else
            {
                message = "Better luck next time!";
                message = message + " You Lose.";
            }


            Console.WriteLine(message);
            Console.ReadLine();*/


            /*Console.WriteLine("Ryan's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.ReadLine();

            Console.WriteLine("You entered: {0}, therefore you won a you won a {1}.", userValue, message);

            Console.ReadLine();*/

            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();*/

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            /*string[] names = new string[] { "Eddie", "Alex", "Michael", "Ryan Dunphy" };

            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine(); */

            string zig = "You can get what you want out of" +
                " life if you help enough other people get" +
                " what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

            

        }
    }
}
