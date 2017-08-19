using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Employ
{
    public class GuidesEmploy2011 : GuidesEmploy, IGuidesEmploy
    {
		public GuidesEmploy2011() : base(PropertiesEmploy2011.LEGAL_YEAR,
				PropertiesEmploy2011.DAYS_WORKING_WEEKLY,
				PropertiesEmploy2011.HOURS_WORKING_DAILY)
        {
        }

		public Int32 WeeklyWorkingDays(Period period)
		{
			return __WeeklyWorkingDays;
		}

		public Int32 DailyWorkingHours(Period period)
		{
			return __DailyWorkingHours;
		}

		public Int32 DailyWorkingSeconds(Period period)
		{
			return __DailyWorkingSeconds;
		}

		public Int32 WeeklyWorkingSeconds(Period period)
		{
			return __WeeklyWorkingSeconds;
		}

        public override object Clone()
		{
			GuidesEmploy other = (GuidesEmploy)this.MemberwiseClone();
			return other;
		}
	}
}
