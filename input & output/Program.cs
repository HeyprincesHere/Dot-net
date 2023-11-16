using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
 
        
        Console.WriteLine($"Hello, {name}!");

        
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        
        int doubledNumber = number * 2;
        Console.WriteLine($"Twice the number you entered is: {doubledNumber}");
    }
}
