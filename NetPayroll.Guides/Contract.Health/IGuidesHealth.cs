using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public interface IGuidesHealth
    {
        bool IsPeriodValid(Period period);

        Int32 BasisMonthlyObligatory();

        decimal BasisAnnualMaximum();

        decimal FactorCompound();

        decimal IncomeEmploymentMargin();

        decimal IncomeContractMargin();
    }
}
