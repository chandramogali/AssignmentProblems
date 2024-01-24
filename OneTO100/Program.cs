using System;

namespace OneTO100
{
    internal class Program
    {
        static void OneToHundred(int s, int e)
        {
            if (s <= e)
            {
                Console.WriteLine(s);
                OneToHundred(s + 1, e);
            } 
        }
        static void Main(string[] args)
        {
            int s = 0;
            int e = 100;

            OneToHundred(s, e);
        }
    }
}
