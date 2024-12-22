using System.Linq;
using System.Collections.Generic;
using NGNotification.Interfaces;
using NGNotification.Enums;
using Models = NGNotification.Models;
using System.Data;

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

        public static void Clear() { IsInitialize().Clear(); }
        public static List<INGNotification> GetNotifications(bool clear = true)
        {
            List<INGNotification> retorno = new List<INGNotification>(IsInitialize());

            if(clear)
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
       
        #region ///// ADDLOG /////
        public static void AddLog(string header, string message) =>
            Add(new Models.NGMessage() { Category = Category.Log, Header = header, Message = message });
        public static void AddLog(string message) =>
            AddLog("", message);
        public static T AddLog<T>(T ret, string header, string message)
        {
            AddLog(header, message);
            return ret;
        }
        public static T AddLog<T>(T ret, string message) =>
            AddLog(ret, "", message);
        #endregion

        #region ///// ADDMESSAGE /////
        public static void AddMessage(string header, string message) =>
            Add(new Models.NGMessage() { Category = Category.Message, Header = header, Message = message });
        public static void AddMessage(string message) =>
            AddMessage("", message);
        public static T AddMessage<T>(T ret, string header, string message)
        {
            AddMessage(header, message);
            return ret;
        }
        public static T AddMessage<T>(T ret, string message) =>
            AddMessage(ret, "", message);
        #endregion

        #region ///// ADDINFORMATION /////
        public static void AddInformation(string header, string message) =>
            Add(new Models.NGMessage() { Category = Category.Information, Header = header, Message = message });
        public static void AddInformation(string message) =>
            AddInformation("", message);
        public static T AddInformation<T>(T ret, string header, string message)
        {
            AddInformation(header, message);
            return ret;
        }
        public static T AddInformation<T>(T ret, string message) =>
            AddInformation(ret, "", message);
        #endregion

        #region ///// ADDWARNING /////
        public static void AddWarning(string header, string message) =>
            Add(new Models.NGMessage() { Category = Category.Warning, Header = header, Message = message });
        public static void AddWarning(string message) =>
            AddWarning("", message);
        public static T AddWarning<T>(T ret, string header, string message)
        {
            AddWarning(header, message);
            return ret;
        }
        public static T AddWarning<T>(T ret, string message) =>
            AddWarning(ret, "", message);
        #endregion

        #region ///// ADDERROR /////
        public static void AddError(string header, string message) =>
            Add(new Models.NGMessage() { Category = Category.Error, Header = header, Message = message });
        public static void AddError(string message) =>
            AddError("", message);
        public static T AddError<T>(T ret, string header, string message)
        {
            AddError(header, message);
            return ret;
        }
        public static T AddError<T>(T ret, string message) =>
            AddError(ret, "", message);
        #endregion
    }
}