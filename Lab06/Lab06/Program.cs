using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ryan Dunphy's Lab 6 for IT1050 Programming Logic
// Arrays --- for/foreach Loops --- Modifying Arrays

// 1. A one-dimensional arrya p contains four elements. The array access expressions to
// access each of the elements in p are [0], [1], [2], and [3].

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new array months
            string[] months = { " January", " February", " March", " April",
                " May", " June", " July", " August", " September", " October",
                " November", " December" };
            
            // Iterate through months, printing out element number + month
            for ( int month = 0; month < months.Length; month++)
            {
                Console.WriteLine(month + months[month]);
            }
            Console.ReadLine();

            // Create new array seasons
            string[] seasons = { "Summer", "Fall", "Winter", "Spring" };

            // Iterate through array seasons with foreach loop
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
            Console.ReadLine();

            // Create new array integers with 1000 elements
            int[] integers = new int[1000];

            // Create random variable --- Declare int randomNumber
            Random random = new Random();
            int randomNumber;

            // Loop to print 1000 random numbers to the Console
            foreach (int integer in integers)
            {
                randomNumber = random.Next(0, 100);
                Console.WriteLine(randomNumber);
            }
            Console.ReadLine();

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }
            Console.ReadLine();

            // Create new array integers with 1000 elements
            int[] integers2 = new int[1000];

            // Create random variable --- Declare int randomNumber
            Random random2 = new Random();
            int randomNumber2;

            // Loop to print 1000 random numbers to the Console
            foreach (int integer2 in integers2)
            {
                randomNumber2 = random2.Next(0, 100);
                Console.WriteLine(randomNumber2);
            }
            Console.ReadLine();
        }
    }
}
