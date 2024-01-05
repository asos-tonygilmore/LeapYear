using LeapYear;
using NUnit.Framework;

namespace Tests;

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
    public void GivenYearIsDivisibleByFour_ThenReturnTrue(int year)
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(year);
        Assert.IsTrue(result);
    }
}