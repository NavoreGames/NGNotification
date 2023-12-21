using System;
using System.Linq;
using System.Collections.Generic;
using NGNotification.Interface;
using NGNotification.Extension;
using NGNotification.Enum;

namespace NGNotification
{
	public static class NGNotifier
	{
		private static List<INGNotification> Notifications { get; set; }
		public static bool HasNotifications => Notifications?.Any() ?? false;

		private static List<INGNotification> IsInitialize()
		{
			if (Notifications == null)
				Notifications = new List<INGNotification>();

			return Notifications;
		}

		public static List<INGNotification> Return()
		{
			List<INGNotification> retorno = new List<INGNotification>(IsInitialize());
			Notifications.Clear();

			return retorno;
		}
		public static void Add(INGNotification firstNotification, params INGNotification[] OtherNotifications)
		{
			IsInitialize().Add(firstNotification);
			if (OtherNotifications.Any())
				IsInitialize().AddRange(OtherNotifications);
		}
		public static T Add<T>(T ret, INGNotification firstNotification, params INGNotification[] OtherNotifications)
		{
			Add(firstNotification, OtherNotifications);
			return ret;
		}
		public static T Add<T>(INGNotification firstNotification, params INGNotification[] OtherNotifications) =>
			Add<T>(default, firstNotification, OtherNotifications);

		#region ///// ADDLOG /////
		public static void AddLog(string header, string message) => 
			Add(new NGNotification() { Category = Category.Log, Header = header, Message = message });
		public static void AddLog(string message) => 
			AddLog("", message);
		public static T AddLog<T>(T ret, string header, string message) 
		{ 
			AddLog(header, message);
			return ret; 
		}
		public static T AddLog<T>(T ret, string message) =>
			AddLog<T>(ret, "", message);
		public static T AddLog<T>(string header, string message) =>
			AddLog<T>(default, header, message);
		public static T AddLog<T>(string message) =>
			AddLog<T>(default, "", message);
		#endregion

		#region ///// ADDMESSAGE /////
		public static void AddMessage(string header, string message) =>
			Add(new NGNotification() { Category = Category.Message, Header = header, Message = message });
		public static void AddMessage(string message) =>
			AddMessage("", message);
		public static T AddMessage<T>(T ret, string header, string message)
		{
			AddMessage(header, message);
			return ret;
		}
		public static T AddMessage<T>(T ret, string message) =>
			AddMessage<T>(ret, "", message);
		public static T AddMessage<T>(string header, string message) =>
			AddMessage<T>(default, header, message);
		public static T AddMessage<T>(string message) =>
			AddMessage<T>(default, "", message);
		#endregion

		#region ///// ADDINFORMATION /////
		public static void AddInformation(string header, string message) =>
			Add(new NGNotification() { Category = Category.Information, Header = header, Message = message });
		public static void AddInformation(string message) =>
			AddInformation("", message);
		public static T AddInformation<T>(T ret, string header, string message)
		{
			AddInformation(header, message);
			return ret;
		}
		public static T AddInformation<T>(T ret, string message) =>
			AddInformation<T>(ret, "", message);
		public static T AddInformation<T>(string header, string message) =>
			AddInformation<T>(default, header, message);
		public static T AddInformation<T>(string message) =>
			AddInformation<T>(default, "", message);
		#endregion

		#region ///// ADDWARNING /////
		public static void AddWarning(string header, string message) =>
			Add(new NGNotification() { Category = Category.Warning, Header = header, Message = message });
		public static void AddWarning(string message) =>
			AddWarning("", message);
		public static T AddWarning<T>(T ret, string header, string message)
		{
			AddWarning(header, message);
			return ret;
		}
		public static T AddWarning<T>(T ret, string message) =>
			AddWarning<T>(ret, "", message);
		public static T AddWarning<T>(string header, string message) =>
			AddWarning<T>(default, header, message);
		public static T AddWarning<T>(string message) =>
			AddWarning<T>(default, "", message);
		#endregion

		#region ///// ADDERROR /////
		public static void AddError(string header, string message) =>
			Add(new NGNotification() { Category = Category.Error, Header = header, Message = message });
		public static void AddError(string message) =>
			AddError("", message);
		public static T AddError<T>(T ret, string header, string message)
		{
			AddError(header, message);
			return ret;
		}
		public static T AddError<T>(T ret, string message) =>
			AddError<T>(ret, "", message);
		public static T AddError<T>(string header, string message) =>
			AddError<T>(default, header, message);
		public static T AddError<T>(string message) =>
			AddError<T>(default, "", message);
		#endregion
	}
}