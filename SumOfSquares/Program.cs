using System;

namespace SumOfSquares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");

            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            Console.WriteLine("Sum Of squares of n starting from 1 ");
            for (int i = 1; i <=n; i++)
            {
                
                Console.Write($"Sum Of squares of  {i} : {sum} + {i} * {i} = ");
                sum += i * i;
                Console.WriteLine(sum);

            }
        }
    }
}
