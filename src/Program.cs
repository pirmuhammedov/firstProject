﻿namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 4 xonali son kiriting: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number / 10 % 10;
            var hundreds = number / 100 % 10;
            var thousands = number / 1000;

            var sum = ones + tens + hundreds + thousands;

            Console.WriteLine(sum);
        }
    }
}
