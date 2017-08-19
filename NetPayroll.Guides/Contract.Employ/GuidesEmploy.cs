using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Employ
{
    public class GuidesEmploy : GuidesLegal
    {
        protected readonly Int32 __WeeklyWorkingDays;

        protected readonly Int32 __DailyWorkingHours;

        protected readonly Int32 __DailyWorkingSeconds;

        protected readonly Int32 __WeeklyWorkingSeconds;

        protected GuidesEmploy(uint legalYear,
            Int32 weeklyWorkingDays, Int32 dailyWorkingHours) : base(legalYear)
		{
            __WeeklyWorkingDays = weeklyWorkingDays;

            __DailyWorkingHours = dailyWorkingHours;

            __DailyWorkingSeconds = OperationsEmploy.WorkingSecondsDaily(__DailyWorkingHours);

            __WeeklyWorkingSeconds = OperationsEmploy.WorkingSecondsWeekly(__WeeklyWorkingDays, __DailyWorkingHours);

        }

        public virtual object Clone()
        {
            GuidesEmploy other = (GuidesEmploy)this.MemberwiseClone();
            return other;
        }
    }
}
