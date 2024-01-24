using System;

namespace PalindromeNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ! ");
            int n=Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int rev = 0;
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n /= 10;

            }
            if (rev == temp)
            {
                Console.WriteLine($"the given number {temp} is palindrome Number ");
            }
            else
            {
                Console.WriteLine($"the given number {temp} is Not palindrome Number ");
            }
        }
    }
}
