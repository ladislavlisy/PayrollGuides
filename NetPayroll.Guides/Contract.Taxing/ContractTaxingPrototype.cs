using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Taxing
{
	public class ContractTaxingPrototype : IContractTaxing
	{
		public ContractTaxingPrototype(IGuidesTaxing guides)
		{
			this.ContractGuides = guides;
		}

		public IGuidesTaxing ContractGuides { get; protected set; }

		// Advance Taxing

		public decimal BasisAdvancesRounded(Period period, decimal taxableHealth, decimal taxableSocial, decimal taxableIncome)
		{
			return decimal.Zero;
		}

		public decimal BasisAdvancesRounded(Period period, decimal taxableIncome)
		{
			return decimal.Zero;
		}

		public Int32 GeneralyTaxAdvances(Period period, decimal taxableIncome, decimal generalyBasis, decimal solidaryBasis)
		{
			return 0;
		}

		public Int32 RegularyTaxAdvances(Period period, decimal regularyBasis)
		{
			return 0;
		}

		public decimal TaxableHealthAdvances(Period period, bool selSubject, decimal healthIncome)
		{
			return decimal.Zero;
		}

		public decimal TaxableSocialAdvances(Period period, bool selSubject, decimal socialIncome)
		{
			return decimal.Zero;
		}

		// Solidary Taxing

		public decimal BasisSolidaryRounded(Period period, decimal taxableIncome)
		{
			return decimal.Zero;
		}

		public Int32 SolidaryTaxAdvances(Period period, decimal solidaryBasis)
		{
			return 0;
		}

		// Withhold Taxing

		public decimal BasisWithholdRounded(Period period, decimal taxableIncome)
		{
			return decimal.Zero;
		}

		public decimal TaxableHealthWithhold(Period period, bool selSubject, decimal healthIncome)
		{
			return decimal.Zero;
		}

		public decimal TaxableSocialWithhold(Period period, bool selSubject, decimal socialIncome)
		{
			return decimal.Zero;
		}

		public Int32 GeneralyTaxWithhold(Period period, decimal generalyBasis)
		{
			return 0;
		}

		// Partake Selectors
		public bool PartakeAdvancesIncome(Period period, bool selStatementSign, bool selResidentCzech, WorkEmployTerms employTerm,
								   decimal contracterIncome, decimal employmentIncome, decimal summaryIncome)
		{
			return true;
		}

		public bool PartakeWithholdIncome(Period period, bool selStatementSign, bool selResidentCzech, WorkEmployTerms employTerm,
								   decimal contracterIncome, decimal employmentIncome, decimal summaryIncome)
		{
			return true;
		}

		public decimal IncomeTaxingSelector(Period period, bool selTaxSubject, bool selTaxArticle, decimal valTaxArticle)
		{
			return decimal.Zero;
		}

		public decimal IncomeHealthSelector(Period period, bool selTaxSubject, bool selInsSubject, 
                                            bool selTaxArticle, bool selInsArticle, bool selInsPartake, decimal valTaxArticle)
		{
			return decimal.Zero;
		}

		public decimal IncomeSocialSelector(Period period, bool selTaxSubject, bool selInsSubject,
											bool selTaxArticle, bool selInsArticle, bool selInsPartake, decimal valTaxArticle)
		{
			return decimal.Zero;
		}

		public decimal IncomeAdvancesSelector(Period period, bool selTaxSubject, decimal valTaxArticle)
		{
			return decimal.Zero;
		}

		public decimal IncomeWithholdSelector(Period period, bool selTaxSubject, decimal valTaxArticle)
		{
			return decimal.Zero;
		}

		// Allowances

		public Int32 StatementPayerAllowance(Period period, bool selStatementSign, bool selResidentCzech)
		{
			return 0;
		}

		public Int32 StatementChildAllowance(Period period, bool selStatementSign, byte inPerOrder, bool disabChildren)
		{
			return 0;
		}

		public Int32 StatementDisabAllowance(Period period, bool selStatementSign, byte inDegree)
		{
			return 0;
		}

		public Int32 StatementStudyAllowance(Period period, bool selStatementSign)
		{
			return 0;
		}

		public Int32 StatementPayerTaxRebate(Period period, Int32 advancesTax,
											 Int32 payerAllowance, Int32 disabAllowance, Int32 studyAllowance)
		{
			return 0;
		}

		public Int32 StatementChildTaxRebate(Period period, Int32 advancesTax, Int32 payerRebate, Int32 childAllowance)
		{
			return 0;
		}

		public Int32 StatementChildTaxBonus(Period period, Int32 advancesTax, Int32 payerRebate, Int32 childAllowance, Int32 childRebate)
		{
			return 0;
		}
	}
}
