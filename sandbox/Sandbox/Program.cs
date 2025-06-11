using System;
using employee_demo;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdnumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SethourlyWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdnumber("456def");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }
    }
    public static void DisplayEmployeeInformation(Employee employee)
    {
        float pay = employee.GetPay();

        Console.WriteLine($"{employee.GetName()} will be paid ${pay}.");
    }
}