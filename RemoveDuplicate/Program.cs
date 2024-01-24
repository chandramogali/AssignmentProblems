using System;

namespace RemoveDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements");
            int size = 8;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
             

            Array.Sort(arr);
            

            int j = 0;
            int[] temp= new int[size];
            for (int i = 0; i < size - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                    
                }
            }

            temp[j++] = arr[size - 1];

            for (int k = 0;k <j;k++)
                {
                Console.WriteLine(temp[k]); 
                }


               
                
            }
        }
    }
}
