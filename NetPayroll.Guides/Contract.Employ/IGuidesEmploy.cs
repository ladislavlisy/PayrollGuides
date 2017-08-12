using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Employ
{
    public interface IGuidesEmploy
    {
        bool IsPeriodValid(Period period);

        Int32 WeeklyWorkingDays();

        Int32 DailyWorkingHours();

        Int32 DailyWorkingSeconds();

        Int32 WeeklyWorkingSeconds();
    }
}
