using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Social
{
    public class GuidesSocial : GuidesLegal, IGuidesSocial
    {
        private readonly Int32 __BasisMonthly;

        private readonly decimal __BasisAnnual;

        private readonly decimal __FactorEmployee;

        private readonly decimal __FactorEmployeeGarant;

        private readonly decimal __FactorEmployeeReduce;

        private readonly decimal __FactorEmployer;

        private readonly decimal __FactorEmployerHigher;

        private readonly decimal __IncomeEmploymentMargin;

        private readonly decimal __IncomeContractMargin;

        private GuidesSocial(uint legalYear,
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

        public static GuidesSocial Guides2011()
        {
            return new GuidesSocial(PropertiesSocial2011.LEGAL_YEAR,
                PropertiesSocial2011.MONTHLY_BASIS,
                PropertiesSocial2011.ANNUAL_BASIS_MAXIMUM,
                PropertiesSocial2011.FACTOR_EMPLOYEE,
                PropertiesSocial2011.FACTOR_EMPLOYEE_GARANT,
                PropertiesSocial2011.FACTOR_REDUCE_GARANT,
                PropertiesSocial2011.FACTOR_EMPLOYER,
                PropertiesSocial2011.FACTOR_EMPLOYER_HIGHER,
                PropertiesSocial2011.INCOME_EMPLOY_MARGIN,
                PropertiesSocial2011.INCOME_AGREEM_MARGIN);
        }

        public Int32 BasisMonthlyObligatory()
        {
            return __BasisMonthly;
        }

        public decimal BasisAnnualMaximum()
        {
            return __BasisAnnual;
        }

        public decimal FactorEmployee()
        {
            return __FactorEmployee;
        }

        public decimal FactorEmployeeGarant()
        {
            return __FactorEmployeeGarant;
        }

        public decimal FactorEmployeeReduce()
        {
            return __FactorEmployeeReduce;
        }

        public decimal FactorEmployer()
        {
            return __FactorEmployer;
        }

        public decimal FactorEmployerHigher()
        {
            return __FactorEmployerHigher;
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
            GuidesSocial other = (GuidesSocial)this.MemberwiseClone();
            return other;
        }
    }
}
