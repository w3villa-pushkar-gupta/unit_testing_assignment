using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ValidInputs_ReturnsCorrectSum()
    {
        int result = _calculator.Add(3, 7);
        Assert.AreEqual(10, result);
    }

    [Test]
    public void Add_Overflow_ThrowsOverflowException()
    {
        Assert.Throws<OverflowException>(() => _calculator.Add(int.MaxValue, 1));
    }

    [Test]
    public void Subtract_ValidInputs_ReturnsCorrectDifference()
    {
        int result = _calculator.Subtract(10, 3);
        Assert.AreEqual(7, result);
    }

    [Test]
    public void Subtract_Underflow_ThrowsOverflowException()
    {
        Assert.Throws<OverflowException>(() => _calculator.Subtract(int.MinValue, 1));
    }
}
