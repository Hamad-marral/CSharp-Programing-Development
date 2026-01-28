using System;

interface ICustomer1
{
    void print1();

}
interface ICustomer2
{
    void print2();

}

public class Customer : ICustomer2
{
    public void print2()
    {
        Console .WriteLine("Interface 2 method implementation");
    }

    public void print1()
    {
        Console .WriteLine("Interface 1 method implementation");
    }

 public class Program
    {
        public static void Main()
        {
            Customer c1 = new Customer();
            c1.print1();
            c1.print2();
        }
    }   
}