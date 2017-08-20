using System;
using System.Collections.Generic;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.History;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Social
{
	public class ContractSocialHistory : HistoryContract<IContractSocial>
	{
		private const string NAME_SPACE_PREFIX = "NetPayroll.Guides.Contract.Social";

		private const string CLASS_NAME_PREFIX = "ContractSocial";

		private static readonly Period DEFAULT_PERIOD = new Period(2017, 1);

		private ContractSocialHistory()
		{
		}

		public static IHistoryContract<IContractSocial> CreateInstance()
		{
			return new ContractSocialHistory();
		}

		public static IHistoryContract<IContractSocial> CreateContracts()
		{
			IHistoryContract<IContractSocial> contracts = CreateInstance();

			var initContracts = new Dictionary<PeriodSpan, IContractSocial>() {
				{new PeriodSpan(2011), new ContractSocial2011() }
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
