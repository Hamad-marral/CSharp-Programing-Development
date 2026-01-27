namespace Polymorphism
{
    public class Employee
{
   public string FirstName="FN";
    public string LastName="LN";


    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName );
    
    }
}


public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time Employee");
    }
}
    


public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time Employee");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Temporary Employee");
    }
}

public class Program
{
public static void Main()
{
    Employee[] employees = new[]
    {
        new Employee(),
        new FullTimeEmployee(),
        new PartTimeEmployee(),
        new TemporaryEmployee()
    };



        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}
}