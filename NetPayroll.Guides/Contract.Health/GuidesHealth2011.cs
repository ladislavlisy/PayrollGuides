using System;
namespace NetPayroll.Guides.Contract.Health
{
    public class GuidesHealth2011 : GuidesHealth
    {
		public GuidesHealth2011() : base(PropertiesHealth2011.LEGAL_YEAR,
				PropertiesHealth2011.MONTHLY_BASIS,
				PropertiesHealth2011.ANNUAL_BASIS_MAXIMUM,
				PropertiesHealth2011.FACTOR_COMPOUND,
				PropertiesHealth2011.INCOME_EMPLOY_MARGIN,
				PropertiesHealth2011.INCOME_AGREEM_MARGIN)
        {
        }
    }
}
