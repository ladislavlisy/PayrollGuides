using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractEmploy
    {
		uint DayFromOrdinal(Period period, DateTime? dateFrom);

		uint DayEndsOrdinal(Period period, DateTime? dateEnds);

		Int32[] TimesheetWeekSchedule(Period period, Int32 secondsWeekly, Int32 workdaysWeekly);

		Int32[] TimesheetFullSchedule(Period period, Int32[] weekSchedule);

		Int32[] TimesheetWorkSchedule(Period period, Int32[] monthSchedule, uint dayFrom, uint dayEnds);

		Int32[] TimesheetWorkAbsences(Period period, Int32[] absenceHours, uint dayFrom, uint dayEnds);

		Int32 TotalHoursForSalary(Period period, Int32 fulltimeHour, Int32 workingHours, Int32 absenceHours);

		decimal SalaryAmountScheduleFull(Period period, decimal amountMonthly);

		decimal SalaryAmountScheduleWork(Period period, decimal amountMonthly, Int32 fulltimeHour, Int32 workingHours, Int32 absenceHours);
	}
}
