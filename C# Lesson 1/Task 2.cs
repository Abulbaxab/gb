﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("Максимальное число: " + firstNumber);
                }
                else
                {
                    Console.WriteLine("Максимальное число: " + thirdNumber);
                }
            }

            else if (secondNumber > thirdNumber)
            {
                Console.WriteLine("Максимальное число: " + secondNumber);
            }
            else
            {
                Console.WriteLine("Максимальное число: " + thirdNumber);
            }
        }
    }
}
