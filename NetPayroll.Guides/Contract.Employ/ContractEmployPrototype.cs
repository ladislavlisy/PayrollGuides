using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Employ
{
    public abstract class ContractEmployPrototype : IContractEmploy
    {
        public ContractEmployPrototype(IGuidesEmploy guides)
        {
			this.ContractGuides = guides;
		}

        public IGuidesEmploy ContractGuides { get; protected set; }

		public decimal EmployeeContribution(Period period, decimal employeeBasis)
		{
			return decimal.Zero;
		}
	}
}
