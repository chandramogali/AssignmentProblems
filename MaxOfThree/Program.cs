using System;
using System.Collections.Generic;
namespace MaxOfThree
{

    public class Three
    {
        

        public static int MaximumOfThree(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                //Console.WriteLine($"{num1} is greater than {num2} and {num3}");
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                //Console.WriteLine($"{num2} is greater than {num1} and {num2}");
                return num2;
            }
            if (num3 >= num2 && num3 >= num1)
            {
                //Console.WriteLine($"{num3} is greater than {num2} and {num1}");
                return num3;
            }
            else
            {
                //Console.WriteLine($"All Three number {num1} {num2} and {num3} are equal ");
                return num1;
            }
        }
        public static double MaximumOfThree(double num1, double num2, double  num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                //Console.WriteLine($"{num1} is greater than {num2} and {num3}");
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                //Console.WriteLine($"{num2} is greater than {num1} and {num2}");
                return num2;
            }
            if (num3 >= num2 && num3 >= num1)
            {
                //Console.WriteLine($"{num3} is greater than {num2} and {num1}");
                return num3;
            }
            else
            {
                //Console.WriteLine($"All Three number {num1} {num2} and {num3} are equal ");
                return num1;
            }
        }
        public static char MaximumOfThree(char num1, char num2, char num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                //Console.WriteLine($"{num1} is greater than {num2} and {num3}");
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                //Console.WriteLine($"{num2} is greater than {num1} and {num2}");
                return num2;
            }
            if (num3 >= num2 && num3 >= num1)
            {
                //Console.WriteLine($"{num3} is greater than {num2} and {num1}");
                return num3;
            }
            else
            {
                //Console.WriteLine($"All Three number {num1} {num2} and {num3} are equal ");
                return num1;
            }
        }
    }
    public class Program
    {
        
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number1");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number1");
            int num3=Convert.ToInt32(Console.ReadLine());
            Three.MaximumOfThree( num1,  num2, num3);


        }
    }
}
