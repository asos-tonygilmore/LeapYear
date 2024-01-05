using NUnit.Framework;

namespace LeapYear.UnitTests;

public class LeapYearCalculatorShould
{
    [Test]
    public void GivenIsYear2001_ThenReturnFalse()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(2001);
        Assert.IsFalse(result);
    }

    [Test]
    public void GivenIsYear1900_ThenReturnFalse()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(1900);
        Assert.IsFalse(result);
    }

    [TestCase(1992)]
    [TestCase(2000)]
    [TestCase(1996)]
    [TestCase(1600)]
    [TestCase(2400)]
    public void GivenYearIsDivisibleByFour_ThenReturnTrue(int year)
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(year);
        Assert.IsTrue(result);
    }

    [TestCase(1700)]
    [TestCase(1800)]
    [TestCase(1900)]
    [TestCase(2100)]
    [TestCase(2200)]
    [TestCase(2300)]
    [TestCase(2500)]
    [TestCase(2600)]
    public void GivenYearIsNotALeapYear_ThenReturnFalse(int year)
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(year);
        Assert.IsFalse(result);
    }
}