using System;
using System.Collections.Generic;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.History;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Taxing
{
	public class ContractTaxingHistory : HistoryContract<IContractTaxing>
	{
		private const string NAME_SPACE_PREFIX = "NetPayroll.Guides.Contract.Taxing";

		private const string CLASS_NAME_PREFIX = "ContractTaxing";

		private static readonly Period DEFAULT_PERIOD = new Period(2017, 1);

		private ContractTaxingHistory()
		{
		}

		public static IHistoryContract<IContractTaxing> CreateInstance()
		{
			return new ContractTaxingHistory();
		}

		public static IHistoryContract<IContractTaxing> CreateContracts()
		{
			IHistoryContract<IContractTaxing> contracts = CreateInstance();

			var initContracts = new Dictionary<PeriodSpan, IContractTaxing>() {
				{new PeriodSpan(2011), new ContractTaxing2011() }
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
