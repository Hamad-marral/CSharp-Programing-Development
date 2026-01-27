using PATA = ProjectA.TeamA;


class Program
{
    public static void Main()
    {
     
        PATA.ClassA.Print();
     

    }
}

    namespace ProjectA
    {
        namespace TeamA
        {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Class A from Project A");
            }
        }
        }


    namespace ProjectA
    {
        namespace TeamB
        {
        public class ClassA
        {
            public static void Print() 
            {
                Console.WriteLine("This is Class B from Project A");
            }
        }
    }
    
}  
    }
    


