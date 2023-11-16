using System;

class Program
{
    
    static int mult(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        
        int result = mult(100, 200);

        
        Console.WriteLine($"Result: {result}");
    }
}
