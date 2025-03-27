using System;
class DepCul
{
    int Months { get; set; }
    int Deposit { get; set; }
    public DepCul(int Months, int Deposite)
    {
        this.Months = Months;
        this.Deposit = Deposite;
    }
    public void PreDepProcent()
    {
        for (int i = 0; i > Months; i++)
        {
            Deposit += Deposit/100 * 7;
        }
        Console.WriteLine(Deposit);
    }
    public void PostDepProcent()
    {
        int i = 0;
        while (i < Months)
        {
            Deposit += Deposit/100 * 7;
            i++;
        }
        Console.WriteLine(Deposit);
        
    }
}
