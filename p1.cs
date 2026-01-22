using System;

namespace StudentSystem
{
    // 1. Blueprint (Class) banana
    public class Student 
    {
        // Data Variables (Fields)
        public string Name;
        public int Marks;
        public int Age; // Naya variable jo humne add kiya

        // 2. Constructor (Setup phase)
        // Jab bhi 'new Student()' likhenge, ye hissa chalega
        public Student(string name, int marks, int age) 
        {
            Name = name;
            Marks = marks;
            Age = age;
            Console.WriteLine(Name + " ka account create ho gaya!");
        }

        // 3. Ek simple function (Method)
        public void DisplayInfo() 
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Marks: " + Marks);
            
            if (Marks >= 50)
                Console.WriteLine("Status: Pass");
            else
                Console.WriteLine("Status: Fail");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            // Object 1 banana
            Student s1 = new Student("Hamad", 85, 22);
            s1.DisplayInfo();

            // Object 2 banana
            Student s2 = new Student("Talha", 45, 21);
            s2.DisplayInfo();

            // Program ko furan band hone se rokne ke liye
            Console.ReadLine();
        }
    }
}