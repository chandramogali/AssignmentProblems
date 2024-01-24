using System;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void WhoWillWin()
        {
            bool flag=false;
            int PosPlyer1 = 0;
            int PosPlyer2 = 0;
            int TargetToWin = 100;
            int count1 = 0;
            int count2 = 0;
            Random random = new Random();
            while (PosPlyer1 < TargetToWin && PosPlyer2 < TargetToWin)
            {
               switch(flag)
                {
                case false:

                    int RollPlayer1 = random.Next(1, 7);
                    count1++;
                    Console.WriteLine($" Plyer1 { count1} = {RollPlayer1}");
                    if (PosPlyer1 + RollPlayer1 > TargetToWin)
                    {
                            Console.WriteLine($"Player1 need to score exactly {TargetToWin - PosPlyer1} To  Win");
                            
                        
                    }
                    else
                    {
                            int Roll1 = random.Next(1, 3);
                            if (PosPlyer1 < 0)
                            {
                                PosPlyer1 = 0;
                            }

                            if (Roll1 == 1)
                            {
                                PosPlyer1 += RollPlayer1;
                            }
                            else
                            {
                                PosPlyer1 -= RollPlayer1;
                            }
                        }


                        if (PosPlyer1 == TargetToWin)
                        {
                            Console.WriteLine($"Player 1 Won the game Number of Rools {count1}");
                            Console.WriteLine("Congratulation Player1 ");
                            break;
                        }

                        if (RollPlayer1 == 6)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                        break;
                
                case true:
                
                    int RollPlayer2 = random.Next(1, 7);

                    count2++;
                        Console.WriteLine($" Player2 {count2} = {RollPlayer2}");

                        if (PosPlyer2 + RollPlayer2 > TargetToWin)
                         {
                          Console.WriteLine($" Player 2 you need to score exactly  {TargetToWin - PosPlyer2} To Win");
                         }
                       else
                        {
                            int Roll = random.Next(1, 3);
                            if (PosPlyer2 < 0)
                            {
                                PosPlyer2 = 0;
                            }

                            if (Roll==1)
                            {
                                PosPlyer2 += RollPlayer2;
                            }
                            else
                            {
                                PosPlyer2 -= RollPlayer2;
                            }

                           
                            
                        }


                        if (PosPlyer2 == TargetToWin)
                        {
                            Console.WriteLine($"Player 2 Won the game Number of Rools {count2}");
                            Console.WriteLine("Congratulation Player2");
                            break;
                        }

                        if (RollPlayer2 == 6)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag= false;
                    }
                    break;
                 default:
                    break;


                }

                

                
            }

        }
        public static void Main(string[] args)
        {
            Program.WhoWillWin();

            /*
             * que1=> create a file and add date to it.
                que2=> verify the use input 
                 1. first name start with capital remaining should be small and minimum lenght should be three or more
	               2. verify your email which support .com .in and .ac 
                que3=> create Product review management 
	                1. fetch product using product name 
	                2. find which product having maximum rating 
	                3. find the product of price range from 2k to 5k 
             */
        }
    }
}
