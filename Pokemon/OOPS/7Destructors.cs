using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{
    internal class Num
    {
        private int count;

        // Writing a Default Constructor
        public Num() {
            Console.WriteLine("Entering into Constructor of Object Number" + count);
            count++; 
        }

        // Writing a Destructor 
        ~Num() {
            Console.WriteLine("Exiting from Constructor of Object Number" + count);
            count--;
        }
    }
}
