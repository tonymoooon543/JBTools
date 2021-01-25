using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBLog.API
{
    class Log
    {
        public string LogName { get; set; }
        public string date { get; set; }
        public string logContents { get; set; }
        public string feeling { get; set; }

        public Log(string logName, string Date, string LogContents, string Feeling)
        {
            LogName = logName;
            date = Date;
            logContents = LogContents;
            feeling = Feeling;
        }
    }
}
