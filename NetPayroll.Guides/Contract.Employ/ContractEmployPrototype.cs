using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Employ
{
    public abstract class ContractEmployPrototype : IContractEmploy
    {
        public ContractEmployPrototype(IGuidesEmploy guides)
        {
			this.ContractGuides = guides;
		}

        public IGuidesEmploy ContractGuides { get; protected set; }

		public uint DayFromOrdinal(Period period, DateTime? dateFrom)
		{
			return 0;
		}

		public uint DayEndsOrdinal(Period period, DateTime? dateEnds)
		{
			return 0;
		}

        public Int32[] TimesheetWeekSchedule(Period period, Int32 secondsWeekly, Int32 workdaysWeekly)
        {
            return new Int32[] {};
		}

		public Int32[] TimesheetFullSchedule(Period period, Int32[] weekSchedule)
		{
			return new Int32[] { };
		}

		public Int32[] TimesheetWorkSchedule(Period period, Int32[] monthSchedule, uint dayFrom, uint dayEnds)
		{
			return new Int32[] { };
		}

		public Int32[] TimesheetWorkAbsences(Period period, Int32[] absenceHours, uint dayFrom, uint dayEnds)
		{
			return new Int32[] { };
		}

		public Int32 TotalHoursForSalary(Period period, Int32 fulltimeHour, Int32 workingHours, Int32 absenceHours)
		{
			return 0;
		}

		public decimal SalaryAmountScheduleFull(Period period, decimal amountMonthly)
		{
			return decimal.Zero;
		}

		public decimal SalaryAmountScheduleWork(Period period, decimal amountMonthly, 
                                                Int32 fulltimeHour, Int32 workingHours, Int32 absenceHours)
		{
			return decimal.Zero;
		}
	}
}
