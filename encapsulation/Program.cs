using System;

class Person
{
    // Private fields (encapsulated)
    private string name;
    private int age;

    // Public properties to provide controlled access to private fields
    public string Name
    {
        get { return name; }
        set
        {
            // Add validation if needed
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name cannot be null or empty.");
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            // Add validation if needed
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative.");
            }
        }
    }

    // Public method (encapsulated)
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Set the properties using the property setters
        person.Name = "John Doe";
        person.Age = 25;

        // Access the properties using the property getters
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Access a method that encapsulates functionality
        person.DisplayInfo();
    }
}

//using System;

//class Example
//{
//    static void Main()
//    {
//        int x = 10;
//        int y = 200;
//        int z = x + y;
//        Console.WriteLine($"the value is :{ z}");
//    }
//}
