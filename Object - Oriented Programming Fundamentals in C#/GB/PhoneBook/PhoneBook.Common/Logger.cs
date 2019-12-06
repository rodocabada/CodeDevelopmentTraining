using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhoneBook.Common
{
    public class Logger
    {
        private static string _strLogPath = @"C:\LogsPhoneBook\";

        public static void WriteLog(IEnumerable<ILogger> items)
        {
            try
            {
                if (!File.Exists(_strLogPath))
                {
                    Directory.CreateDirectory(_strLogPath);
                }

                var logPath = $@"{_strLogPath}\{DateTime.Now:yyyy-MM-dd}.log";
                using (var logger = new StreamWriter(logPath, true))
                {
                    items.ToList().ForEach(_ => logger.WriteLine($"{DateTime.Now} | {_.Log()}"));
                }
            }
            catch
            {
                //ignored
            }
        }
    }
}
