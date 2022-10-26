using System;
using System.Security.Cryptography.X509Certificates;

namespace Practice1
{
    public class EmpPractice
    {
        const int WAGE_PER_HR = 20;
        int IS_FULL_TIME = 1, IS_PART_TIME = 2,Total_Working_Days = 1;
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
            int empCheck = random.Next(0, 3);
            int empHrs = 0, dailyWage = 0;
            if (empCheck == 1)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present for full day");
            }
            else if (empCheck == 2)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present for Half day");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            dailyWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is " + dailyWage);
        }

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
            public void Month()
            {
            int i, totalWage = 0, dailyWage = 0, empHrs = 0;
                for (i = 1; i <=Total_Working_Days; i++)
                {
                    int empCheck = random.Next(0, 3);
                    if (empCheck == 1)
                    {
                        empHrs = 8;
                    }
                    else if (empCheck == 2)
                    {
                        empHrs = 4;
                    }
                    else
                    {
                        empHrs = 0;
                    }
                    dailyWage = empHrs * WAGE_PER_HR;
                    totalWage = totalWage + dailyWage;
                }
                Console.WriteLine("Monthly wage of an employee is: " + totalWage);

            }
        public void Condition()
        {
            int Total_Working_Hours = 0, empHrs = 0, TotalWage = 0;
            while(Total_Working_Hours<=100 && Total_Working_Days<20)
            {
               int empCheck= random.Next(0, 3);
                if(empCheck == 1)
                {
                    empHrs = 8;
                }
                else if(empCheck == 2)
                {
                    empHrs=4;
                }
                else
                {
                    empHrs = 0;
                }
                Total_Working_Hours=Total_Working_Hours + empHrs;
                Total_Working_Days = Total_Working_Days + 1;
                if(Total_Working_Hours>100)
                {
                    Total_Working_Hours = Total_Working_Hours - empHrs;
                }
            }
            TotalWage = Total_Working_Hours * WAGE_PER_HR;
            Console.WriteLine("Total Working Hours: "+ Total_Working_Hours);
            Console.WriteLine("Total Working Days: "+ Total_Working_Days);
            Console.WriteLine("Monthly wage of an employee is:"+ TotalWage);
        }
    }
}