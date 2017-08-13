using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IHealthContract
    {
        decimal EmployeeContribution(Period period, decimal employeeBasis);
    }
}
