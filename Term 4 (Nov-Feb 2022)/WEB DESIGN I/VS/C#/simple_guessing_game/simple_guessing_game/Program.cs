using System;

namespace simple_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool playing;
            int numbGame = 0;
            int numbWin = 0;

            do
            {
                int goal = genGame(0, 20);
                numbGame++;
                
                playGame(5, goal);

               
                playing = playagain();
             } while (playing);
            Console.WriteLine("this is your record {0} wins : {1} games.\n", numbWin, numbGame);
            Console.WriteLine("goodbye..... ");
        }
        public static bool playagain()
        {
            Console.WriteLine("\n play again? Y or N : ");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool takeTurn(int winner)
        {
            Console.WriteLine("Please guess a number between 0 and 20.");
            string input = Console.ReadLine();
            int guess;
            bool parsed = int.TryParse(input, out guess);

            if (parsed)
            {
                if (guess >= 0 && guess <= 21)
                {
                    if (guess == winner)
                    {
                        
                        Console.WriteLine($"You Guessed {guess}");
                        Console.WriteLine("Yay! You Win!");
                        //numbWin++;
                        return true;
                    }
                    else
                    {

                        Console.WriteLine($"You Guessed {guess}");
                        Console.WriteLine("You lose! Try again.");

                    }
                }
                else
                {
                    Console.WriteLine("Not Within Acceptable range! Try again!\n");
                }

            }
            else
            {
                Console.WriteLine("Not Acceptable input! Try again!\n");
            }
            return false;
        }

        public static int genGame(int low, int high)
        {
            Random rnd = new Random();
            return rnd.Next(low, high+1);
        }

        public static void playGame(int numbTurn, int winner)
        {
            for (int i = 0; i < numbTurn; i++)
            {
                bool won = takeTurn(winner);
                if (won)
                {
                    break;
                }
            }
        }
    }

}
