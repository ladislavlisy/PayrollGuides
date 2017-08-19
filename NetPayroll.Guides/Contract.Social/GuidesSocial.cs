using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Social
{
    public class GuidesSocial : GuidesLegal
    {
        protected readonly Int32 __BasisMonthly;

        protected readonly decimal __BasisAnnual;

        protected readonly decimal __FactorEmployee;

        protected readonly decimal __FactorEmployeeGarant;

        protected readonly decimal __FactorEmployeeReduce;

        protected readonly decimal __FactorEmployer;

        protected readonly decimal __FactorEmployerHigher;

        protected readonly decimal __IncomeEmploymentMargin;

        protected readonly decimal __IncomeContractMargin;

        protected GuidesSocial(uint legalYear,
            Int32 basisMonthly,
            decimal basisAnnual,
            decimal factorEmployee,
            decimal factorEmployeeGarant,
            decimal factorEmployeeReduce,
            decimal factorEmployer,
            decimal factorEmployerHigher,
            decimal incomeEmploymentMargin,
            decimal incomeContractMargin) : base(legalYear)
		{
            __BasisMonthly = basisMonthly;
            __BasisAnnual = basisAnnual;
            __FactorEmployee = factorEmployee;
            __FactorEmployeeGarant = factorEmployeeGarant;
            __FactorEmployeeReduce = factorEmployeeReduce;
            __FactorEmployer = factorEmployer;
            __FactorEmployerHigher = factorEmployerHigher;
            __IncomeEmploymentMargin = incomeEmploymentMargin;
            __IncomeContractMargin = incomeContractMargin;
        }

        public virtual object Clone()
        {
            GuidesSocial other = (GuidesSocial)this.MemberwiseClone();
            return other;
        }
    }
}
