using System;
using System.Linq;
using System.Collections.Generic;
using NGNotification.Interface;
using NGNotification.Extension;
using NGNotification.Enum;

namespace NGNotification
{
	public class Notification
	{
		public List<INGNotification> Notifications { get; private set; }
		public bool HasNotifications => Notifications.Any();

		public Notification() { Notifications = new List<INGNotification>(); }

		private Notification IsInitialize()
		{
			if (Notifications == null)
				Notifications = new List<INGNotification>();

			return this;
		}
		private Notification Clean()
		{
			Notifications.Clear();
			return this;
		}
		private INGNotification Add(INGNotification notifications)
		{
			Notifications.Add(notifications);
			return notifications;
		}

		public Notification AddNotification(Exception exception)
		{
			IsInitialize().Add(new NGException(Category.Error, exception.Message, exception.ToString()));
			return this;
		}
		public Notification AddNotification(Category category, Exception exception)
		{
			IsInitialize().Add(new NGException(category, exception.Message, exception.ToString()));
			return this;
		}

		public INGNotification AddNotification(INGNotification notifications) => IsInitialize().Add(notifications);
		public INGNotification NewNotification(INGNotification notifications) => IsInitialize().Clean().Add(notifications);

		public void AddNotifications(params INGNotification[] notifications) => IsInitialize().Notifications.AddRange(notifications);
		public void NewNotifications(params INGNotification[] notifications) => IsInitialize().Clean().Notifications.AddRange(notifications);

		public INGNotification AddNotification(Category category, string header, string message, string question) => IsInitialize().Add(new NGMessage(category, header, message, question));
		public INGNotification AddNotification(Category category, string header, string message)
		{
			if (category.CompareAny(Category.Error, Category.Fatal))
				return IsInitialize().Add(new NGMessage(category, header, message));
			else
				return IsInitialize().Add(new NGException(category, header, message));
		}
		public INGNotification AddNotification(Category category, string message)
		{
			if(category.CompareAny(Category.Error, Category.Fatal))
				return IsInitialize().Add(new NGMessage(category, message));
			else
				return IsInitialize().Add(new NGException(category, message));
		}
	}
}
