using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{

    //  Points to Learn in C#
    // -->> Arrays are Mutable, But strings are Immutable  

    internal class Employee1
    {
        private int id;
        private int salary;

        public void SetId() {
            Console.WriteLine("Enter the ID of Employee: ");
            id=int.Parse(Console.ReadLine());
        }

        public void GetId() {
            Console.WriteLine("The ID of the Employee is: " + id);
        }
    }
}
