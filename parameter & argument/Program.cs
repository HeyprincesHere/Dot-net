using System;
class Car
{
    static void car(string brand1, string brand2, string brand3 = "honda")
    {
        Console.WriteLine("my car brand is :" + brand1);
        Console.WriteLine("my car brand is :" + brand2);
        Console.WriteLine("my car brand is :" + brand3);

    }
    static void Main()
    {
        car(brand1: "volovo", brand2: "RR");

    }
}
