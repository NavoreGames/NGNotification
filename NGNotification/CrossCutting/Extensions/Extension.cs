using System;

namespace NGNotification.Extensions
{
	public static class Extension
	{
		public static string SimpleTrace(this Exception obj, System.Reflection.MethodBase methodBase) =>
			$"{methodBase.DeclaringType.FullName}.{methodBase.Name}{((obj.StackTrace != null) ? obj.StackTrace[(obj.StackTrace.LastIndexOf(':') - 1)..] : "")}";
	}
}
