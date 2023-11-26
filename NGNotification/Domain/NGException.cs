using NGNotification.Enum;
using NGNotification.Interface;
using System;

namespace NGNotification
{
	public class NGException : Exception, INGException
	{
		public Category Category { get; set; }
		public string Header { get; set; }
		public new string Message { get; set; }

		public string Trace { get; set; }
		public bool Crash { get; set; }

		public NGException(Category category, string header, string message, string trace)
		{
			Category = category;
			Header = header;
			Message = message;
			Trace = trace;
		}
		public NGException(Category category, string header, string message) : this(category, header, message, "") { }
		public NGException(Category category, string message) : this(category, "", message) { }

	}
}
