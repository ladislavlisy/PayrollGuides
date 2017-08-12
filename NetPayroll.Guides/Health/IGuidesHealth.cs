using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Health
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
