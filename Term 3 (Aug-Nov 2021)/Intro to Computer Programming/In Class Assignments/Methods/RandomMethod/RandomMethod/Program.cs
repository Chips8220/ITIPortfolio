using System;

namespace RandomMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate winning number
            Random rnd = new Random();
            
            bool keepplaying = true;

            do
            {
                int winningnumber = rnd.Next(0, 11);
                int guess = 0;
                do
                {
                    //user give number
                    Console.WriteLine("number plz");
                    string input = Console.ReadLine();
                    guess = int.Parse(input);


                    if (guess == winningnumber && guess >= 0 && guess <= 10)
                    {
                        Console.WriteLine("gj, you won.");
                    }
                    else
                    {
                        Console.WriteLine("try again.");
                    }
                } while (guess != winningnumber);
                Console.WriteLine("playing again? y/n");
                string playmore = Console.ReadLine();
                if(playmore == "y")
                {
                    keepplaying = true;
                }
                else
                {
                    keepplaying = false;
                }
            } while (keepplaying);


            Console.WriteLine("goodbye");




        }
    }
}
