using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class Car
    {
        public string brand;
        public int price;
        public string ceo;

        public Car(string b,int p,string c) { // This is a constructor, if i would'nt have written public it would have become private constructor 
            brand = b;
            price = p;
            ceo = c;
        }
    }
}
