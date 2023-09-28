using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber3._4
{
    internal class Program
    {
        enum DayOfWeek : int
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            int DayNum = int.Parse(Console.ReadLine());
            switch (DayNum)
            {
                case 1:
                    Console.WriteLine(Monday);
            }
        }
    }
}
