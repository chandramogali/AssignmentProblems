using System;

namespace Admission
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks for subject Mathematics");
            int math=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for subject Pysics");
            int pysics=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for subject Chemistry");
            int chemistry=Convert.ToInt32(Console.ReadLine());

            int total= math + pysics + chemistry;
            int pymath=math+pysics;
            int cheMath=math+chemistry;

            Console.Write("Result : ");

            if (math < 35 || pysics < 35 || chemistry < 35)
            {
                Console.WriteLine("Candidate not Eligible for Admission");
            }
            else
            {
                if (total >= 180)
                {
                    Console.WriteLine("The Candidate can eligible for Admission");
                }
                else if (pymath >= 140)
                {
                    Console.WriteLine("The Candidate can eligible for Admission");
                }
                else if (cheMath >= 140)
                {
                    Console.WriteLine("The Candidate can eligible for Admission");
                }
                else
                {
                    Console.WriteLine("Candidate not Eligible for Admission");
                }
            }

        }
    }
}
