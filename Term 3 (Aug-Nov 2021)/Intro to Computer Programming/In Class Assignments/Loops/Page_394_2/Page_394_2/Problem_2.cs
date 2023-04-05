using System;

namespace Page_394_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            Console.WriteLine("Please input price to be marked up.");
            string input = Console.ReadLine();
            double Price = double.Parse(input);
            double Markup = 0;
            for (double p = 0.05; p < .1;p+=.01)
            {
                Markup = (Price * p) + Price;
                Console.WriteLine("New Price is = {0}", Markup);
            }
            
        }
    }
}
