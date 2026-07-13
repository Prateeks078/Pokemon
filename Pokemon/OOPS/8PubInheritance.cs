using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{
    internal class Base
    {
        private int data1;
        public int data2;



        //----------------------------------------
        // Initialising Default Constructor 
        //public Base(){
        //    data1 = 190;
        //    data2 = 199;
        //}

        public void SetData() {
            data1 = 190;
            data2 = 199;
        }
        //--------------------------------------


        public int GetData1() { // if it would be private, i would'nt have accessed it from Prog.cs ik it sounds foolish yet i missed
            return data1;
        }
        public int GetData2() {
            return data2;
        }
    }

    internal class Derived :Base{ // There is no issue of inheritance mode in C# (Default: Public Mode)

        private int data3;

        public void Process()
        {
            //data3 = data2 * data1; ---> This is invalide can't access data1 anyways
            data3 = data2 * GetData1();
        }

        public void Display() {
            //Console.WriteLine(data1);----> This is invalid
            Console.WriteLine(GetData1());
            Console.WriteLine(data2);
            Console.WriteLine(data3);
        }
        } 
}
