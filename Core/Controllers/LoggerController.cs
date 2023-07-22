using System;
using System.IO;

namespace Core.Controllers
{
    public static class LoggerController
    {
        public static string CurrentDateTime => _dateTime.ToString("dd.MM.yyyy (HH.mm.ss)");
        private static readonly string _fileName = "_log.txt";

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

        public static void WriteLog(object obj)
        {
            if (obj is string[] array)
            {
                foreach (var item in array)
                {
                    AppendLine(item);
                }
            }
            else if (obj is string str)
            {
                var splits = str.Split(new char[] { (char)10, (char)13 }, StringSplitOptions.RemoveEmptyEntries);
                if (splits != null && splits.Length > 0)
                {
                    foreach (var item in splits)
                    {
                        AppendLine(item);
                    }
                }
                else
                {
                    AppendLine(str);
                }
            }
        }
        private static string AppendLine(string text)
        {
            var obj = $"{CurrentDateTime} -> {text}{Environment.NewLine}";
            File.AppendAllText(_fileName, obj);
            return obj;
        }
    }
}
