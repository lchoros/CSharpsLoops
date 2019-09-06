using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDifference = 0;
            int previousSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;
                if(i > 0)
                {
                    int difference = Math.Abs(previousSum - sum);
                    if(maxDifference < difference)
                    {
                        maxDifference = difference;
                    }
                }
                previousSum = sum;
            }
            if(maxDifference == 0)
            {
                Console.WriteLine("Yes, value={0}", previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
