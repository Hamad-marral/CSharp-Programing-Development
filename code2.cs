using System;
namespace myapplication
{
    class Car
 {
     string color;
     string name;
     int year;

     static void Main (string [] args)
     {
        Car BMW = new Car ();
        BMW.color="Black";
        BMW.name="BMW X5";
        BMW.year=2020;

        Car Audi = new Car ();
        Audi.color="White";
        Audi.name="Audi A6";
        Audi.year=2019;

        Car Tesla = new Car (); 
        Tesla.color="Red";
        Tesla.name="Tesla Model S";
        Tesla.year=2021;


      Console.WriteLine("Car 1: " + BMW.name  + BMW.year);
      Console.WriteLine("Car 2: " + Audi.name + ", Color: " + Audi.color + ", Year: " + Audi.year);
      Console.WriteLine(Tesla.color + ", Year: " + Tesla.year);
     
  }
 
   }
}