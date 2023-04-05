using System;

namespace Page_195_Page196
{
    class Program
    {
        static void Main(string[] args)
        {
            method7();


        }
        public static void method4()
        {
            double Min = SecConvertMin(60);
            Console.WriteLine($"\nThe amount of seconds converted to minuites is :{Min}");
            double Hrs = SecConvertHrs(3600);
            Console.WriteLine($"The amount of seconds converted to hrs is :{Hrs}");
        }

        public static double SecConvertMin(double sec)
        {
            double Min = sec / 60;
            return Min;
        }
        public static double SecConvertHrs(double sec)
        {
            double Hrs = SecConvertMin(sec) / 60;
            return Hrs;
        }
        public static void method5()
        {
            string input = Console.ReadLine();
            double temp = double.Parse(input);
            double Cels = FarConvert(temp);
            Console.WriteLine($"\nThe Farhienheit tempurature to Celsius is {Cels:n1}° C");
        }
        public static double FarConvert(double Farh)
        {
            double Cels = (Farh-32)*(5 / 9);
            
            return Cels;

        }
        public static void method7()
        {
            Console.WriteLine("How much is the bill?");
            // Bill Amount
            string input = Console.ReadLine();
            double bill = double.Parse(input);
            // 9% Tax
            double taxedBill = bill + calcPercentage(.09, bill);
            //Calc possible Tips
            double Tip10 = calcPercentage(0.1, taxedBill);
            double Tip15 = calcPercentage(0.15, taxedBill);
            double Tip20 = calcPercentage(0.2, taxedBill);

            Console.WriteLine($"Subtotal {taxedBill:c2}");
            Console.WriteLine($"\tWith 10%: {Tip10:c2} = {(taxedBill + Tip10):c2}");
            Console.WriteLine($"\tWith 15%: {Tip15:c2} = {(taxedBill + Tip15):c2}");
            Console.WriteLine($"\tWith 20%: {Tip20:c2} = {(taxedBill + Tip20):c2}");



        }
        public static double calcPercentage(double peramt, double totalamount)
        {
            return peramt * totalamount;
        }


















    }
}
