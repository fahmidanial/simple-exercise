using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Employee
{
    public string EmployeeName { get; set; }
    public string ID { get; set; }
    public double Salary { get; set; }
    public string DateJoined { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> empList = new List<Employee>();

        string path = @"C:\temp\Employee.csv";

        // Read data from Employee.csv and populate empList
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            bool firstLine = true; // Add this flag to skip the first line
            while ((line = reader.ReadLine()) != null)
            {
                if (firstLine)
                {
                    firstLine = false; // Skip the first line (header)
                    continue;
                }

                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    Employee employee = new Employee
                    {
                        EmployeeName = parts[0],
                        ID = parts[1],
                        // Safely parse Salary as a double
                        Salary = double.TryParse(parts[2], out double salary) ? salary : 0.0,
                        DateJoined = parts[3]
                    };
                    empList.Add(employee);
                }
            }
        }

        // Sort employees by name in ascending order
        var sortedByName = empList.OrderBy(e => e.EmployeeName).ToList();

        // Filter employees who joined before 2003
        var joinedBefore2003 = empList
            .Where(e => int.TryParse(e.DateJoined.Substring(e.DateJoined.LastIndexOf("/") + 1), out int year) && year < 2003)
            .ToList();

        // Filter employees with a salary above 5000.00
        var highSalaryEmployees = empList
            .Where(e => e.Salary > 5000.00)
            .ToList();

        // Display the sorted list by name
        Console.WriteLine("Employees sorted by name (ascending):");
        foreach (var employee in sortedByName)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }

        // Display employees who joined before 2003
        Console.WriteLine("\nEmployees who joined before 2003:");
        foreach (var employee in joinedBefore2003)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }

        // Display employees with high salary
        Console.WriteLine("\nEmployees with a salary above 5000.00:");
        foreach (var employee in highSalaryEmployees)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }
    }
}
