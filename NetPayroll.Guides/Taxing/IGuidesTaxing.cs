using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Taxing
{
    public interface IGuidesTaxing
    {
        bool IsPeriodValid(Period period);

        Int32 AllowancePayer();

        Int32 AllowanceDisability(byte disabilityDegree);

        Int32 AllowanceDisability1St();

        Int32 AllowanceDisability2nd();

        Int32 AllowanceDisability3rd();

        Int32 AllowanceStudying();

        Int32 AllowanceChildren(byte inPerOrder, bool disability);

        Int32 AllowanceChildren1st();

        Int32 AllowanceChildren2nd();

        Int32 AllowanceChildren3rd();

        decimal FactorHealthIncrease();

        decimal FactorSocialIncrease();

        decimal FactorAdvances();

        decimal FactorWithhold();

        decimal FactorSolidary();

        Int32 MinimumAmountOfTaxBonus();

        Int32 MaximumAmountOfTaxBonus();

        Int32 MinimumIncomeOfTaxBonus();

        Int32 MaximumIncomeOfRounding();

        Int32 MaximumIncomeOfWithhold();

        Int32 MinimumIncomeOfSolidary();

        bool SolidaryIncreaseEnabled();
    }
}
