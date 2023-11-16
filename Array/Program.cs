using System;

class Example
{
    static void Main()
    {
        string[] chockii = { "dairymilk", "luvit", "kitkat", "candy" };

        
        chockii[1] = "center fresh";

        
        foreach(string chocolate in chockii)
        {
            Console.WriteLine(chocolate);
        }
    }
}
