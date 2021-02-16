using System;
using System.Windows.Forms;
using System.Xml;
using JBLog.API;
using System.IO;

namespace JBLog
{
    public partial class Form1 : Form
    {
        public bool logsFound = true;
        public string XmlFile = "Logs.xml";
        public string logNameToEdit;
        public string logDateToEdit;
        public string logConToEdit;
        public string logFeelToEdit;

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

            try
            {
                // Goes through the XML and reads the Log Nodes
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].Value; // Finds the name attribute of the parent node
                    string date = node["Date"].InnerText; // Finds the value of the 'Date' node
                    string logcon = node["LogContents"].InnerText; // Finds the value of the 'LogContents' node
                    string feel = node["Feeling"].InnerText; // Find the value of the 'Feeling' node
                    // Adds the Log to the List Box
                    LogListBox.Items.Add(new Log(name, date, logcon, feel));
                }
            }
            catch(XmlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                logsFound = false;
            }
            
        }

        /// <summary>
        /// When the SelectedIndex of the ListBox changes, update the log TextBoxs and the PropetyGrid
        /// </summary>
        private void LogListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LogListBox.SelectedIndex != -1)
            {
                // Enables the edit button, so you can edit logs
                editBtn.Enabled = true;
                // Enables the delete button
                delBtn.Enabled = true;

                // Adds the contents of the selected ListBox item to the Textboxs
                Log selectedLog = LogListBox.Items[LogListBox.SelectedIndex] as Log;
                logNameTextBox.Text = selectedLog.LogName;
                dateTextBox.Text = selectedLog.date;
                logContentsTextBox.Text = selectedLog.logContents;
                feelingTextBox.Text = selectedLog.feeling;
            }
            else
            {
                MessageBox.Show("Invalid Index Selected");
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

        /// <summary>
        /// Opens the log editor, so you can create a new log
        /// </summary>
        private void newLog_Click(object sender, EventArgs e)
        {
            LogEditor newlog = new LogEditor();
            newlog.Show();
        }

        // Same thing as newLog_Click
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEditor newlog = new LogEditor();
            newlog.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            childThings.Text = Log.EditLog(logNameTextBox.Text);
        }
    }
}
