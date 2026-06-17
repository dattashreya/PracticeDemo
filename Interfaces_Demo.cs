using System;

interface IPayment
{
    void MakePayment(double amount);
}

class CreditCardPayment : IPayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

class PayPalPayment : IPayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

class UpiPayment : IPayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using UPI.");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment1 = new CreditCardPayment();
        payment1.MakePayment(500.00); // Output: Paid 500 using Credit Card.

        IPayment payment2 = new PayPalPayment();
        payment2.MakePayment(750.00); // Output: Paid 750 using PayPal.

        IPayment payment3 = new UpiPayment();
        payment3.MakePayment(300.00); // Output: Paid 300 using UPI.
    }
}
