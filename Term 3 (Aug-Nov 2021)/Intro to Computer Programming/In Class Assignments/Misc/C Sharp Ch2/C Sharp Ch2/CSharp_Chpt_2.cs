using System;

namespace C_Sharp_Ch2
{
    class CSharp_Chpt_2
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine(count);
            Console.WriteLine(++count);
            Console.WriteLine(count);
            Console.WriteLine(count++);
            Console.WriteLine(count);

            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);

            double c = 10;
            double d = 3;
            Console.WriteLine(c / d);

            double e = (double)a / (double)b;
            Console.WriteLine(e);


            double priceA = 3.4052;
            double priceB = 12554.99;

            Console.WriteLine("{0:C}", priceA);
            Console.WriteLine("{0,30}", priceA);
            Console.WriteLine("{0,40:##,###.##}", priceB);
            Console.WriteLine("{0:C3}", priceA + priceB);

            //Chapter 2 Problems

            //Problem 2
            Console.WriteLine("\nChapter 2 Problem 2");
            Console.WriteLine("How many miles covert into feet and kilometers?");
            string input = Console.ReadLine();
            double Miles = double.Parse(input);
            double Feet = 5280 / Miles;
            double Kilometers = Miles * 1.60954;
            Console.WriteLine("Feet       = {0}", Feet);
            Console.WriteLine("Kilometers = {0}", Kilometers);

            //Problem 3
            Console.WriteLine("\nChapter 2 Problem 3");
            Console.WriteLine("Please Enter 5 Exam Scores");
            input = Console.ReadLine();
            double exam1 = double.Parse(input);
            input = Console.ReadLine();
            double exam2 = double.Parse(input);
            input = Console.ReadLine();
            double exam3 = double.Parse(input);
            input = Console.ReadLine();
            double exam4 = double.Parse(input);
            input = Console.ReadLine();
            double exam5 = double.Parse(input);
            Console.WriteLine("Score 1 = {0:p} \nScore 2 = {1:p} \nScore 3 = {2:p} \nScore 4 = {3:p} \nScore 5 = {4:p}", exam1, exam2, exam3, exam4, exam5);
            double Exam_Average = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;
            Console.WriteLine("Exam Average = {0:p}", Exam_Average);

            //Problem 4
            Console.WriteLine("\nChatper 2 Problem 4");
            Console.WriteLine("Please Enter Total Amount to Convert");
            input = Console.ReadLine();
            int Change = int.Parse(input);
            int Quarters = Change / 25;
            Console.WriteLine("Total Quarters = {0}",Quarters);
            int Dimes = (Change - (Quarters * 25)) / 10;
            Console.WriteLine("Total Dimes = {0}", Dimes);
            int Nickels = (Change - ((Quarters * 25) + (Dimes * 10))) / 5;
            Console.WriteLine("Totla Nickles = {0}", Nickels);
            int Pennies = (Change - ((Quarters * 25) + (Dimes * 10) + (Nickels * 5))) / 1;
            Console.WriteLine("Total Pennies = {0}", Pennies);
            Console.WriteLine("Total Change = {0:c}", Change/100.0);

            //Problem 7
            Console.WriteLine("\nChapter 2 Problem 7");
            Console.WriteLine("Please Enter Bill Amount");
            input = Console.ReadLine();
            double Bill = double.Parse(input);
            double Tip15 = Bill * .15;
            double Tip20 = Bill * .2;
            Console.WriteLine("\nBill Before Tip = {0:C}", Bill);
            Console.WriteLine("\nTip 15% = {0:c}", Tip15);
            Console.WriteLine("\nBill With 15% Tip = {0:c}", Bill + Tip15);
            Console.WriteLine("\nTip 20% = {0:c}", Tip20);
            Console.WriteLine("\nBill with 20% Tip = {0:c}", Bill + Tip20);


            Console.ReadKey();





        } 

    }
}
