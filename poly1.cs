using System;
namespace myapplication
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The Animal Sound is ");
        }
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Cow : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Moo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Cow cow = new Cow();
        }
    }
}



