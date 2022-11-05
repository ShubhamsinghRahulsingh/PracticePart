using System;
using OOPS;
namespace Practice1
{
    class Program
    {
         public static void Main(string[] args)
        {
           // MonthlyPay.MonthlyPayment(100000, 20, 2);
           // CouponNumber.GenerateCoupons(10);
           // WeekDays.DayWeek();
           // Tempconv.CelsToFahr(100);
           // Tempconv.FahrToCels(212);
              VendingMachine machine = new VendingMachine();
              machine.Change(5700);
         }
    }
}