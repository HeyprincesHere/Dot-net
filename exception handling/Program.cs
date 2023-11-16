using System;

class Program
{
    static void Main()
    {
        try
        {
            // Example 1: Divide by zero exception
            int result = Divide(10, 0);
            Console.WriteLine($"Result: {result}"); // This line won't be executed

            // Example 2: Format exception
            int number = ParseNumber("abc");
            Console.WriteLine($"Parsed Number: {number}"); // This line won't be executed
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format error: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Generic catch block for any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }

    static int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return dividend / divisor;
    }

    static int ParseNumber(string input)
    {
        return int.Parse(input); // This may throw a FormatException
    }
}
