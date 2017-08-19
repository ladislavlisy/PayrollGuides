using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractSocial
    {
		decimal EmployeeContribution(Period period, decimal employeeBasis);
	}
}
