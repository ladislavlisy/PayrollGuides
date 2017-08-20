using System;
using System.Collections.Generic;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.History;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Employ
{
	public class ContractEmployHistory : HistoryContract<IContractEmploy>
	{
		private const string NAME_SPACE_PREFIX = "NetPayroll.Guides.Contract.Employ";

		private const string CLASS_NAME_PREFIX = "ContractEmploy";

		private static readonly Period DEFAULT_PERIOD = new Period(2017, 1);

		private ContractEmployHistory()
		{
		}

		public static IHistoryContract<IContractEmploy> CreateInstance()
		{
			return new ContractEmployHistory();
		}

		public static IHistoryContract<IContractEmploy> CreateContracts()
		{
			IHistoryContract<IContractEmploy> contracts = CreateInstance();

			var initContracts = new Dictionary<PeriodSpan, IContractEmploy>() {
				{new PeriodSpan(2011), new ContractEmploy2011() }
			};

			contracts.InitContracts(DEFAULT_PERIOD, initContracts);

			return contracts;
		}

		#region implemented abstract members of GeneralEngines

		protected override string NamespacePrefix()
		{
			return NAME_SPACE_PREFIX;
		}

		protected override string ClassnamePrefix()
		{
			return CLASS_NAME_PREFIX;
		}

		#endregion
	}
}
