using System;

namespace HWnumber3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение №2. По заданному номеру карты определить достоинтво карты.\nВведите номер карты, значение которой хотите получить (числом, а не словом):");

            int Number = int.Parse(Console.ReadLine());
            try
            {
                switch (Number)
                {
                    case 6:
                        Console.WriteLine("Шестёрка");
                        break;
                    case 7:
                        Console.WriteLine("Семёрка");
                        break;
                    case 8:
                        Console.WriteLine("Восмёрка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверно введено значение карты");
            }
            finally
            {
                Console.WriteLine("Мерси");
            }
            Console.WriteLine("Нажмите ВВОД, чтобы закрыть программу");
            Console.ReadKey();
        }
    }
}
