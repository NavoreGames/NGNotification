using NGNotification.Enum;
using NGNotification.Interface;
using System;

namespace NGNotification
{
	public class NGException : NGNotification
	{
		public string Trace { get; set; }

		public NGException(string header, string message, string trace)
		{
			Category = Category.Error ;
			Header = header;
			Message = message;
			Trace = trace;
		}
		public NGException(string header, string message) : this(header, message, "") { }
		public NGException(string message) : this("", message) { }

	}
}
