using System;

namespace NextDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("enter a year: ");
            int year;
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter  the Month ");
            int month;
            month = Convert.ToInt32(Console.ReadLine());


            Console.Write("Entwr the  day : ");
            int day;
            day = Convert.ToInt32(Console.ReadLine());

            DateTime today = new DateTime(year,month,day);
            DateTime nextDay = today.AddDays(1);

            Console.WriteLine(today.ToString());
            Console.WriteLine(nextDay.ToString());
            

        }
    }
}
