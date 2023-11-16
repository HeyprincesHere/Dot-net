using System;

public class MyCustomException : Exception
{
    public MyCustomException()
    {
    }
    public MyCustomException(string message)
        : base(message)
    {

    }
    public MyCustomException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}

public class CustomExceptionDemo
{
    public void DoSomething()
    {
        // Simulate an error
        throw new MyCustomException("Something went wrong in DoSomething()");
    }

    public static void Main()
    {
        try
        {
            CustomExceptionDemo demo = new CustomExceptionDemo();
            demo.DoSomething();
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception caught: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }
}


