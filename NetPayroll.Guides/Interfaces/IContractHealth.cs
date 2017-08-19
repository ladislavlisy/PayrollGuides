using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractHealth
    {
        decimal EmployeeContribution(Period period, decimal employeeBasis);
    }
}
