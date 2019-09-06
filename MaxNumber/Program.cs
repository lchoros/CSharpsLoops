﻿using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
