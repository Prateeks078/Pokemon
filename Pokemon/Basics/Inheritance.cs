using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class IndianChef
    {
        public void MakeChapatti() {
            Console.WriteLine("Makes Chapatti !!");
        }

        public void MakeRice() {
            Console.WriteLine("Makes Rice !!");
        }

        public virtual void MakeSpecialDish() {
            Console.WriteLine("Makes an Indian Cuisine !!");
        }

    }
}
