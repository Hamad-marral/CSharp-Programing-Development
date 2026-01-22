using System;
namespace myapplication{

public class Vehicle
{
    public string Brand;
    public int speed;

    public void Drive()
    {
        Console.WriteLine(Brand + "is moving at " + speed + "km/h");  
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int speed, int doors) : base()
    {
        Brand = brand;
        this.speed = speed;
        NumberOfDoors = doors;
    }

    public void OpenTrunk()
    {
        Console.WriteLine(Brand + " trunk is open.");
    }
}

public class Bike : Vehicle
{
    public bool HasSidecar;

    public Bike(string brand, int speed, bool sidecar) : base()
    {
        Brand = brand;
        this.speed = speed;
        HasSidecar = sidecar;
    }

    public void Kickstart()
    {
        Console.WriteLine(Brand + " bike is kickstarted.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 120, 4);
        myCar.Drive();
        myCar.OpenTrunk();

        Console.WriteLine();

        Bike myBike = new Bike("Harley Davidson", 80, true);
        myBike.Drive();
        myBike.Kickstart();
        Console.ReadLine();
    }
}
}