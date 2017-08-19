using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Social
{
    public interface IGuidesSocial
    {
        bool IsPeriodValid(Period period);

        Int32 BasisMonthlyObligatory(Period period);

        decimal BasisAnnualMaximum(Period period);

        decimal FactorEmployee(Period period);

        decimal FactorEmployeeGarant(Period period);

        decimal FactorEmployeeReduce(Period period);

        decimal FactorEmployer(Period period);

        decimal FactorEmployerHigher(Period period);

        decimal IncomeEmploymentMargin(Period period);

        decimal IncomeContractMargin(Period period);
    }
}
