using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractEmploy
    {
		decimal EmployeeContribution(Period period, decimal employeeBasis);
	}
}
