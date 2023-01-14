using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число M:");
            int numberM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное число N:");
            int numberN = int.Parse(Console.ReadLine());

            ///Метод вывода чисел в промежутке от M до N
            void NumberCounter(int numberM, int numberN)
            {
                if (numberM < 0 || numberN < 0) Console.Write($"{numberM} не натуральное число");
                if (numberM == numberN) return;
                Console.Write($"{numberM} ");
                NumberCounter(numberM + 1, numberN);
            }

            NumberCounter(numberM, numberN);
        }
    }
}
