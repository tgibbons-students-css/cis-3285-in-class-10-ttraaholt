using System;

using CurrencyTrader.Contracts;
using System.IO;
using System.Windows.Forms;

namespace CurrencyTrader
{
    public class GuiLogger : ILogger
    {
        ListBox.ObjectCollection items;
        public GuiLogger(ListBox.ObjectCollection items)
        {
            this.items = items;
        }
        public void LogWarning(string message, params object[] args)
        {
            string status = String.Format(string.Concat("WARN: ", message), args);
            items.Add(status);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine(status);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            string status = String.Format(string.Concat("INFO: ", message), args);
            items.Add(status);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine(status);
            }
        }
    }
}
