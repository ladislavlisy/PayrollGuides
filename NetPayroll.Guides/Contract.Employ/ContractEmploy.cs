using System;
namespace NetPayroll.Guides.Contract.Employ
{
    public class ContractEmploy : ContractEmployPrototype
    {
        public ContractEmploy() : base(new GuidesEmploy2011())
        {
        }
    }
}
