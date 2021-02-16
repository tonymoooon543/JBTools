using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JBLog.API
{
    public class Log
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

        // Comment this
        static public bool AddLog(string logName, string Date, string LogContents, string Feeling)
        {
            var form1 = Application.OpenForms.OfType<Form1>().Single();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Logs.xml");
                XmlNode log = doc.CreateElement("Log");
                XmlAttribute logname = doc.CreateAttribute("logname");
                XmlNode date = doc.CreateElement("Date");
                XmlNode logcontents = doc.CreateElement("LogContents");
                XmlNode feeling = doc.CreateElement("Feeling");
                logname.InnerText = logName;
                date.InnerText = Date;
                logcontents.InnerText = LogContents;
                feeling.InnerText = Feeling;
                log.Attributes.Append(logname);
                log.AppendChild(date);
                log.AppendChild(logcontents);
                log.AppendChild(feeling);
                doc.DocumentElement.AppendChild(log);
                doc.Save("Logs.xml");

                form1.LogListBox.Items.Add(new Log(logName, Date, LogContents, Feeling));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Excexption: " + e.ToString(), "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteLog(string logName)
        {
            return false;
        }

        static public string EditLog(string logName)
        {
            XmlDocument docs = new XmlDocument();
            docs.Load("Logs.xml");
            XmlElement root = docs.DocumentElement;
            foreach (XmlNode nodes in root.ChildNodes)
            {
                if(nodes.Attributes[0].InnerText == logName)
                {
                    foreach(XmlNode childNode in nodes.ChildNodes)
                    {
                        
                        
                    }
                }
            }
            return "Log Not found";
        }
    }
}
