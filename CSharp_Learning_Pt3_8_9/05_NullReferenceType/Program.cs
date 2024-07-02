//Null Reference Type Example - C#9.0

using System.Reflection.Metadata.Ecma335;

class Employee
{
    public int x { get; set; }
}
class EmployeeBusinessLogic
{
    public Employee? GetEmployee()      //it can accept null value
    {
        //return new Employee() { x = 10 };
        return null;
    }
}
class Program
{
    static void Main()
    {
        //Employee employee = new Employee() { x = 10 };
        //Console.WriteLine(employee.x);

        EmployeeBusinessLogic ebl = new EmployeeBusinessLogic();
        Employee? emp = ebl.GetEmployee();
        if (emp != null)
        {
            Console.WriteLine(emp.x);
        }
        else
        {
            Console.WriteLine("Value is null");
        }       

    }
}

//Employee = non-nullable(null values are not accepted)
//Employee?= nullable(null values are accepted)