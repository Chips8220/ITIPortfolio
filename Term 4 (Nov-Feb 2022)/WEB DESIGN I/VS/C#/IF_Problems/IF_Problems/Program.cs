using System;

namespace IF_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease input integer.");
            String input = Console.ReadLine();
            int A = int.Parse(input);
            if (A % 2 == 0)
            { Console.WriteLine("This integer is Even. "); }
            if (A % 2 == 1)
            { Console.WriteLine("This integer is Odd. "); }


            Console.WriteLine("\nPlease input integer.");
            input = Console.ReadLine();
            int B = int.Parse(input);
            if (B % 2 == 0)
            { Console.WriteLine("This Integer is Even. "); }
            else if  (B%2 == 1)
                        { Console.WriteLine("This Integer is Odd. "); }


            Console.WriteLine("\nPlease input integer.");
            input = Console.ReadLine();
            int C = int.Parse(input);
            if (C % 2 == 0)
            {if (C % 4 == 0)
                { Console.WriteLine("This Integer is Even and divisible by 4"); } }
            else if (C % 2 == 1)
            { if (C % 5 == 0)
                { Console.WriteLine("This integer is Odd and divisible by 5"); } }



            Console.WriteLine("\nPlease input integer.");
            input = Console.ReadLine();
            int D = int.Parse(input);
            if (D % 2 == 0 && D % 4 ==0)
            {
              Console.WriteLine("This Integer is Even and divisible by 4"); 
            }
            else if (D % 2 == 1 && D  % 5 == 0)
            {
              Console.WriteLine("This integer is Odd and divisible by 5");
            }


            input = Console.ReadLine();
            int parsedinput;
            bool parsed = int.TryParse(input, out parsedinput);
            if (parsed)
            { Console.WriteLine("Parse successful! I read the Int!" + parsedinput); }
            else
            { Console.WriteLine("Parse not successful."); }

        }
    }
}
