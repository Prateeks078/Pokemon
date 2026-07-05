using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write() → writes without moving to the next line.
//WriteLine() → writes and then moves to the next line.
//ReadLine() → reads an entire line until you press Enter.
//Read() → reads a single character.


namespace Pokemon.OOPS
{
    internal class NestingMemberFunctions
    {
        private string s; // C++ initializes as atring initially but C# gives it as NULL
        private string n="";

        // Also Strings are immutable in C#, means i cant go and change the character of a string from nowhere.
        // It will give me a compile time error, Hence go with making a new string instead. 
        
        
        public void Getnum() {
            Console.WriteLine("Enter the number please: ");
            s = Console.ReadLine();

            Displaynum(s);
        }

        public void Displaynum(string x) {
            Console.WriteLine("Displaying the Binary Number: ");
            for (int i = 0; i < x.Length; i++) {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine(" ");
        }

        public void Checkbin() {
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != '0' && s[i] != '1') {
                    Console.WriteLine("Incorrect Binary Format...");
                    break;
                }
            }
        }

        public void OnesBin() {

            // Making Use of Nesting Member Functionality Use:
            Displaynum(s);

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == '1')
                {
                    n=n+"0";
                }
                else
                {
                    n=n+"1";
                }
            }
            Displaynum(n);
        }

    }

}
