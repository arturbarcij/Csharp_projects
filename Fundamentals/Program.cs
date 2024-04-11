// See https://aka.ms/new-console-template for more information
using System;
namespace Fundamentals;
public class Program {

        public static void Main() {
        
        //OBJECT DECLARATION
        Fundamentals fund1 = new Fundamentals("fund1");

        //CALLING METHODS
        Console.WriteLine("-----------------------------");
        Console.WriteLine("CountBackwards from 10 to 1: ");
        fund1.CountBackwards(fund1);
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Reversed string 'stressd :(' ");
        fund1.ReverseString(fund1, "stressed :(");
        Console.WriteLine("");
        Console.WriteLine("-----------------------------");
        Console.Write("GCD(13,37) = ");
        fund1.GCD(fund1, 13, 37);
        Console.WriteLine("");    
        Console.Write("GCD(-99.4, 345) = ");
        fund1.GCD(fund1, -99, 4345);
        Console.WriteLine("");


        //TIME COMPLEXITY
        /*
        ReverseString(): O(n^2) substr O(n) of str(n), same like nested for loop
        */


        


    }
}
