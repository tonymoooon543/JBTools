using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBLog.API;

namespace JBLog
{
    public partial class LogEditor : Form
    {
        public LogEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log.AddLog(logName.Text, logDate.Text, logCon.Text, Feeling.Text);
            this.Close();
        }
    }
}
