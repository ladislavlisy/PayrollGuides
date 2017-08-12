using System;
using System.Collections.Generic;
using System.Text;
using RadPayroll.Guides.Common;

namespace RadPayroll.Guides.Garant
{
    public class GuidesGarant : GuidesLegal, IGuidesGarant
    {
        private GuidesGarant(uint legalYear) : base(legalYear)
		{
        }
    }
}
