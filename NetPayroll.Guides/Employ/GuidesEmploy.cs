using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Employ
{
    class GuidesEmploy : GuidesLegal, IGuidesEmploy
    {
        private readonly Int32 __WeeklyWorkingDays;

        private readonly Int32 __DailyWorkingHours;

        private readonly Int32 __DailyWorkingSeconds;

        private readonly Int32 __WeeklyWorkingSeconds;

        public static GuidesEmploy Guides2011()
        {
            return new GuidesEmploy(PropertiesEmploy2011.LEGAL_YEAR,
                PropertiesEmploy2011.DAYS_WORKING_WEEKLY,
                PropertiesEmploy2011.HOURS_WORKING_DAILY);
        }

        private GuidesEmploy(uint legalYear,
            Int32 weeklyWorkingDays, Int32 dailyWorkingHours) : base(legalYear)
		{
            __WeeklyWorkingDays = weeklyWorkingDays;

            __DailyWorkingHours = dailyWorkingHours;

            __DailyWorkingSeconds = OperationsEmploy.WorkingSecondsDaily(__DailyWorkingHours);

            __WeeklyWorkingSeconds = OperationsEmploy.WorkingSecondsWeekly(__WeeklyWorkingDays, __DailyWorkingHours);

        }

        public Int32 WeeklyWorkingDays()
        {
            return __WeeklyWorkingDays;
        }

        public Int32 DailyWorkingHours()
        {
            return __DailyWorkingHours;
        }

        public Int32 DailyWorkingSeconds()
        {
            return __DailyWorkingSeconds;
        }

        public Int32 WeeklyWorkingSeconds()
        {
            return __WeeklyWorkingSeconds;
        }

        public virtual object Clone()
        {
            GuidesEmploy other = (GuidesEmploy)this.MemberwiseClone();
            return other;
        }
    }
}
