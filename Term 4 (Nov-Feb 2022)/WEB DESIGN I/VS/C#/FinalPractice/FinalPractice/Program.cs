using System;

namespace FinalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chapter 2 Number 8 Practice
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Chatper 2 Number 8");
            Console.ResetColor();
            Console.WriteLine("Please input Values of Homework, Projects, Quizzes, Exams, and Final Exams.");
            string input = Console.ReadLine();
            double HW = double.Parse(input);
            input = Console.ReadLine();
            double Proj = double.Parse(input);
            input = Console.ReadLine();
            double Quiz = double.Parse(input);
            input = Console.ReadLine();
            double Exam = double.Parse(input);
            input = Console.ReadLine();
            double FE = double.Parse(input);
            // Percentages breakdown
            double per10 = .10;
            double per15 = .15;
            double per30 = .30;
            double per35 = .35;
            // Average Breakdown
            double HW10 = HW * per10;
            double Proj35 = Proj * per35;
            double Quiz10 = Quiz * per10;
            double Exam30 = Exam * per30;
            double FE15 = FE * per15;
            // Total
            double Total = HW10 + Proj35 + Quiz10 + Exam30 + FE15;
            // Breakdown
            Console.WriteLine($"{"Homework",15} : {HW10:n1}");
            Console.WriteLine($"{"Projects",15} : {Proj35:n1}");
            Console.WriteLine($"{"Quizzes",15} : {Quiz10:n1}");
            Console.WriteLine($"{"Exams",15} : {Exam30:n1}");
            Console.WriteLine($"{"Final Exam",15} : {FE15:n1}");
            Console.WriteLine($"{"Total Grade",15} : {Total:n1}\n");
            // Chapter 3 Number 3
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Chatper 3 Number 3");
            Console.ResetColor();
            Console.WriteLine("The Area of the Rectangle is      : {0:n1}", RectArea(8, 9));
            Console.WriteLine("The Perimeter of the Rectangle is : {0:n1}\n", PermRect(8, 9));
            // Chapter 4 number 6
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Chatper 4 Number 6");
            Console.ResetColor();
            Trip a = new Trip("NewOrleans", 70.7, 2.30, 8);
            Console.WriteLine(a);
            // Chpater 4 number 10
            Money m = new Money(3.50);
            Money n = new Money(103, 34);
            Money o = new Money(55, 99);
            Console.WriteLine(m);
            Console.WriteLine(m.ToDenom());
            Console.WriteLine(n);
            Console.WriteLine(n.ToDenom());
            Console.WriteLine(o);
            Console.WriteLine(o.ToDenom());
            //Card Class Practice
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Class Practice Card");
            Console.ResetColor();
            Card AceofSpades = new Card(1, "Spade");
            Card King = new Card(13, "Heart");
            Console.WriteLine(King.Beats(AceofSpades));


        }
        // Problem Chapter 3 Problem 3
        public static double PermRect(double w, double h)
        {
            double PermRect = 2 * (w * h);
            return PermRect;
        }
        public static double RectArea(double w, double h) 
        {
            double AreaRect = w * h;
            return AreaRect;
                
        }
        
    }
}
