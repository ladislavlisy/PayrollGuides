using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Taxing
{
	public class ContractTaxingPrototype : IContractTaxing
	{
		public ContractTaxingPrototype(IGuidesTaxing guides)
		{
			this.ContractGuides = guides;
		}

		public IGuidesTaxing ContractGuides { get; protected set; }

		public decimal EmployeeContribution(Period period, decimal employeeBasis)
		{
			return decimal.Zero;
		}
	}
}
