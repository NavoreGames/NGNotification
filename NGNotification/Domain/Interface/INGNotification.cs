using NGNotification.Enum;

namespace NGNotification.Interface
{
	public interface INGNotification
	{
		Category Category { get; set; }
		string Header { get; set; }
		string Message { get; set; }
	}
}
