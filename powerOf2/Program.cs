using System;

namespace powerOf2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number !");
            int n=Convert.ToInt32(Console.ReadLine());
            int power = 0;

            Console.WriteLine("2^0 = 1");
            for(int i = 1; i <= n; i++)
            {
                 power = (int)Math.Pow(2, i);

                Console.WriteLine($"2^{i} = {power}");
            }
        }
    }
}
