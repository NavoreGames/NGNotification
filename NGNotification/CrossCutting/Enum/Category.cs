using NGEnum;

namespace NGNotification.Enum
{
	/// <summary>
	/// ENUM PARA AS CATEGORIAS DAS NOTIFICAÇÕES
	/// </summary>
	public class Category : NGEnums<Category>
	{
		public static readonly Category Log = new Category("Log");
		public static readonly Category Information = new Category("Information");
		public static readonly Category Warning = new Category("Warning");
		public static readonly Category Error = new Category("Error");
		public static readonly Category Fatal = new Category("Fatal");

		public Category() : base() { }
		public Category(object pObject) : base(pObject) { }
		public Category(int pId, object pObject) : base(pId, pObject) { }
	}
}
