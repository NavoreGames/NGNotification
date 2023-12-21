using System;
using NGNotification.Enum;
using NGNotification.Interface;

namespace NGNotification
{
    public class NGNotification : Exception, INGNotification
    {
        public Category Category { get; set; }
        public string Header { get; set; }
        public new string Message { get; set; }
    }
}
