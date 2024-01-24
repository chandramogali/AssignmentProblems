using System;

namespace SumAverage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int n=Convert.ToInt32(Console.ReadLine());

            int[] arr= new int[n];

            int sum = 0;
            int average = 0;
            Console.WriteLine("enter the Element  in  array");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }


            /*
            int sum1 = 0;

            foreach (var i in arr) {
                sum1 += i;
            }
            */


            average = sum/arr.Length;

            Console.WriteLine($"sum and Average of array is sum = {sum} and average = {average} ");

        }
    }
}
