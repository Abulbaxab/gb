using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine(number + " - Четное число: ");
            }
            else
            {
                Console.WriteLine(number + " - Нечетное число");
            }
        }
    }
}
