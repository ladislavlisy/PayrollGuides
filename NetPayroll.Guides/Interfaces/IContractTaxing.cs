using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractTaxing
    {
		// Advance Taxing

		decimal BasisAdvancesRounded(Period period, decimal taxableHealth, decimal taxableSocial, decimal taxableIncome);

		decimal BasisAdvancesRounded(Period period, decimal taxableIncome);

		Int32 GeneralyTaxAdvances(Period period, decimal taxableIncome, decimal generalyBasis, decimal solidaryBasis);

		Int32 RegularyTaxAdvances(Period period, decimal regularyBasis);

		decimal TaxableHealthAdvances(Period period, bool selSubject, decimal healthIncome);

		decimal TaxableSocialAdvances(Period period, bool selSubject, decimal socialIncome);

		// Solidary Taxing

		decimal BasisSolidaryRounded(Period period, decimal taxableIncome);

		Int32 SolidaryTaxAdvances(Period period, decimal solidaryBasis);

		// Withhold Taxing

		decimal BasisWithholdRounded(Period period, decimal taxableIncome);

		decimal TaxableHealthWithhold(Period period, bool selSubject, decimal healthIncome);

		decimal TaxableSocialWithhold(Period period, bool selSubject, decimal socialIncome);

		Int32 GeneralyTaxWithhold(Period period, decimal generalyBasis);

		// Partake Selectors
		bool PartakeAdvancesIncome(Period period, bool selStatementSign, bool selResidentCzech, WorkEmployTerms employTerm, 
                                   decimal contracterIncome, decimal employmentIncome, decimal summaryIncome);

		bool PartakeWithholdIncome(Period period, bool selStatementSign, bool selResidentCzech, WorkEmployTerms employTerm, 
                                   decimal contracterIncome, decimal employmentIncome, decimal summaryIncome);

		decimal IncomeTaxingSelector(Period period, bool selTaxSubject, bool selTaxArticle, decimal valTaxArticle);

        decimal IncomeHealthSelector(Period period, bool selTaxSubject, bool selInsSubject, bool selTaxArticle, bool selInsArticle, bool selInsPartake, decimal valTaxArticle);
		
        decimal IncomeSocialSelector(Period period, bool selTaxSubject, bool selInsSubject, bool selTaxArticle, bool selInsArticle, bool selInsPartake, decimal valTaxArticle);

        decimal IncomeAdvancesSelector(Period period, bool selTaxSubject, decimal valTaxArticle);

		decimal IncomeWithholdSelector(Period period, bool selTaxSubject, decimal valTaxArticle);

		// Allowances

		Int32 StatementPayerAllowance(Period period, bool selStatementSign, bool selResidentCzech);

		Int32 StatementChildAllowance(Period period, bool selStatementSign, byte inPerOrder, bool disabChildren);

		Int32 StatementDisabAllowance(Period period, bool selStatementSign, byte inDegree);

		Int32 StatementStudyAllowance(Period period, bool selStatementSign);

		Int32 StatementPayerTaxRebate(Period period, Int32 advancesTax, Int32 payerAllowance, Int32 disabAllowance, Int32 studyAllowance);

		Int32 StatementChildTaxRebate(Period period, Int32 advancesTax, Int32 payerRebate, Int32 childAllowance);

		Int32 StatementChildTaxBonus(Period period, Int32 advancesTax, Int32 payerRebate, Int32 childAllowance, Int32 childRebate);
	}
}
