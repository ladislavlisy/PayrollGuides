﻿using System;
using NetPayroll.Guides.Common;
using NetPayroll.Guides.Interfaces;

namespace NetPayroll.Guides.Contract.Health
{
    public abstract class HealthContractPrototype : IHealthContract
    {
        public HealthContractPrototype(IGuidesHealth guides)
        {
            this.ContractGuides = guides;
        }

		public IGuidesHealth ContractGuides { get; protected set; }

        public decimal EmployeeContribution(Period period, decimal employeeBasis)
        {
            return decimal.Zero;    
        }
	}
}
