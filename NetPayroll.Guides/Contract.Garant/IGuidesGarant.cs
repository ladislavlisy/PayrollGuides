using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Garant
{
    public interface IGuidesGarant
    {
        bool IsPeriodValid(Period period);
    }
}
