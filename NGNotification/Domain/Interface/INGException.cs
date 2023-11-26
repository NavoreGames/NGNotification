namespace NGNotification.Interface
{
	public interface INGException : INGNotification
	{
		string Trace { get; set; }
	}
}
