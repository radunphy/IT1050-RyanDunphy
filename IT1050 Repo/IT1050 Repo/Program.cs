// A Hello World! program in C#.
/* The above is a comment, useful for understanding why
 something was done or how it works. The asterisk on
 this comment lets me write the comment across multiple
 lines. */
using System;
//Allows direct use of System classes without fully qualifying them. 
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        /* Every C# console application must have a Main
         method, void is used to make Main return nothing.
         Also could have used static int. to return an 
         integer. */
        /* With either of those return types, it can take
         arguments. (static void Main(string[] args) or 
         static int Main(string[] args) return 0;)*/
        // args is a string array.
        {
            Console.WriteLine("Hello World!");
            //One of the output methods of the console class.

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}