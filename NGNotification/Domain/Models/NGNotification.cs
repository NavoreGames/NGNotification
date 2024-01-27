using System;
using NGNotification.Enums;
using NGNotification.Interfaces;

namespace NGNotification.Models
{
    public class NGNotification : Exception, INGNotification
    {
        public Category Category { get; set; }
        public string Header { get; set; }
        public new string Message { get; set; }
    }
}
