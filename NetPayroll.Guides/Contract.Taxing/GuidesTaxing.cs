using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Contract.Health;
using NetPayroll.Guides.Contract.Social;

namespace NetPayroll.Guides.Contract.Taxing
{
    public class GuidesTaxing : GuidesLegal
    {
        protected const Int32 ALLOWANCE_DISABILITY_MULTIPLIER = 2;

        protected const byte ALLOWANCE_CHILDREN_RANK_1ST = 1;

        protected const byte ALLOWANCE_CHILDREN_RANK_2ND = 2;

        protected const byte ALLOWANCE_CHILDREN_RANK_3RD = 3;

        protected const byte ALLOWANCE_DISAB_DEGREE_1ST = 1;

        protected const byte ALLOWANCE_DISAB_DEGREE_2ND = 2;

        protected const byte ALLOWANCE_DISAB_DEGREE_3RD = 3;

        protected readonly Int32 __AllowancePayer;

        protected readonly Int32 __AllowanceDisability1St;

        protected readonly Int32 __AllowanceDisability2nd;

        protected readonly Int32 __AllowanceDisability3rd;

        protected readonly Int32 __AllowanceStudying;

        protected readonly Int32 __AllowanceChildren1st;

        protected readonly Int32 __AllowanceChildren2nd;

        protected readonly Int32 __AllowanceChildren3rd;

        protected readonly decimal __FactorHealthIncrease;

        protected readonly decimal __FactorSocialIncrease;

        protected readonly decimal __FactorAdvances;

        protected readonly decimal __FactorWithhold;

        protected readonly decimal __FactorSolidary;

        protected readonly Int32 __MinimumAmountOfTaxBonus;

        protected readonly Int32 __MaximumAmountOfTaxBonus;

        protected readonly Int32 __MinimumIncomeOfTaxBonus;

        protected readonly Int32 __MaximumIncomeOfRounding;

        protected readonly Int32 __MaximumIncomeOfWithhold;

        protected readonly Int32 __MinimumIncomeOfSolidary;

        protected GuidesTaxing(uint legalYear,
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

        public virtual object Clone()
        {
            GuidesTaxing other = (GuidesTaxing)this.MemberwiseClone();
            return other;
        }
    }
}
