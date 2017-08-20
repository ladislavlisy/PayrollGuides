using System;
using System.Reflection;
using NetPayroll.Guides.Common;

namespace NetPayroll.Guides.Factories
{
    public static class ContractFactory<T>
    {
		public static T InstanceFor(string namespacePrefix, string classnamePrefix, PeriodSpan contractPeriod)
		{
			Assembly assembly = typeof(ServiceContractModule).Assembly;

			return GeneralFactory<T>.InstanceFor(assembly, namespacePrefix, ClassNameFor(classnamePrefix, contractPeriod));
		}

		public static string ClassNameFor(string classnamePrefix, PeriodSpan contractPeriod)
		{
			string className = classnamePrefix + contractPeriod.ClassName();

			return className;
		}
	}
}
