using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Health
{
    public abstract class ContractHealthPrototype : IContractHealth
    {
        public ContractHealthPrototype(IGuidesHealth guides)
        {
            this.ContractGuides = guides;
        }

		public IGuidesHealth ContractGuides { get; protected set; }

		public decimal EmployeePrimaryContribution(Period period, bool onlyPositive, decimal basisPrimary)
		{
			return decimal.Zero;
		}

		public decimal EmployeeMinimumContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum)
		{
			return decimal.Zero;
		}

		public decimal EmployeeSummaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum)
		{
			return decimal.Zero;
		}

		// Employer Contribution

		public decimal EmployerPrimaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum)
		{
			return decimal.Zero;
		}

		public decimal EmployerMinimumContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal minsEmployee, decimal minsEmployer)
		{
			return decimal.Zero;
		}

		public decimal EmployerSummaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal minsEmployee, decimal minsEmployer)
		{
			return decimal.Zero;
		}

        // Participation Selectors

        public bool PartakeHealthIncome(Period period, WorkEmployTerms employTerm, WorkHealthTerms healthTerm,
            decimal contracterIncome, decimal employmentIncome, decimal summaryIncome)
        {
            return true;
        }

        public decimal IncomeHealthSelector(Period period, bool selSubject, bool selArticle, decimal valArticle)
		{
			return decimal.Zero;
		}

		public decimal EmployHealthSelector(Period period, bool selPartake, decimal valIncome)
		{
			return decimal.Zero;
		}

		// Basis Adapters

		public decimal BasisPrimaryAdapted(Period period, bool onlyPositive, decimal valResult)
		{
			return decimal.Zero;
		}

		public decimal BasisMinimumBalance(Period period, bool dutyMinimums, decimal valResult)
		{
			return decimal.Zero;
		}

		public decimal BasisOverlapBalance(Period period, decimal accumulBasis, decimal actualBasis)
		{
			return decimal.Zero;
		}
	}
}
