namespace LeapYear
{
    public class LeapYearCalculator
    {
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
/*
            if (year == 2000)
            {
                return true;
            }
            if (year == 1996)
            {
                return true;
            }

            if (year == 1992)
            {
                return true;
            }*/
            
            return false;
        }
    }
}