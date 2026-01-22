using System;

class Program
{
    static void Main()
    {
        string strNumber = "12345hd";
        int resullt;
        bool isConversionSuccessful = Int32.TryParse(strNumber, out resullt);

        if (isConversionSuccessful)
        {
            Console.WriteLine("Conversion successful! The number is: " + resullt);
        }
        else
        {
            Console.WriteLine("Please Entre a Vaild Number.");
        }
    }
     
}