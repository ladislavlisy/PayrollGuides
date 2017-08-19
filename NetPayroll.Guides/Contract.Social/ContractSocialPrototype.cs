using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Social
{
    public abstract class ContractSocialPrototype : IContractSocial
    {
        public ContractSocialPrototype(IGuidesSocial guides)
        {
			this.ContractGuides = guides;
		}
	
        public IGuidesSocial ContractGuides { get; protected set; }

		// Employee Contribution

		public decimal EmployeeCommonContribution(Period period, bool onlyPositive, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		public decimal EmployeeGarantContribution(Period period, bool onlyPositive, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		// Employer Contribution

		public decimal EmployerCommonContribution(Period period, bool onlyPositive, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		// Participation Selectors

		public bool PartakeHealthIncome(Period period, WorkEmployTerms employTerm, WorkSocialTerms healthTerm,
			decimal contracterIncome, decimal employmentIncome, decimal summaryIncome)
		{
			return true;
		}

		public decimal IncomeSocialSelector(Period period, bool selSubject, bool selArticle, decimal valArticle)
		{
			return decimal.Zero;
		}

		public decimal EmploySocialSelector(Period period, bool selPartake, decimal valIncome)
		{
			return decimal.Zero;
		}

		// Basis Adapters

		public decimal BasisCommonCalculated(Period period, bool selGarantScheme, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		public decimal BasisGarantCalculated(Period period, bool selGarantScheme, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		public decimal BasisPrimaryAdapted(Period period, bool onlyPositive, decimal valResult)
		{
			return decimal.Zero;
		}

		public decimal BasisOverlapBalance(Period period, decimal accumulBasis, decimal actualBasis)
		{
			return decimal.Zero;
		}
	}
}
