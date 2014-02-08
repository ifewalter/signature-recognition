namespace SignatureRecognition
{
    partial class Verify
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
            this.idGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signatureLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.trainingResultGroupBox = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.idGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.trainingResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idGroupBox
            // 
            this.idGroupBox.Controls.Add(this.browseButton);
            this.idGroupBox.Controls.Add(this.pictureBox1);
            this.idGroupBox.Controls.Add(this.signatureLabel);
            this.idGroupBox.Controls.Add(this.idTextBox);
            this.idGroupBox.Controls.Add(this.idLabel);
            this.idGroupBox.Location = new System.Drawing.Point(26, 23);
            this.idGroupBox.Name = "idGroupBox";
            this.idGroupBox.Size = new System.Drawing.Size(384, 192);
            this.idGroupBox.TabIndex = 0;
            this.idGroupBox.TabStop = false;
            this.idGroupBox.Text = "Identification";
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.Location = new System.Drawing.Point(93, 163);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(185, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Choose Signature";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(93, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 111);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // signatureLabel
            // 
            this.signatureLabel.AutoSize = true;
            this.signatureLabel.Location = new System.Drawing.Point(6, 79);
            this.signatureLabel.Name = "signatureLabel";
            this.signatureLabel.Size = new System.Drawing.Size(52, 13);
            this.signatureLabel.TabIndex = 2;
            this.signatureLabel.Text = "Signature";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(40, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(326, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // trainingResultGroupBox
            // 
            this.trainingResultGroupBox.Controls.Add(this.Result);
            this.trainingResultGroupBox.Location = new System.Drawing.Point(53, 221);
            this.trainingResultGroupBox.Name = "trainingResultGroupBox";
            this.trainingResultGroupBox.Size = new System.Drawing.Size(339, 93);
            this.trainingResultGroupBox.TabIndex = 1;
            this.trainingResultGroupBox.TabStop = false;
            this.trainingResultGroupBox.Text = "Verification Result";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(43, 37);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(93, 13);
            this.Result.TabIndex = 0;
            this.Result.Text = "Waiting for input...";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(281, 329);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(129, 23);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 354);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.trainingResultGroupBox);
            this.Controls.Add(this.idGroupBox);
            this.Name = "Verify";
            this.Text = "Verification";
            this.Load += new System.EventHandler(this.Verify_Load);
            this.idGroupBox.ResumeLayout(false);
            this.idGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.trainingResultGroupBox.ResumeLayout(false);
            this.trainingResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox idGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox trainingResultGroupBox;
        private System.Windows.Forms.Label signatureLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label Result;
    }
}