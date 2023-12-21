using NGNotification.Enum;
using NGNotification.Interface;

namespace NGNotification
{
	public class NGReply : NGNotification
	{
		public string Question { get; set; }
		public string Reply { get; set; }

		public NGReply(string header, string message, string question)
		{
			Category = Category.Message;
			Header = header;
			Message = message;
			Question = question;
			Reply = "";
		}
		public NGReply(string header, string message) : this(header, message, "") { }
		public NGReply(string message) : this("", message) { }
	}
}
