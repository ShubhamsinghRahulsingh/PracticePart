using System;
namespace Practice1
{
    public class EmpPractice
    {
        const int WAGE_PER_HR = 20;
        Random random = new Random();
        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void EmpWage()
        {
            int empCheck = random.Next(0, 2);
            int empHrs = 0, dailyWage = 0;
            if (empCheck == 0)
                empHrs = 8;
            else
                empHrs = 0;
            dailyWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is:{0}",dailyWage);

        }
    }
}
