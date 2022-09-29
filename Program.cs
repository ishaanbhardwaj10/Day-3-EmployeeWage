using System;

namespace DayThreeEmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int empWage, empHrs;

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage for the day is: {0}", empWage);

        }
    }
}