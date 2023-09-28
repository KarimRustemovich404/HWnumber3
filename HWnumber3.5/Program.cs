using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HWnumber3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Toys = { "Barbie Doll", "Hello Kitty", "Buzz Lighter", "Gun", "Drugs" };
           
            foreach(string i in Toys)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
