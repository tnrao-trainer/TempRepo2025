using System;
 
namespace ConsoleApp21
{

    // Abstract Employee class
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        // Abstract method to calculate salary (must be implemented in derived classes)
        public abstract double CalculateSalary();

        // Concrete method to display employee details
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Salary: INR.{CalculateSalary()}");
        }
    }

    // Full-time Employee class
    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(int id, string name, double salary)
        {
            EmployeeId = id;
            Name = name;
            MonthlySalary = salary;
        }

        // Implementing abstract method
        public override double CalculateSalary()
        {
            return MonthlySalary; // Fixed monthly salary
        }
    }

    // Part-time Employee class
    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, double rate, int hours)
        {
            EmployeeId = id;
            Name = name;
            HourlyRate = rate;
            HoursWorked = hours;
        }

        // Implementing abstract method
        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked; // Salary based on hours worked
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating Full-time employee
            Employee emp1 = new FullTimeEmployee(101, "Scott", 50000);

            // Creating Part-time employee
            Employee emp2 = new PartTimeEmployee(102, "Smith", 500, 120); // 2000 per hour, 80 hours worked

            // Display employee details
            emp1.DisplayEmployee();
            emp2.DisplayEmployee();
        }
    }



}
