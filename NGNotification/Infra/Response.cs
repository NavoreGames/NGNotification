using NGNotification.Interface;

namespace NGNotification
{
	public class Response : IResponse
	{
		public static IResponse Return { get; private set; }
		public Response(bool success, int code, INGNotification error, object data) 
		{ 
			Success = success; 
			Code = code; 
			Data = data;
			Error = error;
			Return = this;
		}
		public Response(bool success, int code, INGNotification error) : this(success, code, error, null) { }
		public Response(bool success, object data) : this(success, 200, null, data) { }
		public Response(bool success) : this(success, null) { }
		public bool Success { get; private set; }
		public int Code { get; private set; }
		public INGNotification Error { get; private set; }
		public object  Data { get; private set; }
	}
}
