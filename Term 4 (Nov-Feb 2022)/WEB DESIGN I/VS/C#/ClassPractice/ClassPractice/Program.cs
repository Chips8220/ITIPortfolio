using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TimesTable a = new TimesTable(3, 4);
            a.PrintTable();

            Console.WriteLine("");

            TimesTable b = new TimesTable(4, 3);
            b.PrintTable();

            Console.WriteLine("");

            TimesTable c = new TimesTable(10, 5);
            c.PrintTable();

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(c.Equals(b));
        }
    }
}
