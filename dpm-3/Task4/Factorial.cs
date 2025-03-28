using System;
class Factorial
{
    public double n {  get; set; }
    public Factorial(double n)
    {
        this.n = n;
    }
    public void Nfac(double n)
    {
        double fac = 1;
        if (n == 0)
            Console.WriteLine(1);
        else
        {
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
        }
        Console.WriteLine(fac);

    }
}