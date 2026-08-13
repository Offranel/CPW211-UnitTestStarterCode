using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass()]
public class SimpleMathTests
{
    [TestMethod()]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
    {
        // Use the DataRow values to test the Add method
        double expected = num1 + num2;
        double actual = SimpleMath.Add(num1, num2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Use a few pairs of values to test the Multiply method
        Assert.AreEqual(50, SimpleMath.Multiply(5, 10));
        Assert.AreEqual(0, SimpleMath.Multiply(0, 100));
        Assert.AreEqual(10, SimpleMath.Multiply(-1, -10));
    }

    [TestMethod]
    public void Divide_DenominatorZero_ThrowsArgumentException()
    {
        // Divide by zero should throw an argument exception with a message
        // "Denominator cannot be zero"
        ArgumentException exception = Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(10, 0));
        Assert.AreEqual("Denominator cannot be zero", exception.Message);
    }

    // TODO: Add a new test to test the Divide method with two valid numbers
    [TestMethod]
    public void Divide_TwoValidNumbers_ReturnsQuotient() 
    {
        double expected = 5;
        double actual = SimpleMath.Divide(10, 2);

        Assert.AreEqual(expected, actual);
    }

    // TODO: Add a new test to test the subtract method with two valid numbers
    [TestMethod]
    public void Subtract_TwoValidNumbers_ReturnsDifference()
    {
        double expected = 5;
        double actual = SimpleMath.Subtract(10, 5);

        Assert.AreEqual(expected, actual);
    }
}