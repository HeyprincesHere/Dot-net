using System;
class ReverseExample
{
    static void Main()
    {
        int n, reverse = 0, rem;
        Console.WriteLine("eneter a number");
        n = int .Parse(Console.ReadLine());
        while (n!=0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;

        }
        Console.WriteLine("reverse number is :" + reverse);


    }
}

