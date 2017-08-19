using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Employ
{
    public interface IGuidesEmploy
    {
        bool IsPeriodValid(Period period);

        Int32 WeeklyWorkingDays(Period period);

        Int32 DailyWorkingHours(Period period);

        Int32 DailyWorkingSeconds(Period period);

        Int32 WeeklyWorkingSeconds(Period period);
    }
}
