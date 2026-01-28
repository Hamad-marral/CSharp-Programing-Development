using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;



    public int GetpassMark()
    {
        return _passMark;
    }


    public void SetName(string Name)

    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student name cannot be null or empty");    

        }
        this ._name = Name;
        
        
    }
    public string GetName()
    {
        return string .IsNullOrEmpty(_name) ? "No Name" : _name;    

    }

    public void SetID( int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID cannot be less than or equal to zero"); 

        }
        this._id = Id;
    }
        public int GetID()
        {
            return _id;
        }

    public class program
    {
        public static void Main()
        {
            Student c1 = new Student();
            c1.SetID(101);
            c1.SetName("Hamad Khaliq");
            c1.GetpassMark();
            Console.WriteLine("Student Name: " + c1.GetName());
            Console.WriteLine("Student ID: " + c1.GetID());
            Console.WriteLine("Student Pass Mark: " + c1.GetpassMark());
        }
    }
    

}