using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if(number < evenMin)
                    {
                        evenMin = number;
                    }
                    if(number > evenMax)
                    {
                        evenMax = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
            }

            if(n == 0)
            {
                Console.WriteLine("OddSum={0},OddMin={1},OddMax={2},EvenSum={3},EvenMin={4},EvenMax={5}", 0, "No", "No", 0, "No", "No");
            }
            else if(n == 1)
            {
                Console.WriteLine("OddSum={0},OddMin={1},OddMax={2},EvenSum={3},EvenMin={4},EvenMax={5}", oddSum, oddMin, oddMax, 0, "No", "No");
            }
            else if (n > 1)
            {
                Console.WriteLine("OddSum={0},OddMin={1},OddMax={2},EvenSum={3},EvenMin={4},EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }
    }
}