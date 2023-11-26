using System;

namespace NGNotification.Extension
{
	public static class Extension
	{
		public static string SimpleTrace(this Exception obj, System.Reflection.MethodBase methodBase)
		{
			string ret = "";

			try
			{
				ret = methodBase.DeclaringType.FullName + "." + methodBase.Name + ((obj.StackTrace != null) ? obj.StackTrace.Substring(obj.StackTrace.LastIndexOf(':') - 1) : "");
			}
			catch { }

			return ret;
		}
	}
}
