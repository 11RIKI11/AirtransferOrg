using Serilog;
using КП.Forms;

namespace КП.Infrastructure
{
    public static class Logger
    {
        private static RichTextBox logDisplay;

        static Logger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

        }

        /// <summary>
        /// Устанавливает RichTextBox для отображения логов.
        /// </summary>
        public static void SetLogDisplay(RichTextBox richTextBox)
        {
            logDisplay = richTextBox;
        }

        /// <summary>
        /// Логирует информационное сообщение.
        /// </summary>
        public static void Info(string message)
        {
            Log.Information(message);
            DisplayLog("INFO", message);
        }

        /// <summary>
        /// Логирует предупреждение.
        /// </summary>
        public static void Warning(string message)
        {
            Log.Warning(message);
            DisplayLog("WARNING", message);
        }

        /// <summary>
        /// Логирует ошибку.
        /// </summary>
        public static void Error(string message)
        {
            Log.Error(message);
            DisplayLog("ERROR", message);
        }

        private static void DisplayLog(string level, string message)
        {
            if (logDisplay != null)
            {
                string logEntry = $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}";
                logDisplay.Invoke(new Action(() => logDisplay.AppendText(logEntry + Environment.NewLine)));
            }
        }
    }
}
