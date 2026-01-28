namespace MyApp;

public class Student
{
    private int _id;
    private string _name;
    private readonly int _passMark = 35;



    public int PassMark
    {
        get
        {
            
        
        return _passMark;
    }
    }


    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student name cannot be null or empty");    
            }
            _name = value;
        }
        get
        {
            return string.IsNullOrEmpty(_name) ? "No Name" : _name;
        }
    }
    public   int ID
    {
        set{
        if (value <= 0)
        {
            throw new Exception("Student ID cannot be less than or equal to zero"); 

        }
        _id = value;
    }
        get
        {
            return _id;
        }
    }
     

    public class Program
    {
        public static void Main()
        {
            Student c1 = new();
            c1.ID = 101;
            c1.Name = "Hamad Khaliq";
            Console.WriteLine("Student Name: " + c1.Name);
            Console.WriteLine("Student ID: " + c1.ID);
            Console.WriteLine("Student Pass Mark: " + c1.PassMark);
        }
    }
    

}