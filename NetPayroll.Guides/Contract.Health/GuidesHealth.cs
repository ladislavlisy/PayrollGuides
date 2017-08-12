using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public class GuidesHealth : GuidesLegal, IGuidesHealth
    {
        private readonly Int32 __BasisMonthlyObligatory;
        private readonly decimal __BasisAnnualMaximum;
        private readonly decimal __FactorCompound;
        private readonly decimal __IncomeEmploymentMargin;
        private readonly decimal __IncomeContractMargin;

        private GuidesHealth(uint legalYear, 
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

        public static GuidesHealth Guides2011()
        {
            return new GuidesHealth(PropertiesHealth2011.LEGAL_YEAR,
                PropertiesHealth2011.MONTHLY_BASIS,
                PropertiesHealth2011.ANNUAL_BASIS_MAXIMUM,
                PropertiesHealth2011.FACTOR_COMPOUND,
                PropertiesHealth2011.INCOME_EMPLOY_MARGIN,
                PropertiesHealth2011.INCOME_AGREEM_MARGIN);
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
