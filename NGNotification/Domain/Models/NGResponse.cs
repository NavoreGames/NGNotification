using System.Collections.Generic;
using NGNotification.Interfaces;

namespace NGNotification.Models
{
    public class NGResponse
    {
        public NGResponse(bool success, int code, List<INGNotification> notifications, object data)
        {
            Success = success;
            Code = code;
            Data = data;
            Notifications = notifications;
        }
        public NGResponse(bool success, int code, List<INGNotification> notifications) : this(success, code, notifications, null) { }
        public NGResponse(bool success, object data) : this(success, 200, null, data) { }
        public NGResponse(bool success) : this(success, null) { }
        public bool Success { get; private set; }
        public int Code { get; private set; }
        public List<INGNotification> Notifications { get; private set; }
        public object Data { get; private set; }
    }
}
