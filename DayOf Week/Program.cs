using System;

namespace DayOf_Week
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select your Lucky day! ");

            Console.WriteLine("Press 0 for Sunday");
            Console.WriteLine("Press 1 for Monday");
            Console.WriteLine("Press 2 for Tuesday");
            Console.WriteLine("Press 3 for Wednesday");
            Console.WriteLine("Press 4 for Thursday");
            Console.WriteLine("Press 5 for Friday");
            Console.WriteLine("press 6 for Saturday");

            
            int day=Convert.ToInt32(Console.ReadLine());

            switch(day){

                case 0:
                    Console.WriteLine("Your lucky is SundaY");
                    break;
                case 1:
                    Console.WriteLine("Your lucky is Monday");
                    break;
                case 2:
                    Console.WriteLine("Your lucky is Tuesaday");
                    break;
                case 3:
                    Console.WriteLine("Your lucky is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Your lucky is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Your lucky is Friday");
                    break;
                case 6:
                    Console.WriteLine("Your lucky is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Value ! Please select your Lucky Day!");
                    break;
            }
            
        }
    }
}
