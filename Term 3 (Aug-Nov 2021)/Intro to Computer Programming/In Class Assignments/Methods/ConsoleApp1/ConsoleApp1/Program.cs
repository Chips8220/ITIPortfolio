using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleInfo(5);
            CircleInfo(50);
            Console.WriteLine(SumMinMax(4, 5, 6));
            Console.WriteLine(SumMinMax(10, 75, 97));
        }
        public static double Convert(double amount, double factor)
        {
            double result = amount * factor;
            return result;
        }
        public static void CircleInfo(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            area = Math.Round(area, 3);
            double circumference = 2 * radius * Math.PI;
            circumference = Math.Round(circumference, 3);
           
            Console.WriteLine($"\nThe area of this circle is {area}");
            Console.WriteLine($"The Circumference of this circle is {circumference}");
        }
        public static int SumMinMax(int A, int B, int C)
        {
            int Max = Math.Max(Math.Max(A,B),C);
            int Min = Math.Min(Math.Min(A,B),C);

            return Max + Min;

        }
    }


}
