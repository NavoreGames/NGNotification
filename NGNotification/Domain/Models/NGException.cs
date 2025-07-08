using NGNotification.Enums;

namespace NGNotification.Models
{
    public class NGException : NGMessage
    {
        public string Trace { get; set; }
        public string Sujestion { get; set; }

        public NGException(string header, string message, string sujestion, string trace)
        {
            Category = Category.Error;
            Header = header;
            Message = message;
            Sujestion = sujestion;
            Trace = trace;
        }
        public NGException(string header, string message, string sujestion) : this(header, message, sujestion, "") { }
        public NGException(string header, string message) : this(header, message, "","") { }
        public NGException(string message) : this("", message) { }
        public NGException() { }

    }
}
