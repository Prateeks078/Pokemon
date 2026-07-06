using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{
    internal class Employee
    {
        private int Id;
        static int Counter; // Shared by the whole class instead of objects of the class 
        public void SetId (){
            Console.WriteLine("Enter the ID of Employee: ");
            Id=int.Parse(Console.ReadLine());
            Counter++;
        }

        public void GetId() {
            Console.WriteLine("The ID of Employee is: "+ Id +" and the count of the Employee is: "+Counter);
        }

        // Static Method in a Class 
        public static void GetCount() {
            // Console.WriteLine(Id);// Will be throwing error because a static method can't access Non-Static Members of a Class
            
            Console.WriteLine("The Value of the Count is: " + Counter);
        }
    }
}
