using System;

class Program
{
    static void Main(string[] args)
    {
       HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("john");
        hEmployee.SetIdNumber("2022");
        hEmployee.SetPayRate(25);
        hEmployee.SetHoursWorked(60);

       SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("peter");
        sEmployee.SetIdNumber("1995");
        sEmployee.SetSalary(75000);

        DisplayEmployInfo(hEmployee);
        DisplayEmployInfo(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.GetName());
            Console.WriteLine(employee.GetIdNumber());
            Console.WriteLine(employee.GetPay());
        }

    }

    public static void DisplayEmployInfo(Employee employee)
    {
        

        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }
}