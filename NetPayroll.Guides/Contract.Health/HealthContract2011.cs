using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public class HealthContract2011 : HealthContractPrototype
    {
        public HealthContract2011() : base(new GuidesHealth2011())
        {
        }

    }
}
