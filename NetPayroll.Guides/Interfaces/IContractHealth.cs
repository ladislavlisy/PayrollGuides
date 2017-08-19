using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractHealth
    {
        // Employee Contribution

		decimal EmployeePrimaryContribution(Period period, bool onlyPositive, decimal basisPrimary);

		decimal EmployeeMinimumContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum);

		decimal EmployeeSummaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum);

		// Employer Contribution

		decimal EmployerPrimaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal basisMinimum);

		decimal EmployerMinimumContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal minsEmployee, decimal minsEmployer);

		decimal EmployerSummaryContribution(Period period, bool onlyPositive, decimal basisPrimary, decimal minsEmployee, decimal minsEmployer);

		// Partake Selectors

        bool PartakeHealthIncome(Period period, WorkEmployTerms employTerm, WorkHealthTerms healthTerm,
		    decimal contracterIncome, decimal employmentIncome, decimal summaryIncome);

        decimal IncomeHealthSelector(Period period, bool selSubject, bool selArticle, decimal valArticle);

		decimal EmployHealthSelector(Period period, bool selPartake, decimal valIncome);

        // Basis Adapters

		decimal BasisPrimaryAdapted(Period period, bool onlyPositive, decimal valResult);

		decimal BasisMinimumBalance(Period period, bool dutyMinimums, decimal valResult);

		decimal BasisOverlapBalance(Period period, decimal accumulBasis, decimal actualBasis);
 	}
}
