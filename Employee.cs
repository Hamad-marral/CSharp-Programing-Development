using System;

public class Employee
{
   public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName );
    
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
    
}

public class partTimeEmployee : Employee
{
    public float HourlyRate;
}

public class program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();

        FTE.FirstName = "Hamd";
        FTE.LastName = "Khaliq";
        FTE.YearlySalary = 50000;
        FTE.PrintFullName();


        partTimeEmployee PTE = new partTimeEmployee();
        PTE.FirstName = "John";
        PTE.LastName = "Doe";
        PTE.HourlyRate = 20;
        PTE.PrintFullName();
    }
}