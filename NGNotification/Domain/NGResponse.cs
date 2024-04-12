using System.Collections.Generic;
using System.Net.Http;
//using System.Threading;
using NGNotification.Interfaces;

namespace NGNotification
{
    public class NGResponse
    {
        public NGResponse(HttpResponseMessage httpResponseMessage, List<INGNotification> notifications)
        {
            Success = httpResponseMessage.IsSuccessStatusCode;
            Code = (int)httpResponseMessage.StatusCode;

            var retorno = httpResponseMessage.Content.ReadAsStringAsync();
            Data = retorno;
            Notifications = notifications;
        }
        public NGResponse(HttpResponseMessage httpResponseMessage) : this(httpResponseMessage, []) { }

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
