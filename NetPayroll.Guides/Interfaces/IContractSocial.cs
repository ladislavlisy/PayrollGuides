using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Constants;

namespace NetPayroll.Guides.Interfaces
{
    public interface IContractSocial
    {
		// Employee Contribution

		decimal EmployeeCommonContribution(Period period, bool onlyPositive, decimal basisPrimary);

		decimal EmployeeGarantContribution(Period period, bool onlyPositive, decimal basisPrimary);

		// Employer Contribution

		decimal EmployerCommonContribution(Period period, bool onlyPositive, decimal basisPrimary);

		// Partake Selectors

		bool PartakeHealthIncome(Period period, WorkEmployTerms employTerm, WorkSocialTerms healthTerm,
			decimal contracterIncome, decimal employmentIncome, decimal summaryIncome);

		decimal IncomeSocialSelector(Period period, bool selSubject, bool selArticle, decimal valArticle);

		decimal EmploySocialSelector(Period period, bool selPartake, decimal valIncome);

		// Basis Adapters

		decimal BasisCommonCalculated(Period period, bool selGarantScheme, decimal basisPrimary);

		decimal BasisGarantCalculated(Period period, bool selGarantScheme, decimal basisPrimary);

		decimal BasisPrimaryAdapted(Period period, bool onlyPositive, decimal valResult);

		decimal BasisOverlapBalance(Period period, decimal accumulBasis, decimal actualBasis);
	}
}
