using System;
class Task2
{
    static void Main()
    {
        Console.WriteLine("your name:");string name = Console.ReadLine();
        Console.WriteLine("your lastname: ");string surename = Console.ReadLine();
        Task2.Out(name, surename);
    }
    static void Out(string name, string surename)
    {
        string info = name + surename;
        foreach(char c in info)
        {
            Console.WriteLine(c);
        }
    }
}
