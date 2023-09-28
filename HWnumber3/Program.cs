using System;

namespace HWnumber3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t");

            Console.WriteLine("Введите значения последовательности:");
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("Вы ввели пустую строку.");
            }

            double[] sequence = new double[10]; // создаем массив для хранения чисел

            for (int i = 0; i < sequence; i++)
            {
                int sequencei = int.Parse(Console.ReadLine());
            }

            int index = -1; // индекс начала последовательности

            switch (input)
            {
                case "1":
                    index = 1;
                    break;
                case "2":
                    index = 2;
                    break;
                case "3":
                    index = 3;
                    break;
                case "4":
                    index = 4;
                    break;
                case "5":
                    index = 5;
                    break;
                case "6":
                    index = 6;
                    break;
                case "7":
                    index = 7;
                    break;
                case "8":
                    index = 8;
                    break;
                case "9":
                    index = 9;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }

            if (index >= sequence)
            {
                Console.WriteLine("Последовательность прервана.");
                return;
            }

            foreach (var number in sequence)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("Нажмите ВВОД, чтобы закрыть программу");
            Console.ReadKey();

        }
    }
}
