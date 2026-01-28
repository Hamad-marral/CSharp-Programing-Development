using System;
using System.ComponentModel;

public class Program
{
    public static void Main()
{
    
}

 public static void Add(int FN, int SN, int TN)
{
    Console.WriteLine("sum = {0} " + (FN + SN + TN ));  

}

public static  int  Add(int FN, int SN, out int TN)
{
    Console.WriteLine("sum = {0} " + (FN + SN+ TN ));   
    return FN + SN + TN;

} 
}