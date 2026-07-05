using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.OOPS
{
    internal class Shop
    {
        private int[] itemId = new int[100];
        private int[] itemPrice = new int[100];
        private int Counter;


        public void InitCounter() { Counter = 0; }
        public void SetPrice() {
            Console.WriteLine("Enter Id of your item: ");
            itemId[Counter]=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price of your item: ");
            itemPrice[Counter] = int.Parse(Console.ReadLine());

            Counter++;
        }

        public void DisplayPrice() {
            for (int i = 0; i < Counter; i++) {
                Console.WriteLine("Id of your item is " + itemId[i] + " and Price of your item is " + itemPrice[i]);
            }
            Console.WriteLine();
        }

    }
}
