using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Social
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
