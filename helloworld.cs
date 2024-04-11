using System;
using System.Linq;
using System.IO;

namespace HelloWorld
{
    class Hello {         
        public static void Main()
        {
            int a = 5;
            int b = 3;
            // var listOfStrings = new List<string>();
            //if one should return array = ToArray()
            string[] names = {"Arthur","George","Thomas","Noah"};
            int[] numbers = { 1, 2, 3, 4, 5 };

            System.Console.WriteLine("Hey, how it's going");
            System.Console.WriteLine("");
            System.Console.WriteLine("Test addition: ");
            System.Console.WriteLine(a+b);
            System.Console.WriteLine("");
            System.Console.WriteLine("Length of array numbers is: ");
            System.Console.WriteLine(numbers.Length);
            System.Console.WriteLine("");
            System.Console.WriteLine("Type of array numbers is: ");
            System.Console.WriteLine(numbers);
            System.Console.WriteLine("");

            if (numbers[1] == 2) 
            {
                System.Console.WriteLine("numbers[1] is equal to: ");
                System.Console.WriteLine(numbers[1]);
            }
            
            System.Console.WriteLine("Array names is made of these four names:");
            foreach (string i in names)
            {
            System.Console.Write(i);
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Array numbers constit of: ");
            foreach (int j in numbers)
            {
            System.Console.Write(j);
            }
            System.Console.WriteLine("");
            System.Array.Reverse (numbers);
            System.Console.WriteLine("Reversed array numbers constist of: ");
            foreach (int k in numbers)
            {
            System.Console.Write(k);
            }
            System.Console.WriteLine("");

                int x = 20;
                int y = 15;
             if (x > y) 
            {
                System.Console.WriteLine("x is equal to: ");
                System.Console.WriteLine(x);
            }

            
            
            System.Array.Sort(numbers);
            foreach (int r in numbers)
            {
            System.Console.Write(r);
            }
            System.Console.WriteLine("Array numbers sorted in input manner: ");
            System.Console.WriteLine("");
        
            List<string> listOfCars = new List<string>();
            listOfCars.Add("BMW");
            listOfCars.Add("TOYOTA");
            listOfCars.Add("AUDI");
            listOfCars.Add("JEEP");
            listOfCars.Add("VOLVO");
            listOfCars.Add("");
            listOfCars.Add(null);
            Display.listOfCars;

            System.Console.WriteLine(listOfCars);
        
        
        
        }   
            
    }       
}