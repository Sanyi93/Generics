// See https://aka.ms/new-console-template for more information
using LinqTraining.cs;

Console.WriteLine("Hello, World!");


Employee[] employeeArray =
           {
                new Employee { EmployeeId = 1, EmployeeName = "Peter", Salary = 1000 },
                new Employee { EmployeeId = 2, EmployeeName = "Julius", Salary = 1200 },
                new Employee { EmployeeId = 3, EmployeeName = "Martin", Salary = 1300 },
                new Employee { EmployeeId = 4, EmployeeName = "Eva", Salary = 1400 },
                new Employee { EmployeeId = 5, EmployeeName = "Ema", Salary = 1100 },
                new Employee { EmployeeId = 6, EmployeeName = "Franz", Salary = 1700 },
                new Employee { EmployeeId = 7, EmployeeName = "Julia", Salary = 1400 },
                new Employee { EmployeeId = 8, EmployeeName = "Hans", Salary = 1200 }
            };

//using LINQ to find employees with a salary lower than 1400
Employee[] employeesWithSalaryUnder1400 = employeeArray.Where(s => s.Salary < 1400).ToArray();
foreach (Employee employee in employeesWithSalaryUnder1400)
{
    Console.WriteLine(employee.EmployeeName);
}

//using LINQ to find the first employee whose name is Franz
Employee[] employeeNameIsFranz = employeeArray.Where(s => s.EmployeeName == "Franz").ToArray();
foreach (Employee employee in employeeNameIsFranz)
{
    Console.WriteLine(employee.EmployeeName);
}

//using LINQ to find the employee with id = 6
Employee[] employeeWithId5 = employeeArray.Where(s => s.EmployeeId == 5).ToArray();
foreach (Employee employee in employeeWithId5)
{
    Console.WriteLine(employee.EmployeeName);
}