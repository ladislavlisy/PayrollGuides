using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Social
{
    public class GuidesSocial2011 : GuidesSocial, IGuidesSocial
    {
		public GuidesSocial2011() : base(PropertiesSocial2011.LEGAL_YEAR,
				PropertiesSocial2011.MONTHLY_BASIS,
				PropertiesSocial2011.ANNUAL_BASIS_MAXIMUM,
				PropertiesSocial2011.FACTOR_EMPLOYEE,
				PropertiesSocial2011.FACTOR_EMPLOYEE_GARANT,
				PropertiesSocial2011.FACTOR_REDUCE_GARANT,
				PropertiesSocial2011.FACTOR_EMPLOYER,
				PropertiesSocial2011.FACTOR_EMPLOYER_HIGHER,
				PropertiesSocial2011.INCOME_EMPLOY_MARGIN,
				PropertiesSocial2011.INCOME_AGREEM_MARGIN)
        {
        }
		public Int32 BasisMonthlyObligatory(Period period)
		{
			return __BasisMonthly;
		}

		public decimal BasisAnnualMaximum(Period period)
		{
			return __BasisAnnual;
		}

		public decimal FactorEmployee(Period period)
		{
			return __FactorEmployee;
		}

		public decimal FactorEmployeeGarant(Period period)
		{
			return __FactorEmployeeGarant;
		}

		public decimal FactorEmployeeReduce(Period period)
		{
			return __FactorEmployeeReduce;
		}

		public decimal FactorEmployer(Period period)
		{
			return __FactorEmployer;
		}

		public decimal FactorEmployerHigher(Period period)
		{
			return __FactorEmployerHigher;
		}

		public decimal IncomeEmploymentMargin(Period period)
		{
			return __IncomeEmploymentMargin;
		}

		public decimal IncomeContractMargin(Period period)
		{
			return __IncomeContractMargin;
		}

        public override object Clone()
		{
			GuidesSocial2011 other = (GuidesSocial2011)this.MemberwiseClone();
			return other;
		}
	}
}
