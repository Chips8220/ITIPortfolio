using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPractice
{
    class Trip
    {
        string Dest;
        double Dist, GasCost, AmtGas;

        public Trip(string dest,double dist, double gascost, double TotGas)
        {
            Dest = dest;
            Dist = dist;
            GasCost = gascost* TotGas;
            AmtGas = TotGas;

        }
        public static double MpG(double m , double g)
        {
            double mpg = m / g;
            return mpg;
        }
        public static double CpM(double c, double m)
        {
            double cpm = c / m;
            return cpm;
        }

        public override string ToString()
        {
            return "The Trip to "  +Dest+  " from ITI was"  + String.Format("{0,5:f2} ",MpG(Dist, AmtGas))+  "miles per gallon and" + String.Format("{0,5:f2} ", CpM(GasCost, Dist))+  "cost per mile.";
        }
    }
}
