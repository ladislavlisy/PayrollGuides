using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public interface IGuidesHealth
    {
        bool IsPeriodValid(Period period);

        Int32 BasisMonthlyObligatory(Period period);

        decimal BasisAnnualMaximum(Period period);

        decimal FactorCompound(Period period);

        decimal IncomeEmploymentMargin(Period period);

        decimal IncomeContractMargin(Period period);
    }
}
