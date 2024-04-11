using System;
using NGNotification.Enums;
using NGNotification.Interfaces;

namespace NGNotification.Models
{
    public class NGMessage : Exception, INGNotification
    {
        public Category Category { get; set; }
        public string Header { get; set; }
        public new string Message { get; set; }

        public NGMessage(Category category, string header, string message)
        {
            _ = category;
            _ = header;
            _ = message;
        }
        public NGMessage(Category category, string message) : this(category, "", message) { }
        public NGMessage(string header, string message) : this(Category.None, header, message) { }
        public NGMessage(string message) : this(Category.None, "", message) { }
        public NGMessage() { }
    }
}
