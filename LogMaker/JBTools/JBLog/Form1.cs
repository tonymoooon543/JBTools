using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using JBLog.API;

namespace JBLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLogs();
        }

        /// <summary>
        /// Read the Logs.xml file, and loads them into the LogListBox
        /// </summary>
        private void LoadLogs()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Logs.xml");

            // Goes through the XML and reads the Log Nodes
            foreach(XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string date = node["Date"].InnerText;
                string logcon = node["LogContents"].InnerText;
                string feel = node["Feeling"].InnerText;
                // Adds the Log to the List Box
                LogListBox.Items.Add(new Log(name, date, logcon, feel));
            }
        }

        /// <summary>
        /// When the SelectedIndex of the ListBox changes, update the log TextBoxs and the PropetyGrid
        /// </summary>
        private void LogListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LogListBox.SelectedIndex != -1)
            {
                // Adds the contents of the selected ListBox item to the PropertyGrid
                propertyGrid1.SelectedObject = LogListBox.SelectedItem;

                // Adds the contents of the selected ListBox item to the Textboxs
                Log selectedLog = LogListBox.Items[LogListBox.SelectedIndex] as Log;
                logNameTextBox.Text = selectedLog.LogName;
                dateTextBox.Text = selectedLog.date;
                logContentsTextBox.Text = selectedLog.logContents;
                feelingTextBox.Text = selectedLog.feeling;
            }
        }

        #region ButtonThings
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
        #endregion
    }
}
