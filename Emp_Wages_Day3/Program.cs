using System;

namespace Emp_Wages_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages using Switch-Case Day-3");
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 2);
            int oneDay_Sal = 0, full_Time = 8, perHour_Pay = 20 ;
            if (empcheck == 1)
            {
                Console.WriteLine("It's Work-Type is : Full-Time");
                oneDay_Sal = full_Time * perHour_Pay;
                Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }
        }
    }
}
