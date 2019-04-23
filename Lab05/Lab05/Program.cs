using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Method Headers

/* public double getArea(double height, double width)
{
    return height * width;
} */

// A. Scope - This is found in the public keyword, another 
// possible keyword for this could be private. These are access
// modifiers, so public gives no restrictions on accessing, while
// private would.

// B. Static vs Non-Static - There is no static keyword found, 
// so this is a non-static method. This means that it will not be
// accessible outside of the class. The other option would be to
// include the word static in the method header.

// C. Return type - This is found inside the curly braces, and 
// describes what type of value will be returned from the program.
// In this program, it will return the product of height * width.
// Another option could be the { get; set; } return value.

// D. Method Name - This identifies what the method is called,
// in this example it is getArea. Another option would be multiplyNumbers

// E. Parameters - This shows what inputs the method requires.
// In this case, the parameters needed are the double variables
// height and width. Other options could be a string for example.

// F. Method Body - This is what is inside the curly braces after
// the method parameters. In this example, they are the return height * width
// program. Another option would be the { get; set; } body. 

// 2. The difference between a user-defined method and a method
// that is provided within a framework is first off, that methods
// provided by the framework are EXTREMELY simple to use. They
// have been set up for us to use, and we can start usin them immediately.
// They don't always have everything we need them to do however, 
// so we often need to create our own methods. We can design methods
// specifically for our purposes, however they take more time and
// we can mess them up. We should continue whether there is a pre-existing
// framework that does what we need it to do BEFORE we go and 
// create a brand-new one for our own purposes. 

// 3. Static vs Non-Static methods - Static methods are easy to
// access, because they can be called outside of the class by using
// the class name and a member access modifier. A non-static method
// cannot be used like this. 

// 4/5. See Dog.sln for the answers to these questions. 

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
