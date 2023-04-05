using System;

namespace Page_394
{
    class Program
    {
        static void Main(string[] args)
        {
            int valid = 0;
            int invalid = 0;
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Please input Value.");
                string input = Console.ReadLine();
                double value = double.Parse(input);
                if (value < 100 && value > 0)
                {
                    valid++;
                }
                else
                {
                    invalid++;
                    Console.WriteLine("invalid Value is outside the range by = {0}", 100 - value);
                }
                Console.WriteLine("Amount of Valid = {0}", valid);
                Console.WriteLine("Amount of Invalid = {0}", invalid);
                
            }
        }
    }
}
