using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Health
{
    public class ContractHealth2011 : ContractHealthPrototype
    {
        public ContractHealth2011() : base(new GuidesHealth2011())
        {
        }

    }
}
