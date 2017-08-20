using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Contract.Employ;
using NetPayroll.Guides.Contract.Health;
using NetPayroll.Guides.Contract.Social;
using NetPayroll.Guides.Contract.Taxing;
using NetPayroll.Guides.History;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides
{
	public class ServiceContractModule : IServiceContract
	{
		public static IServiceContract CreateModule()
		{
			IServiceContract module = new ServiceContractModule();

			return module;
		}

		private ServiceContractModule()
		{
			EmployHistory = ContractEmployHistory.CreateContracts();

			TaxingHistory = ContractTaxingHistory.CreateContracts();

			HealthHistory = ContractHealthHistory.CreateContracts();

			SocialHistory = ContractSocialHistory.CreateContracts();
		}

		public IProfileContract BuildEngineProfile(Period period)
		{
			IContractEmploy employContract = EmployHistory.ResolveContract(period);
			IContractTaxing taxingContract = TaxingHistory.ResolveContract(period);
			IContractHealth healthContract = HealthHistory.ResolveContract(period);
			IContractSocial socialContract = SocialHistory.ResolveContract(period);

			return new ProfileContract(period, employContract, taxingContract, healthContract, socialContract);
		}

		private IHistoryContract<IContractEmploy> EmployHistory { get; set; }

		private IHistoryContract<IContractTaxing> TaxingHistory { get; set; }

		private IHistoryContract<IContractHealth> HealthHistory { get; set; }

		private IHistoryContract<IContractSocial> SocialHistory { get; set; }

	}
}
