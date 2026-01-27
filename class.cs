using System;
 
  class Customer
{
    string _firstName;
    string _lastName;


 public Customer(string firstName, string lastName)
{
    this ._firstName = firstName;
    this ._lastName = lastName;

}


public void PrintFullName()
{
    Console.WriteLine("Customer Full Name: {0} {1}", this._firstName, this._lastName);
}


 ~Customer()
 {
    
}
}
 class Program
{
    public static void Main()
    {
        Customer cust = new Customer("John", "Doe");
        cust.PrintFullName();
    }   
}