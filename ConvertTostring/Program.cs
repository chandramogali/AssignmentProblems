using System;

namespace ConvertTostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            string ans = "";

            if (num % 3 == 0 && num % 5 == 0 && num % 7 != 0)
            {
                ans += "PlingPlang";
            }
             else if (num % 3 == 0)
            {
                ans += "Pling";
            }else if(num % 5==0)
            {
                ans += "Plang";
            }
            else if (num %7 ==0)
            {
                ans += "Plong";
            }
            else
            {
                ans += num.ToString();
            }

            Console.WriteLine(ans);
        }
    }
}
