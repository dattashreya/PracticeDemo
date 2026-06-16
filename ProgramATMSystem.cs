using System;

class BankAccount
{
    private double balance; // Internal data is hidden

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public double GetBalance() // Controlled access
    {
        return balance;
    }
}

class ProgramATMSystem
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount(1000);
        myAccount.Deposit(500);
        myAccount.Withdraw(200);
        Console.WriteLine($"Final Balance: {myAccount.GetBalance()}");
    }
}
