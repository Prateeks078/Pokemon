using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// It is a special Member function which is invoked whenever an object is being created and It does'nt have a return type.
// It is always written as public part 
namespace Pokemon.OOPS
{
    internal class Complex99
    {
        private int a, b;

        //Initialising a Default Constructor

        public Complex99()
        {
            Console.WriteLine("Hello World");
            a = 1019;
            b = 909;
        }

        //Writing a Parameterixed Constructor 
        //public Complex99(int arg1, int arg2) {
        //    a = arg1;
        //    b = arg2;
        //    Console.WriteLine("I am Inside Parameterized Constructor");
        //}

        public void Display() {
            Console.WriteLine("The Complete number is: " + a + " + " + b+ "i"); // If constructor is commented --> 0 +0 i will be the ans, not some random no
        }
    }
}
