using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides
{
    public class ProfileContract : IProfileContract
    {
		public ProfileContract(Period period, 
                               IContractEmploy employ, 
                               IContractTaxing taxing, 
                               IContractHealth health, 
                               IContractSocial social)
		{
			__Period = period;

			__Employ = employ;

			__Taxing = taxing;

			__Health = health;

			__Social = social;
		}

		private Period __Period;

		private IContractEmploy __Employ;

		private IContractTaxing __Taxing;

		private IContractHealth __Health;

		private IContractSocial __Social;


		#region IProfileContract implementation

		public Period ContractPeriod()
		{
			return __Period;
		}

		public IContractEmploy EmployContract()
		{
			return __Employ;
		}

		public IContractTaxing TaxingContract()
		{
			return __Taxing;
		}

		public IContractHealth HealthContract()
		{
			return __Health;
		}

		public IContractSocial SocialContract()
		{
			return __Social;
		}

		#endregion
	}
}
