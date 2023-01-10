using System;
using System.IO;
using System.Text;

namespace ACT.CfFusen
{
    public class Logging
    {
        private static Logging singleton = null;
        private static string logFilePath = null;
        private readonly static object lockObj = new object();
        private static StreamWriter stream = null;

        public static void Init()
        {
            if (singleton == null)
            {
                singleton = new Logging();
            }

            logFilePath = $"{DateTime.Now:yyyy_MM_dd_HH.mm.ss}.log";

            // ログファイルを生成する
            stream = new StreamWriter(logFilePath, true, Encoding.UTF8)
            {
                AutoFlush = true
            };
        }

        public static void Exception(Exception ex)
        {
            OutLog(ex.ToString());
        }

        public static void Debug(string message)
        {
#if DEBUG
            OutLog(message);
#endif //DEBUG
        }

        private static void OutLog(string msg)
        {
            if (stream == null)
            {
                Init();
            }
#if DEBUG
            System.Diagnostics.Debug.WriteLine(msg);
#endif //DEBUG

            int tid = System.Threading.Thread.CurrentThread.ManagedThreadId;
            string fullMsg = string.Format("[{0}][{1}] {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), tid, msg);

            lock (lockObj)
            {
                stream.WriteLine(fullMsg);
            }
        }
    }
}
