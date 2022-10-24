using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OverPutty
{
    class Log
    {
        List<string> logLines = null;
        string exePath;

        public Log()
        {
            exePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!exePath.EndsWith(@"\"))
            {
                exePath += @"\";
            }
            logLines = File.ReadAllLines(exePath + "log.log").ToList();
        }

        public void LogAdd(string txt)
        {
            string now = DateTime.Now.ToString(@"yyyy-MM-dd hh:mm:ss");
            logLines.Add(now + " " + txt);
            while (logLines.Count > 10000)
            {
                logLines.RemoveAt(0);
            }

            TextWriter logFile = new StreamWriter(exePath + "log.log");
            foreach (string buf in logLines)
            {
                logFile.WriteLine(buf);
            }
            logFile.Close();
        }

    }
}
