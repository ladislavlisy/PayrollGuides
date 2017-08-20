using System;
using System.Collections.Generic;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.History
{
    public interface IHistoryContract<T>
    {
		void InitContracts(Period defaultPeriod, IDictionary<PeriodSpan, T> contracts);

		T ResolveContract(Period period);

		T DefaultContract();
	}
}
