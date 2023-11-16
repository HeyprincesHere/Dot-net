using System;

class Program
{
    static void Main()
    {
        String[] months = { "jan", "feb", "Mar" };
        int[,] sales = new int[3, 3];
        for (int i = 0; i < sales.GetLength(0); i++)
        {
            Console.WriteLine($"enter sales for salesMan-{i + 1}:");
            for (int j = 0; j < sales.GetLength(1); j++)
            {
                Console.Write($"enter sales for {months[j]}:");
                sales[i, j] = int.Parse(Console.ReadLine());

            }
        }
        for (int i = 0; i < sales.GetLength(0); i++)
        {
            Console.WriteLine($"salesMan-{i + 1}\t");
            int tot = 0;
            for (int j = 0; j < sales.GetLength(1); j++)
            {
                Console.Write($"{sales[i, j]}\t");
                tot += sales[i, j];


            }
            Console.WriteLine(tot);
        }
    }

}