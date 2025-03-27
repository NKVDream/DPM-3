using System;
class Task1
{
    static void Main()
    {
        Console.WriteLine("deposit amount:");int deposite = int.Parse(Console.ReadLine());
        Console.WriteLine("number of months:");int months = int.Parse(Console.ReadLine());
        DepCul output = new DepCul(months, deposite);
        output.PostDepProcent();
        output.PreDepProcent();
    }
}
