using System;
class Task5
{
    static void Main()
    {
        Console.WriteLine("n =");int n = int.Parse(Console.ReadLine());
        Console.WriteLine("m =");int m = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Task5.MultTab(n, m);
    }
    static void MultTab(int n, int m)
    {
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
