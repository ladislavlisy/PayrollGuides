using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public class GuidesHealth2011 : GuidesHealth, IGuidesHealth
    {
		public GuidesHealth2011() : base(
            PropertiesHealth2011.LEGAL_YEAR,
            PropertiesHealth2011.BASIS_MONTHLY_MINIMUM,
            PropertiesHealth2011.BASIS_ANNUAL_MAXIMUM,
			PropertiesHealth2011.FACTOR_COMPOUND,
			PropertiesHealth2011.INCOME_EMPLOY_MARGIN,
			PropertiesHealth2011.INCOME_AGREEM_MARGIN)
        {
        }

		public Int32 BasisMonthlyObligatory(Period period)
		{
			return __BasisMonthlyObligatory;
		}

		public decimal BasisAnnualMaximum(Period period)
		{
			return __BasisAnnualMaximum;
		}

		public decimal FactorCompound(Period period)
		{
			return __FactorCompound;
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
			GuidesHealth2011 other = (GuidesHealth2011)this.MemberwiseClone();
			return other;
		}
	}
}
