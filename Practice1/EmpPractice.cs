﻿using System;
namespace Practice1
{
    public class EmpPractice
    {
        const int WAGE_PER_HR = 20;
        int IS_FULL_TIME = 1, IS_PART_TIME = 2;
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
    }
}
