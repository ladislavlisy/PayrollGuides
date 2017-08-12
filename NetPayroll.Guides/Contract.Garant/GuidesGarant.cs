using System;
using System.Collections.Generic;
using System.Text;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Contract.Garant
{
    public class GuidesGarant : GuidesLegal, IGuidesGarant
    {
        private GuidesGarant(uint legalYear) : base(legalYear)
		{
        }
    }
}
