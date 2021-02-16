
namespace JBLog
{
    partial class LogEditor
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
            this.logName = new System.Windows.Forms.TextBox();
            this.logDate = new System.Windows.Forms.TextBox();
            this.logCon = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Feeling = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logName
            // 
            this.logName.Location = new System.Drawing.Point(23, 33);
            this.logName.Name = "logName";
            this.logName.Size = new System.Drawing.Size(233, 20);
            this.logName.TabIndex = 0;
            // 
            // logDate
            // 
            this.logDate.Location = new System.Drawing.Point(23, 76);
            this.logDate.Name = "logDate";
            this.logDate.Size = new System.Drawing.Size(198, 20);
            this.logDate.TabIndex = 1;
            // 
            // logCon
            // 
            this.logCon.Location = new System.Drawing.Point(22, 126);
            this.logCon.Name = "logCon";
            this.logCon.Size = new System.Drawing.Size(351, 126);
            this.logCon.TabIndex = 2;
            this.logCon.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Feeling
            // 
            this.Feeling.Location = new System.Drawing.Point(23, 305);
            this.Feeling.Name = "Feeling";
            this.Feeling.Size = new System.Drawing.Size(198, 20);
            this.Feeling.TabIndex = 5;
            // 
            // LogEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 403);
            this.Controls.Add(this.Feeling);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logCon);
            this.Controls.Add(this.logDate);
            this.Controls.Add(this.logName);
            this.MaximizeBox = false;
            this.Name = "LogEditor";
            this.Text = "Log Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox logName;
        public System.Windows.Forms.TextBox logDate;
        public System.Windows.Forms.RichTextBox logCon;
        public System.Windows.Forms.TextBox Feeling;
    }
}