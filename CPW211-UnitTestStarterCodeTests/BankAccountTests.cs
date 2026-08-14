using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountClass = BankAccount.BankAccount;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass]
public class BankAccountTests
{   
    [TestMethod]
    public void Constructor_SetsStartingBalance()
    {    
        // Arrange

        double startingBalance = 100;
        double expectedBalance = 100;

        // Act
        BankAccountClass account = new(startingBalance);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [TestMethod]
    public void Deposit_IncreasesBalance()
    {
        // Arrange
        BankAccountClass account = new(0);
        double amount = 50;
        double expectedBalance = 50;

        // Act
        account.Deposit(amount);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
       
    }

    [TestMethod]
    public void Withdraw_DecreasesBalance()
    {

        // Arrange
        BankAccountClass account = new(100);
        double amount = 30;
        double expectedBalance = 70;
        // Act
        account.Withdraw(amount);
        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [TestMethod]
    public void MultipleOperations_ResultsCorrectBalance()
    {
        // Arrange
        BankAccountClass account = new(10);
        double depositAmount = 15;
        double withdrawAmount = 5;
        double expectedBalance = 20;
        // Act
        account.Deposit(depositAmount);
        account.Withdraw(withdrawAmount);
        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);


    }
    [TestMethod]
    public void Deposit_zeroAmount_BalanceDoesNotChange()
    {
        // Arrange
        BankAccountClass account = new(100);
        double depositAmount = 0;
        double expectedBalance = 100;
        // Act
        account.Deposit(depositAmount);
        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    } 

}
