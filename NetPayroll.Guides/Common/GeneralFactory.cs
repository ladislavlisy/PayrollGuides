using System;
using System.Reflection;

namespace NetPayroll.Guides.Common
{
	public class GeneralFactory<T>
	{
		public static T InstanceFor(Assembly assembly, string namespacePrefix, string className)
		{
			string clazzName = ClassNameFor(namespacePrefix, className);

			Type clazzType = assembly.GetType(clazzName);

			if (clazzType == null)
			{
				throw new InvalidOperationException("Class does't exist: " + clazzName);
			}
			T clazzInstance = (T)Activator.CreateInstance(clazzType);
			if (clazzInstance == null)
			{
				throw new InvalidOperationException("Instance wasn't created: " + clazzName);
			}
			return clazzInstance;
		}

		public static string ClassNameFor(string namespacePrefix, string className)
		{
			string fullClassName = string.Join(".", new string[] { namespacePrefix, className });

			return fullClassName;
		}
	}
}
