using System;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip the coin");
            int head = 0;
            int tail = 0;
            while( head <=20 && tail <=20 )
            {
                Random rand = new Random();
                int num = rand.Next(2);
                if(num == 0 )
                {
                    tail++;

                }
                else
                {
                    head++;
                }
            }

            if( head >=20 ) {
                Console.WriteLine("Head won !");
            }
            else
            {
                Console.WriteLine("Tail won !");
            }
        }
    }
}
