using System;
namespace myapplication
{
    class Car
    {
        string name="Ford";
        string color="Black";
        public void FullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");

    }
     
     static  void Main (string [] args)
        {
            Car myobjt= new Car();
            myobjt.FullThrottle();

        }
        }
    
    
}