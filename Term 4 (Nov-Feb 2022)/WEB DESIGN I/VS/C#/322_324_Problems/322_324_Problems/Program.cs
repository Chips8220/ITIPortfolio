using System;

namespace _322_324_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            Console.WriteLine("Please Input PH level.");
            string input = Console.ReadLine();
            double PH;
            bool parsed = double.TryParse(input, out PH);
            if(PH <= 6.9 && PH >= 0 )
            { Console.WriteLine("Solution is Acidic. Please add alkaline additive."); }
            else if(PH >= 7 && PH <= 7.8)
            { Console.WriteLine("Solution is Neutral."); }
            else if (PH >= 7.9 && PH <= 14)
            { Console.WriteLine("Solution is Alkaline. Please add acidic additive."); }
            else
            { Console.WriteLine("PH value is invalid."); }

            //Problem 4
            Console.WriteLine("\nPlease Input First Name.");
            input = Console.ReadLine();
            string FirstName = input;
            Console.WriteLine("Please Input Last Name.");
            input = Console.ReadLine();
            string LastName = input;
            Console.WriteLine("Please Input Employee ID.");
            input = Console.ReadLine();
            string ID = input;
            Console.WriteLine("Please Input Payment Type.");
            string JobType = Console.ReadLine();
            const double OT = 1.5;
            if (JobType == "Salary")
            {
                Console.WriteLine("Please Input Amount of Weekly Payment.");
                input = Console.ReadLine();
                double WeeklyAmount = double.Parse(input);
                Console.WriteLine("Salary Amount = {0:c}", WeeklyAmount * 52);
            }
            else if (JobType == "Hourly")
            {
                Console.WriteLine("Please Input Amount of Hours per Week");
                input = Console.ReadLine();
                int Hours = int.Parse(input);
                Console.WriteLine("Please Inpute Pay Rate");
                input = Console.ReadLine();
                double PayRate = double.Parse(input);
                if (Hours <= 40)
                {
                    Console.WriteLine("Hourly Amount = {0:c}", PayRate * Hours);
                }
                else if (Hours>40)
                {
                    Console.WriteLine("Overtime Hourly Amount = {0:c}", (PayRate*OT) * Hours);
                }
            }

        }
    }
}
