using System;

namespace DayThreeEmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int empWage, empHrs;

            if (empCheck == IS_PRESENT)
            {
                empHrs = 8;
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