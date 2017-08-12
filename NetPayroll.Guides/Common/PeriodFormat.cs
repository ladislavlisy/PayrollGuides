using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RadPayroll.Guides.Common
{
    public static class PeriodFormat
    {
        public static string Description(Period period)
        {
            CultureInfo enCultureInfo = new CultureInfo("en-US");

            DateTime firstPeriodDay = period.BeginOfMonth();

            return firstPeriodDay.ToString("MMMM yyyy", enCultureInfo);
        }

    }
}
