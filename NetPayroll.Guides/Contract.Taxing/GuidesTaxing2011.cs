using System;
using NetPayroll.Guides.Contract.Health;
using NetPayroll.Guides.Contract.Social;

namespace NetPayroll.Guides.Contract.Taxing
{
    public class GuidesTaxing2011 : GuidesTaxing, IGuidesTaxing
    {
		public GuidesTaxing2011() : base(PropertiesTaxing2011.LEGAL_YEAR,
				PropertiesTaxing2011.ALLOWANCE_PAYER,
				PropertiesTaxing2011.ALLOWANCE_DISAB_1ST,
				PropertiesTaxing2011.ALLOWANCE_DISAB_2ND,
				PropertiesTaxing2011.ALLOWANCE_DISAB_3RD,
				PropertiesTaxing2011.ALLOWANCE_STUDY,
				PropertiesTaxing2011.ALLOWANCE_CHILD_1ST,
				PropertiesTaxing2011.ALLOWANCE_CHILD_2ND,
				PropertiesTaxing2011.ALLOWANCE_CHILD_3RD,
				PropertiesHealth2011.FACTOR_COMPOUND,
				PropertiesSocial2011.FACTOR_EMPLOYER,
				PropertiesTaxing2011.FACTOR_ADVANCES,
				PropertiesTaxing2011.FACTOR_WITHHOLD,
				PropertiesTaxing2011.FACTOR_SOLIDARY,
				PropertiesTaxing2011.MIN_VALID_AMOUNT_OF_TAXBONUS,
				PropertiesTaxing2011.MAX_VALID_AMOUNT_OF_TAXBONUS,
				PropertiesTaxing2011.MIN_VALID_INCOME_OF_TAXBONUS,
				PropertiesTaxing2011.MAX_VALID_INCOME_OF_ROUNDING,
				PropertiesTaxing2011.MAX_VALID_INCOME_OF_WITHHOLD,
				PropertiesTaxing2011.MIN_VALID_INCOME_OF_SOLIDARY)
        {
        }

		public Int32 AllowancePayer()
		{
			return __AllowancePayer;
		}

		public Int32 AllowanceDisability(byte disabilityDegree)
		{
			switch (disabilityDegree)
			{
				case ALLOWANCE_DISAB_DEGREE_1ST:
					return AllowanceDisability1St();
				case ALLOWANCE_DISAB_DEGREE_2ND:
					return AllowanceDisability2nd();
				case ALLOWANCE_DISAB_DEGREE_3RD:
					return AllowanceDisability3rd();
			}
			return 0;
		}

		public Int32 AllowanceDisability1St()
		{
			return __AllowanceDisability1St;
		}

		public Int32 AllowanceDisability2nd()
		{
			return __AllowanceDisability2nd;
		}

		public Int32 AllowanceDisability3rd()
		{
			return __AllowanceDisability3rd;
		}

		public Int32 AllowanceStudying()
		{
			return __AllowanceStudying;
		}

		public Int32 AllowanceChildren(byte indexOrder, bool disability)
		{
			switch (indexOrder)
			{
				case ALLOWANCE_CHILDREN_RANK_1ST:
					return AllowanceChildrenValue(__AllowanceChildren1st, disability);
				case ALLOWANCE_CHILDREN_RANK_2ND:
					return AllowanceChildrenValue(__AllowanceChildren2nd, disability);
				case ALLOWANCE_CHILDREN_RANK_3RD:
					return AllowanceChildrenValue(__AllowanceChildren3rd, disability);
			}
			return 0;
		}

		public Int32 AllowanceChildrenValue(Int32 value, bool disability)
		{
			if (disability)
			{
				return ALLOWANCE_DISABILITY_MULTIPLIER * value;
			}
			else
			{
				return value;
			}
		}

		public Int32 AllowanceChildren1st()
		{
			return __AllowanceChildren1st;
		}

		public Int32 AllowanceChildren2nd()
		{
			return __AllowanceChildren2nd;
		}

		public Int32 AllowanceChildren3rd()
		{
			return __AllowanceChildren3rd;
		}

		public decimal FactorHealthIncrease()
		{
			return __FactorHealthIncrease;
		}

		public decimal FactorSocialIncrease()
		{
			return __FactorSocialIncrease;
		}

		public decimal FactorAdvances()
		{
			return __FactorAdvances;
		}

		public decimal FactorWithhold()
		{
			return __FactorWithhold;
		}

		public decimal FactorSolidary()
		{
			return __FactorSolidary;
		}

		public Int32 MinimumAmountOfTaxBonus()
		{
			return __MinimumAmountOfTaxBonus;
		}

		public Int32 MaximumAmountOfTaxBonus()
		{
			return __MaximumAmountOfTaxBonus;
		}

		public Int32 MinimumIncomeOfTaxBonus()
		{
			return __MinimumIncomeOfTaxBonus;
		}

		public Int32 MaximumIncomeOfRounding()
		{
			return __MaximumIncomeOfRounding;
		}

		public Int32 MaximumIncomeOfWithhold()
		{
			return __MaximumIncomeOfWithhold;
		}

		public Int32 MinimumIncomeOfSolidary()
		{
			return __MinimumIncomeOfSolidary;
		}

		public bool SolidaryIncreaseEnabled()
		{
			return (__MinimumIncomeOfSolidary > 0);
		}

        public override object Clone()
		{
			GuidesTaxing2011 other = (GuidesTaxing2011)this.MemberwiseClone();
			return other;
		}
	}
}
