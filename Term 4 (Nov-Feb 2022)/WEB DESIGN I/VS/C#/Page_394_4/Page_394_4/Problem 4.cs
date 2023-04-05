using System;

namespace Page_394_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0;
            double count = 0;
            double acc = 0;
            do
            {
                Console.WriteLine("Please input Scores");
                string input = Console.ReadLine();
                score = double.Parse(input);
                if (score >= 0 && score <= 100) 
                {
                    acc += score;
                    count++;
                }
                else
                {
                    Console.WriteLine ($"\n{score} is invalid");
                }
            }
            while (score != -1);
            double Average = acc / count;
            if (Average>= 90)
            {
                Console.WriteLine($"\nThe Average is {Average:n1} which is an A ");
            }
            else if (Average >= 80)
            {
                Console.WriteLine($"\nThe Average is {Average:n1} which is an B ");
            }
            else if (Average >= 70)
            {
                Console.WriteLine($"\nThe Average is {Average:n1} which is an C ");
            }
            else if (Average >= 60 )
            {
                Console.WriteLine($"\nThe Average is {Average:n1} which is an D ");
            }
            else
            {
                Console.WriteLine($"\nThe Average is {Average:n1} which is an F ");
            }
        }
    }
}
