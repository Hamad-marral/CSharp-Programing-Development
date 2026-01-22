using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Your Number");
        
        // Input ko string se int mein convert karna
        int userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber == 1) // Yahan semicolon (;) nahi ayega
        {
            Console.WriteLine("userNumber is 1");
        }
        else if (userNumber == 2) // Spelling theek ki aur (;) hataya
        {
            Console.WriteLine("userNumber is 2");
        }
        else
        {
            Console.WriteLine("Your number is not between 1 and 2");
        }
    }
}