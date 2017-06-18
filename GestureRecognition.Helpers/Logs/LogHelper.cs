using System;
using System.IO;

namespace GestureRecognition.Helpers.Logs
{
    public static class LogHelper
    {
        public static void MessageToLog(string message)
        {
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                Log(message, sw);
            }
        }

        private static void Log(string logMessage, TextWriter sw)
        {
            sw.Write("\r\nLog Entry : ");
            sw.WriteLine("");
            sw.WriteLine("Time: {0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            sw.WriteLine("Message: {0}", logMessage);
            sw.WriteLine(new String('-', 110));
        }
    }
}
