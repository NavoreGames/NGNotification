using NGNotification.Enum;
using NGNotification.Interface;

namespace NGNotification
{
	public class NGMessage : INGMessage
	{
		public Category Category { get; set; }
		public string Header { get; set; }
		public string Message { get; set; }
		public string Question { get; set; }

		public Reply Reply { get; set; }
		public bool Button { get; private set; }

		public NGMessage(Category category, string header, string message, string question)
		{
			Category = category;
			Header = header;
			Message = message;
			Question = question;
			Reply = Reply.None;
		}
		public NGMessage(Category category, string header, string message) : this(category, header, message, "") { }
		public NGMessage(Category category, string message) : this(category, null, message, null) { }
	}
}
