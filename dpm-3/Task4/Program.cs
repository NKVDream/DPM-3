using System;
class Task4
{
    static void Main()
    {
        Console.WriteLine("factorial=");double n = double.Parse(Console.ReadLine());
        Factorial fac = new Factorial(n);
        fac.Nfac(n);
    }
}