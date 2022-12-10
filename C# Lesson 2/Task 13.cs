using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInt("Введите число: ");
            int count = number.ToString().Length;
            Console.Write(CheckNum(number, count));

            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            int CheckNum(int a, int b)
            {
                int result = 0;
                if (b < 3)
                {
                    Console.Write("Третьей цифры нет, получи ноль: ");
                }
                else
                {
                    int c = 1;
                    for (int i = b; i > 3; i--)
                    {
                        c = c * 10;
                    }

                    result = (a / c) % 10;
                }
                return result;
            }
        }
        }
    }
}
