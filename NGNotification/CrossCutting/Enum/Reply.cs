using NGEnum;

namespace NGNotification.Enum
{
	/// <summary>
	/// ENUM PARA OS TIPOS DE RESPOSTA
	/// </summary>
	public class Reply : NGEnums<Reply>
	{
		public static readonly Reply Yes = new Reply("Yes");
		public static readonly Reply No = new Reply("No");
		public static readonly Reply Cancel = new Reply("Cancel");
		public static readonly Reply Exit = new Reply("Exit");

		public Reply() : base() { }
		public Reply(object pObject) : base(pObject) { }
		public Reply(int pId, object pObject) : base(pId, pObject) { }
	}
}