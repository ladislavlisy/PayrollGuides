using System;
using System.Collections.Generic;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.History;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Health
{
    public class ContractHealthHistory : HistoryContract<IContractHealth>
    {
        private const string NAME_SPACE_PREFIX = "NetPayroll.Guides.Contract.Health";

        private const string CLASS_NAME_PREFIX = "ContractHealth";

        private static readonly Period DEFAULT_PERIOD = new Period(2017, 1);

        private ContractHealthHistory()
        {
        }

        public static IHistoryContract<IContractHealth> CreateInstance()
        {
            return new ContractHealthHistory();
        }

        public static IHistoryContract<IContractHealth> CreateContracts()
        {
            IHistoryContract<IContractHealth> contracts = CreateInstance();

            var initContracts = new Dictionary<PeriodSpan, IContractHealth>() {
                {new PeriodSpan(2011), new ContractHealth2011() }
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
