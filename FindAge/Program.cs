using System;

namespace FindAge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1997, 11, 23);
            DateTime currentDate = DateTime.Now;

            // Calculate the age in years
            int ageInYears = currentDate.Year - birthdate.Year;

            // Check if the birthdate for the current year has occurred or not
            if (currentDate < birthdate.AddYears(ageInYears))
            {
                ageInYears--;
            }

            // Calculate the age in days, weeks, and months
            int ageInDays = (int)(currentDate - birthdate).TotalDays;
            int ageInWeeks = ageInDays / 7;
            int ageInMonths = ageInYears * 12 + currentDate.Month - birthdate.Month;

            // Print the calculated age
            Console.WriteLine("Age: " + ageInYears + " years");
            Console.WriteLine("Age: " + ageInDays + " days");
            Console.WriteLine("Age: " + ageInWeeks + " weeks");
            Console.WriteLine("Age: " + ageInMonths + " months");
           

        }
    }
}
