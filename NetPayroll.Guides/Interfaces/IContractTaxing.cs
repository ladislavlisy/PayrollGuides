using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractTaxing
    {
		decimal EmployeeContribution(Period period, decimal employeeBasis);
	}
}
