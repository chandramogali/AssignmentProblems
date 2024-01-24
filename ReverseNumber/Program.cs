using System;

namespace ReverseNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n=Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int rem = 0;
            int rev = 0;

            while(n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n /= 10;
            }
            Console.WriteLine($"Number {temp} After Reversed number is {rev}");
        }
    }
}
