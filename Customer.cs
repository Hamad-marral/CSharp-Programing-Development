using System;

public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }

}

public class Program
{
          public static void Main()
    {
        int i = 10;
        int j = 20;
        j = j +1 ;

        Console.WriteLine("i ={0} && j={1} ", i, j);
        Customer c1 = new Customer();
        c1.CustomerID = 101;
        c1.CustomerName = "Hamad Khaliq";


        Customer c2 = c1;

        c2.CustomerName= "maddy";
         Console.WriteLine("c1 Name ={0} && c2 Name={1} ", c1.CustomerName, c2.CustomerName);
    }
}