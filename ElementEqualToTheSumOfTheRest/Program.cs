using System;

namespace ElementEqualToTheSumOfTheRest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > max)
                {
                    max = number;
                }
                sum += number;
            }
            sum = sum - max;
            if(max == sum)
            {
                Console.WriteLine("Yes Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(max - sum));
            }
        }
    }
}
