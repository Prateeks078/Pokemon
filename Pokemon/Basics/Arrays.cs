using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class Arrays
    {
        public static void Run(){
            // Declaring an Array
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            //Declaring a character array of a fixed length 
            string[] arr2 = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
