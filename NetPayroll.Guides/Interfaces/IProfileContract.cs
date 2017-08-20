using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IProfileContract
    {
        Period ContractPeriod();

        IContractEmploy EmployContract();

        IContractTaxing TaxingContract();

        IContractHealth HealthContract();

        IContractSocial SocialContract();

	}
}
