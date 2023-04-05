using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPractice
{
    class Money
    {
        private int Dollars, Cents;

        public Money()
        {

        }


        public Money(int d, int c)
        {
            Dollars = d;
            Cents = c;
        }
        public Money(double amount)
        {
            Dollars = (int) amount;
            Cents = (int)((amount-Dollars) * 100);
        }

        public void Incrementmoney()
        {
            Dollars++;
            Cents++;
        }
        public void Decrementmoney()
        {
            Dollars--;
            Cents--;
        }
        public string ToDenom()
        {
            string s = "";
            s = s + Dollars + "dollars";
            s = s + (Cents / 25) + "quarter";
            s = s + ((Cents % 25)/10) + "dimes";
            s = s + (((Cents % 25)%10)/5) + "nickles";
            s = s + (((Cents % 25)%10)%5) + "nickles";
           
            return s;
        }

        public override string ToString()
        {
            double ret = Dollars + (Cents / 100.0);
            return string.Format("{0,6:c2}", ret);
        }









    }
}
