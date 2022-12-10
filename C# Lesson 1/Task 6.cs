using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int startNumber = 1;


            while (startNumber <= number)
            {
                if (startNumber % 2 == 0)
                    Console.Write(startNumber + ", ");
                startNumber++;
            }
        }
    }
}
