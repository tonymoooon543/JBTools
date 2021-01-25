namespace JBLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.logNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.logContentsTextBox = new System.Windows.Forms.RichTextBox();
            this.feelingTextBox = new System.Windows.Forms.TextBox();
            this.newLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(28, 68);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(307, 121);
            this.LogListBox.TabIndex = 1;
            this.LogListBox.SelectedIndexChanged += new System.EventHandler(this.LogListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(28, 195);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(307, 190);
            this.propertyGrid1.TabIndex = 3;
            // 
            // logNameTextBox
            // 
            this.logNameTextBox.Location = new System.Drawing.Point(359, 68);
            this.logNameTextBox.Name = "logNameTextBox";
            this.logNameTextBox.ReadOnly = true;
            this.logNameTextBox.Size = new System.Drawing.Size(362, 20);
            this.logNameTextBox.TabIndex = 5;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(359, 119);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(173, 20);
            this.dateTextBox.TabIndex = 6;
            // 
            // logContentsTextBox
            // 
            this.logContentsTextBox.Location = new System.Drawing.Point(359, 173);
            this.logContentsTextBox.Name = "logContentsTextBox";
            this.logContentsTextBox.ReadOnly = true;
            this.logContentsTextBox.Size = new System.Drawing.Size(349, 156);
            this.logContentsTextBox.TabIndex = 7;
            this.logContentsTextBox.Text = "";
            // 
            // feelingTextBox
            // 
            this.feelingTextBox.Location = new System.Drawing.Point(359, 365);
            this.feelingTextBox.Name = "feelingTextBox";
            this.feelingTextBox.ReadOnly = true;
            this.feelingTextBox.Size = new System.Drawing.Size(232, 20);
            this.feelingTextBox.TabIndex = 8;
            // 
            // newLog
            // 
            this.newLog.Location = new System.Drawing.Point(28, 39);
            this.newLog.Name = "newLog";
            this.newLog.Size = new System.Drawing.Size(75, 23);
            this.newLog.TabIndex = 9;
            this.newLog.Text = "New";
            this.newLog.UseVisualStyleBackColor = true;
            this.newLog.Click += new System.EventHandler(this.newLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Log Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log Contents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Log Feeling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newLog);
            this.Controls.Add(this.feelingTextBox);
            this.Controls.Add(this.logContentsTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.logNameTextBox);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " JBLog";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox logNameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.RichTextBox logContentsTextBox;
        private System.Windows.Forms.TextBox feelingTextBox;
        private System.Windows.Forms.Button newLog;
        public System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

