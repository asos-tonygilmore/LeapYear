using LeapYear;
using NUnit.Framework;

namespace Tests
{
    public class LeapYearCalculatorShould
    {

        [Test]
        public void GivenIsYearDivisibleBy4_ThenReturnTrue()
        {
            var calculator = new LeapYearCalculator();
            var result = calculator.IsLeapYear(2000);
            Assert.IsTrue(result);
        }

      
    }
}