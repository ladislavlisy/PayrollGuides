using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Social
{
    public abstract class ContractSocialPrototype : IContractSocial
    {
        public ContractSocialPrototype(IGuidesSocial guides)
        {
			this.ContractGuides = guides;
		}
	
        public IGuidesSocial ContractGuides { get; protected set; }

		public decimal EmployeeContribution(Period period, decimal employeeBasis)
		{
			return decimal.Zero;
		}
	}
}
