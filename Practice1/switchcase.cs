using System;

namespace Practice1
{
    public class switchcase
    {
        const int WAGE_PER_HR = 20;
        Random random = new Random();
        public void SwitchCase()
        {
            int dailyWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    dailyWage = empHrs * WAGE_PER_HR;
                    Console.WriteLine("Daily wage of full time employee is: {0}", dailyWage);
                    break;
                case 2:
                    empHrs = 4;
                    dailyWage = empHrs * WAGE_PER_HR;
                    Console.WriteLine("Daily wage of part time employee is: {0}", dailyWage);
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;

            }
        }
    }
}
