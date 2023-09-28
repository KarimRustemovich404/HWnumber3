using System;

namespace HWnumber3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3. Программа принимает на входе строку и производит выходные данные в соответсвии с таблицей.\nВведите строку из левого столбца таблицы:");

            string drinker = Console.ReadLine();

            switch (drinker)
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "School Counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Tax Fraud");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            Console.WriteLine("Нажмите ВВОД, чтобы закрыть программу");
            Console.ReadLine();

        }
    }
}
