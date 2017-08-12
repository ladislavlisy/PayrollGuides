using System;
using System.Collections.Generic;
using System.Text;

namespace NetPayroll.Guides.Common
{
    public class GuidesLegal
    {
        public GuidesLegal(uint year)
        {
            ValidFrom = new Period(year, 1);
            ValidUpto = new Period(year, 12);
        }

        public Period ValidFrom { get; private set; }

        public Period ValidUpto { get; private set; }

        public bool IsPeriodValid(Period period)
        {
            return (period >= ValidFrom && period <= ValidUpto);
        }
    }
}
