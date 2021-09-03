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
            if (empcheck == 1)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }
        }
    }
}
