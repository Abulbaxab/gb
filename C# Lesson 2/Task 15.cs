using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = ReadInt("Введите число от 1 до 7: ");
            Console.WriteLine(Day(dayNumber));

            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            string Day(int a)
            {
                if (a > 0 && a < 8)
                {
                    if (a == 7 || a == 6)
                    {
                        Console.Write("Под цифрой " + a + " - Выходной");
                    }
                    else
                    {
                        Console.Write("Под цифрой " + a + " - Рабочий");
                    }
                }
                else
                {
                    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому невозможно определить");
                }
                return " день.";
            }
        }
    }
}
