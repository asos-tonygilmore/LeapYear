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


}