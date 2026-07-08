using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{
    internal class Complex
    {
        private int a, b;

        public void SetReal()
        {
            Console.WriteLine("Enter the Real Number: ");
            a =int.Parse(Console.ReadLine());
        }

        public void SetComplex() {
            Console.WriteLine("Enter the Complex Number: ");
            b = int.Parse(Console.ReadLine());
        }

        public void DisplayNum() {
            Console.WriteLine("The Complete Number is: " + a + "+" + b + "i");
        }

        public void Numadd(Complex obj1, Complex obj2) { // Passed Object in Method Parameters
            a = obj1.a + obj2.a;
            b = obj1.b + obj2.b;
        }
    }
}
