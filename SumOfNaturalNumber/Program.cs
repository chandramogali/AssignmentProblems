using System;

namespace SumOfNaturalNumber
{
   public class Program
    {
        public static void Main(string[] args)
        {
            
            int sum = 0;
            int i = 0;
            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"sum of first 5  natural  numbers  {sum} ");
        }
    }
}
