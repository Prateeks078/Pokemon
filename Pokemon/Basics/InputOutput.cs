using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class InputOutput
    {
        public static void Run() {

            Console.WriteLine("Hey, Pokemon this side !!!");
            int age = 10;
            string Name = "Pikachu";
            Console.WriteLine("My name is " + Name + "and my age is " + age);


            //------------------------------------
            // Building the Name Questioning Model

            Console.Write("Please Enter Your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello" + userName);
            Console.WriteLine("Bye");
     
        }
    }
}
