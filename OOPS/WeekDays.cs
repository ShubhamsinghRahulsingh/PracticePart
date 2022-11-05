using System;
namespace OOPS
{
    public class WeekDays
    {
        public static void DayWeek()
        {
            Console.WriteLine("Welcome to the Gregorian Calendar");
            Console.WriteLine("1-January,2-february,3-march,4-april,5-may,6-june,7-july,8-august,9-september,10-october,11-november,12-december");
            Console.WriteLine("Enter the month ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of the month");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("On this date it was Sunday");
                    break;
                case 1:
                    Console.WriteLine("On this date it was Monday");
                    break;
                case 2:
                    Console.WriteLine("On this date it was Tuesday");
                    break;
                case 3:
                    Console.WriteLine("On this date it was Wednesday");
                    break;
                case 4:
                    Console.WriteLine("On this date it was Thursday");
                    break;
                case 5:
                    Console.WriteLine("On this date it was Friday");
                    break;
                case 6:
                    Console.WriteLine("On this date it was Saturday");
                    break;
            }
        }
    }
}
