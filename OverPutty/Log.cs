using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverPutty
{
    class Log
    {
        StringWriter logFile = null;

        public Log()
        {
            string exePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if(!exePath.EndsWith(@"\"))
            {
                exePath += @"\";
            }
            logFile = new StringWriter(exePath+"log.log");
        }
    }
}
