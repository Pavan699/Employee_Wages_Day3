using System;

namespace Emp_Wages_Day3
{
    class Program
    {
        //creating two methods For Dry Principle(To avoid the Repetation of Code)
        public void print(int oneDay_Sal,int days)
        {
            int total_Sal = 0;
            total_Sal = oneDay_Sal * days;
            Console.WriteLine("Total Work-Days Salary is : {0}", total_Sal);
        }
        //Logic for the UC6
        public void hours(int work_Hours, int days)
        {
            if (work_Hours > 100 || days >= 20)
            {
                Console.WriteLine("Employee Performance is Excellent!");
                Console.WriteLine("And its Working hours are {0} And Work Days are {1}", work_Hours, days);
            }
            else
            {
                Console.WriteLine("Empolyee Performance is Good. But need to Improve.....");
                Console.WriteLine("BCoz, Working Hours Are less than 100 ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages using Switch-Case Day-3");
            //Creating Random Veriable
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 3);
            //Declaring the Variables
            int oneDay_Sal = 0, full_Time = 8, perHour_Pay = 20, part_Time = 4,  days = 20, total_WorkHour = 0;
            Program p = new Program();//creating object for the class
            switch (empcheck)
            {
                //logic for the full-time Employee
                case 1: 
                    Console.WriteLine("It's Work-Type is : Full-Time");
                    oneDay_Sal = full_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    total_WorkHour = full_Time * days;
                    p.print(oneDay_Sal, days);//calling methods with help of class object 
                    p.hours(total_WorkHour, days);
                    break;
                //logic for the part-time Employee
                case 2:
                    Console.WriteLine("It's Work-Type is : Part-Time");
                    oneDay_Sal = part_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    total_WorkHour = part_Time * days;
                    p.print(oneDay_Sal, days);//calling methods with help of class object
                    p.hours(total_WorkHour, days);
                    break;
                //When Employee is Absent
                default:
                    Console.WriteLine(" Wrong Input :)");
                    break;
            }
                    
        }
    }
}
