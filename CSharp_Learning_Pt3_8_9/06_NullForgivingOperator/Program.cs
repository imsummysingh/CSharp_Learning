//Null Forgiving Operator Example

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
        EmployeeBusinessLogic ebl = new EmployeeBusinessLogic();
        Employee? emp = ebl.GetEmployee();

        bool isValid = emp == null;
        if (isValid)
        {
            Console.WriteLine("Value is null");            
        }
        else
        {
            Console.WriteLine(emp!.x);       //null forgiving operator in use
        }

    }
}

//Employee = non-nullable(null values are not accepted)
//Employee?= nullable(null values are accepted)