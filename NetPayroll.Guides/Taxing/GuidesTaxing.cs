using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;
using RadPayroll.Guides.Health;
using RadPayroll.Guides.Social;

namespace RadPayroll.Guides.Taxing
{
    public class GuidesTaxing : GuidesLegal, IGuidesTaxing
    {
        private const Int32 ALLOWANCE_DISABILITY_MULTIPLIER = 2;

        public const byte ALLOWANCE_CHILDREN_RANK_1ST = 1;

        public const byte ALLOWANCE_CHILDREN_RANK_2ND = 2;

        public const byte ALLOWANCE_CHILDREN_RANK_3RD = 3;

        public const byte ALLOWANCE_DISAB_DEGREE_1ST = 1;

        public const byte ALLOWANCE_DISAB_DEGREE_2ND = 2;

        public const byte ALLOWANCE_DISAB_DEGREE_3RD = 3;

        private readonly Int32 __AllowancePayer;

        private readonly Int32 __AllowanceDisability1St;

        private readonly Int32 __AllowanceDisability2nd;

        private readonly Int32 __AllowanceDisability3rd;

        private readonly Int32 __AllowanceStudying;

        private readonly Int32 __AllowanceChildren1st;

        private readonly Int32 __AllowanceChildren2nd;

        private readonly Int32 __AllowanceChildren3rd;

        private readonly decimal __FactorHealthIncrease;

        private readonly decimal __FactorSocialIncrease;

        private readonly decimal __FactorAdvances;

        private readonly decimal __FactorWithhold;

        private readonly decimal __FactorSolidary;

        private readonly Int32 __MinimumAmountOfTaxBonus;

        private readonly Int32 __MaximumAmountOfTaxBonus;

        private readonly Int32 __MinimumIncomeOfTaxBonus;

        private readonly Int32 __MaximumIncomeOfRounding;

        private readonly Int32 __MaximumIncomeOfWithhold;

        private readonly Int32 __MinimumIncomeOfSolidary;

        private GuidesTaxing(uint legalYear,
            Int32 allowancePayer,
            Int32 allowanceDisability1St,
            Int32 allowanceDisability2nd,
            Int32 allowanceDisability3rd,
            Int32 allowanceStudying,
            Int32 allowanceChildren1st,
            Int32 allowanceChildren2nd,
            Int32 allowanceChildren3rd,
            decimal factorHealthIncrease,
            decimal factorSocialIncrease,
            decimal factorAdvances,
            decimal factorWithhold,
            decimal factorSolidary,
            Int32 minimumAmountOfTaxBonus,
            Int32 maximumAmountOfTaxBonus,
            Int32 minimumIncomeOfTaxBonus,
            Int32 maximumIncomeOfRounding,
            Int32 maximumIncomeOfWithhold,
            Int32 minimumIncomeOfSolidary) : base(legalYear)
		{
            __AllowancePayer = allowancePayer;
            __AllowanceDisability1St = allowanceDisability1St;
            __AllowanceDisability2nd = allowanceDisability2nd;
            __AllowanceDisability3rd = allowanceDisability3rd;
            __AllowanceStudying = allowanceStudying;
            __AllowanceChildren1st = allowanceChildren1st;
            __AllowanceChildren2nd = allowanceChildren2nd;
            __AllowanceChildren3rd = allowanceChildren3rd;
            __FactorHealthIncrease = factorHealthIncrease;
            __FactorSocialIncrease = factorSocialIncrease;
            __FactorAdvances = factorAdvances;
            __FactorWithhold = factorWithhold;
            __FactorSolidary = factorSolidary;
            __MinimumAmountOfTaxBonus = minimumAmountOfTaxBonus;
            __MaximumAmountOfTaxBonus = maximumAmountOfTaxBonus;
            __MinimumIncomeOfTaxBonus = minimumIncomeOfTaxBonus;
            __MaximumIncomeOfRounding = maximumIncomeOfRounding;
            __MaximumIncomeOfWithhold = maximumIncomeOfWithhold;
            __MinimumIncomeOfSolidary = minimumIncomeOfSolidary;
        }

        public static GuidesTaxing Guides2011()
        {
            return new GuidesTaxing(PropertiesTaxing2011.LEGAL_YEAR,
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
                PropertiesTaxing2011.MIN_VALID_INCOME_OF_SOLIDARY);
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

        public virtual object Clone()
        {
            GuidesTaxing other = (GuidesTaxing)this.MemberwiseClone();
            return other;
        }
    }
}
