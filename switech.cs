using System;

namespace switech
{
    public class switech
    {
        static void Main()
        {
            int TotalCoffeCost = 0; // Ye variable loop se bahar hai, isliye price save rahay gi

        start:
            Console.WriteLine("Enter Coffee Size: 1.Small (50) 2.Medium (100) 3.Large (150)");
            string choiceInput = Console.ReadLine();
            int UserChoice;

            // Check kar rha hai ke input number hai ya nahi
            if (int.TryParse(choiceInput, out UserChoice))
            {
                switch (UserChoice)
                {
                    case 1:
                        TotalCoffeCost += 50; // Purani price mein 50 jama ho raha hai
                        break;
                    case 2:
                        TotalCoffeCost += 100;
                        break;
                    case 3:
                        TotalCoffeCost += 150;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice: {0}", UserChoice);
                        goto start;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number (1, 2, or 3)");
                goto start;
            }

        Decide:
            Console.WriteLine("Do you want to order more Coffee? (Yes/No)");
            string UserDecision = Console.ReadLine();

            // FIXED: .ToUpper() use kiya hai to case "YES" hona chahiye
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto start; // Dobara start par jayega aur purani price mein add karega
                case "NO":
                    break; // Loop khatam
                default:
                    Console.WriteLine("Your choice '{0}' is invalid, please try again", UserDecision);
                    goto Decide;
            }

            Console.WriteLine("THANK YOU FOR ORDERING!");       
            Console.WriteLine("Your Final Bill: {0} PKR", TotalCoffeCost);
            Console.WriteLine("-------------------------------");
        }
    }
}