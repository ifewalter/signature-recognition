namespace SignatureRecognition
{
    partial class AppSettings
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
            this.components = new System.ComponentModel.Container();
            this.errorLevelLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backupGroupBox = new System.Windows.Forms.GroupBox();
            this.backupDetail = new System.Windows.Forms.Label();
            this.restoreBackup = new System.Windows.Forms.Button();
            this.makebackupbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.settingGroupBox.SuspendLayout();
            this.backupGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLevelLabel
            // 
            this.errorLevelLabel.AutoSize = true;
            this.errorLevelLabel.Location = new System.Drawing.Point(20, 26);
            this.errorLevelLabel.Name = "errorLevelLabel";
            this.errorLevelLabel.Size = new System.Drawing.Size(58, 13);
            this.errorLevelLabel.TabIndex = 0;
            this.errorLevelLabel.Text = "Error Level";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormatString = "N1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2.0"});
            this.comboBox1.Location = new System.Drawing.Point(93, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.toolTip1.SetToolTip(this.comboBox1, "Changing the error level affect the overall accuracy of training and recognition");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Controls.Add(this.label1);
            this.settingGroupBox.Controls.Add(this.errorLevelLabel);
            this.settingGroupBox.Controls.Add(this.comboBox1);
            this.settingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(281, 108);
            this.settingGroupBox.TabIndex = 2;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Application Settings";
            this.settingGroupBox.Visible = false;
            this.settingGroupBox.Enter += new System.EventHandler(this.settingGroupBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Changing error level affects training and recognition.";
            // 
            // backupGroupBox
            // 
            this.backupGroupBox.Controls.Add(this.backupDetail);
            this.backupGroupBox.Controls.Add(this.restoreBackup);
            this.backupGroupBox.Controls.Add(this.makebackupbutton);
            this.backupGroupBox.Location = new System.Drawing.Point(11, 260);
            this.backupGroupBox.Name = "backupGroupBox";
            this.backupGroupBox.Size = new System.Drawing.Size(281, 118);
            this.backupGroupBox.TabIndex = 3;
            this.backupGroupBox.TabStop = false;
            this.backupGroupBox.Text = "Application Backup";
            // 
            // backupDetail
            // 
            this.backupDetail.AutoSize = true;
            this.backupDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backupDetail.Location = new System.Drawing.Point(20, 23);
            this.backupDetail.Name = "backupDetail";
            this.backupDetail.Size = new System.Drawing.Size(99, 13);
            this.backupDetail.TabIndex = 2;
            this.backupDetail.Text = "Last Backup: None";
            // 
            // restoreBackup
            // 
            this.restoreBackup.Location = new System.Drawing.Point(9, 88);
            this.restoreBackup.Name = "restoreBackup";
            this.restoreBackup.Size = new System.Drawing.Size(124, 23);
            this.restoreBackup.TabIndex = 1;
            this.restoreBackup.Text = "Restore Backup";
            this.restoreBackup.UseVisualStyleBackColor = true;
            this.restoreBackup.Click += new System.EventHandler(this.restoreBackup_Click);
            // 
            // makebackupbutton
            // 
            this.makebackupbutton.Location = new System.Drawing.Point(150, 88);
            this.makebackupbutton.Name = "makebackupbutton";
            this.makebackupbutton.Size = new System.Drawing.Size(122, 23);
            this.makebackupbutton.TabIndex = 0;
            this.makebackupbutton.Text = "Make Backup";
            this.makebackupbutton.UseVisualStyleBackColor = true;
            this.makebackupbutton.Click += new System.EventHandler(this.makebackupbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceptance Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please set the acceptable percentage of correctness";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backupGroupBox);
            this.Controls.Add(this.settingGroupBox);
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppSettings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.backupGroupBox.ResumeLayout(false);
            this.backupGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label errorLevelLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox backupGroupBox;
        private System.Windows.Forms.Button restoreBackup;
        private System.Windows.Forms.Button makebackupbutton;
        private System.Windows.Forms.Label backupDetail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}