using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class ExceptionHandling
    {
        public static void Run1() {

            try
            {
                Console.WriteLine("Enter the First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine()); // C# by default takes string as an input 

                Console.WriteLine("Enter the Second Number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }


        public static void Run2() {
            try
            {
                Console.WriteLine("Enter the First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine()); // C# by default takes string as an input 

                Console.WriteLine("Enter the Second Number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException f) 
            {
                Console.WriteLine(f.Message);
            }
        }
    }
}
