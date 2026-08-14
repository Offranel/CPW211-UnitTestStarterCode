using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount;

public class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double startingBalance)
    {
        Balance = startingBalance;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
    public void Withdraw(double amount)
    {
        Balance -= amount;
    }
}
