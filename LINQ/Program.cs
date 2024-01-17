
List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Mahdi Gholami Pak", Salary = 50000, Department = "IT" },
    new Employee { Id = 2, Name = "Kaveh Ahangar", Salary = 65000, Department = "Marketing" },
    new Employee { Id = 2, Name = "Amin Ghesmati", Salary = 60000, Department = "HR" },
};

var highSalaryEmployees = employees.Where(e => e.Salary > 55000);
var hrDepartmentEmployees = employees.Where(e => e.Department == "HR");
var sortedBySalary = employees.OrderByDescending(e => e.Salary);
var averageSalary = employees.Average(e => e.Salary);

// Display results
Console.WriteLine("High Salary Employees:");
foreach (var employee in highSalaryEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Salary}");
}

Console.WriteLine("\nHR Department Employees:");
foreach (var employee in hrDepartmentEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Department}");
}

Console.WriteLine("\nEmployees Sorted by Salary:");
foreach (var employee in sortedBySalary)
{
    Console.WriteLine($"{employee.Name} - {employee.Salary}");
}

Console.WriteLine($"\nAverage Salary: {averageSalary}");

// Example: Prompt user for a department and display employees in that department
Console.WriteLine();
Console.Write("Enter department name: ");
string userDepartment = Console.ReadLine();
var employeesInUserDepartment = employees.Where(e => e.Department.Equals(userDepartment, StringComparison.OrdinalIgnoreCase));
foreach (var employee in employeesInUserDepartment)
{
    Console.WriteLine($"{employee.Name} - {employee.Department}");
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

