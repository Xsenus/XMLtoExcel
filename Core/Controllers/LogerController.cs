using System;

namespace Core.Controllers
{
    public static class LogerController
    {
        private static DateTime _dateTime => DateTime.Now;
        private static string _message;
        public static string GetMessage()
        {
            return _message;
        }

        public static void ClearMessage()
        {
            _message = default;
        }

        public static void AddMessage(string msg)
        {
            _message += $"[{_dateTime.ToShortDateString()} ({_dateTime:HH:mm:ss})] {msg}{Environment.NewLine}";
        }
    }
}
