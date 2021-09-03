using System;

namespace Emp_Wages_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages using Switch-Case Day-3");
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 3);
            int oneDay_Sal = 0, full_Time = 8, perHour_Pay = 20, part_Time = 4, total_Sal = 0, days = 20;
            switch (empcheck)
            {
                case 1:
                    Console.WriteLine("It's Work-Type is : Full-Time");
                    oneDay_Sal = full_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                case 2:
                    Console.WriteLine("It's Work-Type is : Part-Time");
                    oneDay_Sal = part_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                default:
                    Console.WriteLine(" Wrong Input :)");
                    break;
            }
            total_Sal = oneDay_Sal * days;
            Console.WriteLine("Total Work-Days Salary is : {0}", total_Sal);
        }
    }
}
