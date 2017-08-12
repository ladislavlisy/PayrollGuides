using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Garant
{
    public interface IGuidesGarant
    {
        bool IsPeriodValid(Period period);
    }
}
