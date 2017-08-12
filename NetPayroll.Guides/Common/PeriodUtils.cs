using System;
using System.Collections.Generic;
using System.Text;

namespace RadPayroll.Guides.Common
{
    public static class PeriodUtils
    {
        public static int DayOfWeekMonToSun(int weekDayCode)
        {
            // DayOfWeek 
            // Sunday = 0
            // Monday = 1 
            // Tuesday = 2
            // Wednesday = 3
            // Thursday = 4
            // Friday = 5
            // Saturday = 6
            if (weekDayCode == Period.WEEKSUN_SUNDAY)
            {
                return Period.WEEKMON_SUNDAY;
            }
            else
            {
                return weekDayCode;
            }
        }

        public static Period PeriodWithYearAndMonth(uint year, byte month)
        {
            return new Period(year * 100 + month);
        }

        public static Period EmptyPeriod()
        {
            return new Period(Period.PRESENT);
        }

        public static Period BeginYear(uint year)
        {
            return new Period(year * 100 + 1);
        }

        public static Period EndYear(uint year)
        {
            return new Period(year * 100 + 12);
        }
    }
}
