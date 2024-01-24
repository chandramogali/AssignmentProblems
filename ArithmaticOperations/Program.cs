using System;

namespace ArithmaticOperations
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the Arithmatic Operation !");
            Console.WriteLine("press 1 for Addition");
            Console.WriteLine("press 2 for Subtraction");
            Console.WriteLine("press 1 for Multiplication");
            Console.WriteLine("press 1 for Division");
            Console.WriteLine("press 1 for Modulus");

            int operation =Convert.ToInt32(Console.ReadLine());

            switch(operation)
            {
                case 1:
                    int sum=num1 + num2;
                    Console.WriteLine($"Sum of two number {num1} + {num2} = {sum}");
                    break;
                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine($"Sum of two number {num1} - {num2} = {sub}");
                    break;
                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine($"Sum of two number {num1} * {num2} = {mul}");
                    break;
                case 4:
                    int div = num1 / num2;
                    Console.WriteLine($"Sum of two number {num1} / {num2} = {div}");
                    break;
                case 5:
                    int mod = num1 % num2;
                    Console.WriteLine($"Sum of two number {num1} % {num2} = {mod}");
                    break;
                default:
                    Console.WriteLine("Invalid input value !");
                    break;
                
            }


        }
    }
}
