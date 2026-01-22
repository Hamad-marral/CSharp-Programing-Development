using System;
namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            manager.AddStudent();
        }
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
class StudentManager
{
    List<Student> students = new List<Student>();

    public void AddStudent()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        students.Add(new Student(id, name, age));
        Console.WriteLine("Student Added Successfully!");
    }
}
