using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public class GuidesHealth : GuidesLegal, IGuidesHealth
    {
        protected readonly Int32 __BasisMonthlyObligatory;
        protected readonly decimal __BasisAnnualMaximum;
        protected readonly decimal __FactorCompound;
        protected readonly decimal __IncomeEmploymentMargin;
        protected readonly decimal __IncomeContractMargin;

		protected GuidesHealth(uint legalYear, 
            Int32 basisMonthlyObligatory,
            decimal basisAnnualMaximum,
            decimal factorCompound,
            decimal incomeEmploymentMargin,
            decimal incomeContractMargin) : base(legalYear)
		{
            __BasisMonthlyObligatory = basisMonthlyObligatory;
            __BasisAnnualMaximum = basisAnnualMaximum;
            __FactorCompound = factorCompound;
            __IncomeEmploymentMargin = incomeEmploymentMargin;
            __IncomeContractMargin = incomeContractMargin;
        }

        public Int32 BasisMonthlyObligatory()
        {
            return __BasisMonthlyObligatory;
        }

        public decimal BasisAnnualMaximum()
        {
            return __BasisAnnualMaximum;
        }

        public decimal FactorCompound()
        {
            return __FactorCompound;
        }

        public decimal IncomeEmploymentMargin()
        {
            return __IncomeEmploymentMargin;
        }

        public decimal IncomeContractMargin()
        {
            return __IncomeContractMargin;
        }

        public virtual object Clone()
        {
            GuidesHealth other = (GuidesHealth)this.MemberwiseClone();
            return other;
        }
    }
}
