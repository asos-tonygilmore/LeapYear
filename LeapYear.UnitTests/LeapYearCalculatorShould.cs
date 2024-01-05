using LeapYear;
using NUnit.Framework;

namespace Tests;

public class LeapYearCalculatorShould
{

    [Test]
    public void GivenIsYear2000_ThenReturnTrue()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(2000);
        Assert.IsTrue(result);
    }

    [Test]
    public void GivenIsYear1996_ThenReturnTrue()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(1996);
        Assert.IsTrue(result);
    }

    [Test]
    public void GivenIsYear2001_ThenReturnFalse()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(2001);
        Assert.IsFalse(result);
    }

    [Test]
    public void GivenIsYear1992_ThenReturnTrue()
    {
        var calculator = new LeapYearCalculator();
        var result = calculator.IsLeapYear(1992);
        Assert.IsTrue(result);
    }
}