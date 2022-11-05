using System;
using System.Reflection.Metadata;

namespace OOPS
{
    public class MonthlyPay
    {
       public static void MonthlyPayment(int P, int R, int Y)
        {
            float r =(float)R / (12 * 100);
            int n = 12 * Y;
            double payment =P * r / 1 - (Math.Pow((1 + r), -n));
            Console.WriteLine(payment);
        }
    }
}
