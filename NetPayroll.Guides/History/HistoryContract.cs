using System;
using System.Collections.Generic;
using System.Linq;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Factories;

namespace NetPayroll.Guides.History
{
	public abstract class HistoryContract<T> : IHistoryContract<T>
	{
		public HistoryContract()
		{
			DefaultInstance = default(T);
		}

		public void InitContracts(Period defaultPeriod, IDictionary<PeriodSpan, T> contracts)
		{
            Contracts = contracts.ToDictionary(key => key.Key, val => val.Value);

			DefaultInstance = ResolveContract(defaultPeriod);
		}

		protected abstract string NamespacePrefix();

		protected abstract string ClassnamePrefix();

		protected T DefaultInstance { get; set; }

		protected IDictionary<PeriodSpan, T> Contracts { get; private set; }

		public T ResolveContract(Period period)
		{
			PeriodSpan periodSpan = FindContractPeriod(period);
			if (periodSpan == null)
			{
				return DefaultInstance;
			}
			T baseEngine;
			if (Contracts.ContainsKey(periodSpan))
			{
				baseEngine = Contracts[periodSpan];
			}
			else
			{
				baseEngine = DefaultInstance;
			}
			return baseEngine;
		}

		public T DefaultContract()
		{
			return DefaultInstance;
		}

		private T CreateEngineFor(PeriodSpan contractPeriod)
		{
			T engine = ContractFactory<T>.InstanceFor(NamespacePrefix(), ClassnamePrefix(), contractPeriod);

			return engine;
		}

		private PeriodSpan FindContractPeriod(Period period)
		{
			ICollection<PeriodSpan> sortedHistory = Contracts.Keys.OrderBy(x => x).ToArray();

            PeriodSpan validPeriod = sortedHistory.FirstOrDefault((x) => (x.IsPeriodValid(period)));

			return validPeriod;
		}
    }
}
