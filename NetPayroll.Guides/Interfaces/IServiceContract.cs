using System;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Interfaces
{
    public interface IServiceContract
    {
        IProfileContract BuildProfile(Period period);
	}
}
