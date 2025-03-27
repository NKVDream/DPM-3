using System;
class Task3
{
    static void Main()
    {
        Console.WriteLine();int num = int.Parse(Console.ReadLine());
        Task3.PosCount(num);
        Task3.PreCount(num);
    }
    static void PosCount(int num)
    {
        int count = 0;
        do
        {
            num = num / 10;
            count++;
        }
        while (num > 0);
        Console.WriteLine(count);
    }
    static void PreCount (int num)
    {
        int count = 0;
        if (num == 0)
        {
            count = 1;
        }
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
}
