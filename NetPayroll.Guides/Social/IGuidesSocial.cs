using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Social
{
    public interface IGuidesSocial
    {
        bool IsPeriodValid(Period period);

        Int32 BasisMonthlyObligatory();

        decimal BasisAnnualMaximum();

        decimal FactorEmployee();

        decimal FactorEmployeeGarant();

        decimal FactorEmployeeReduce();

        decimal FactorEmployer();

        decimal FactorEmployerHigher();

        decimal IncomeEmploymentMargin();

        decimal IncomeContractMargin();
    }
}
