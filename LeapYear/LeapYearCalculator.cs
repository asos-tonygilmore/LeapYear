namespace LeapYear;

public class LeapYearCalculator
{
    public bool IsLeapYear(int year)
    {
        var isDivisibleByFour = year % 4 == 0;
        var isDivisibleByOneHundred = year % 100 == 0;
        var isDivisibleByFourHundred = year % 400 == 0;

        var isNotDivisibleBy100_OrDivisibleBy400 = !isDivisibleByOneHundred || isDivisibleByFourHundred;

        if (isDivisibleByFour && isNotDivisibleBy100_OrDivisibleBy400)
        {
            return true;
        }

        return false;
    }
}