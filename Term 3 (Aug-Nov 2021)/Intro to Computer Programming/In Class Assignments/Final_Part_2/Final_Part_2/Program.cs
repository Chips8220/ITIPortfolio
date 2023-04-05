using System;

namespace Final_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method A
            Console.WriteLine("The Distance between X and Y pairs are : {0:n2}", MethodA(2, 3, 8, 9));

            //Method D

            Player a = new Player("Chips", 100, 30, 1);
            Console.WriteLine(a);
            a.UsePotion();
            Console.WriteLine(a);


        }
        public static double MethodA(double x1, double x2, double y1, double y2)
        {
            double Dist = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
            return Dist;
        }
         
      
        public string MethodD(int a, int b)
        {
            string multi = "";
            for (int A = 1; A <= a; A++)
            {
                for (int B = 1; B <= b; B++)
                {
                    int product = A * B;
                    Console.Write("{0,4:f0}", product);
                }
                Console.Write("\n");
            }
            return multi;
        }

       

    }

}
