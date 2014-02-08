#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * IBackPropagation.cs
 * -------------------------------------------------------------------------
 * By
 * Ronke Ajibade, Ifeoluwa Okpah, Murat FIRAT, - April 2011
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion
namespace SignatureRecognition
{
    partial class Train
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
            this.idGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudLabel2 = new CloudToolkitN6.CloudLabel();
            this.nameBox1 = new CloudToolkitN6.CloudTextBox();
            this.cloudLabel1 = new CloudToolkitN6.CloudLabel();
            this.idTextBox = new CloudToolkitN6.CloudTextBox();
            this.idLabel = new CloudToolkitN6.CloudLabel();
            this.trainingGroup = new System.Windows.Forms.GroupBox();
            this.imageGroup = new System.Windows.Forms.GroupBox();
            this.imageBox8 = new System.Windows.Forms.GroupBox();
            this.browseButton8 = new System.Windows.Forms.Button();
            this.signature8 = new System.Windows.Forms.PictureBox();
            this.imageBox7 = new System.Windows.Forms.GroupBox();
            this.browseButton7 = new System.Windows.Forms.Button();
            this.signature7 = new System.Windows.Forms.PictureBox();
            this.imageBox6 = new System.Windows.Forms.GroupBox();
            this.browseButton6 = new System.Windows.Forms.Button();
            this.signature6 = new System.Windows.Forms.PictureBox();
            this.imageBox3 = new System.Windows.Forms.GroupBox();
            this.browseButton3 = new System.Windows.Forms.Button();
            this.signature3 = new System.Windows.Forms.PictureBox();
            this.imageBox5 = new System.Windows.Forms.GroupBox();
            this.browseButton5 = new System.Windows.Forms.Button();
            this.signature5 = new System.Windows.Forms.PictureBox();
            this.imageBox2 = new System.Windows.Forms.GroupBox();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.signature2 = new System.Windows.Forms.PictureBox();
            this.imageBox4 = new System.Windows.Forms.GroupBox();
            this.browseButton4 = new System.Windows.Forms.Button();
            this.signature4 = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new System.Windows.Forms.GroupBox();
            this.browseButton1 = new System.Windows.Forms.Button();
            this.signature1 = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new CloudToolkitN6.CloudLabel();
            this.trainButton = new CloudToolkitN6.CloudButton();
            this.generalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idGroupBox.SuspendLayout();
            this.trainingGroup.SuspendLayout();
            this.imageGroup.SuspendLayout();
            this.imageBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature8)).BeginInit();
            this.imageBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature7)).BeginInit();
            this.imageBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature6)).BeginInit();
            this.imageBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature3)).BeginInit();
            this.imageBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature5)).BeginInit();
            this.imageBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature2)).BeginInit();
            this.imageBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature4)).BeginInit();
            this.imageBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature1)).BeginInit();
            this.SuspendLayout();
            // 
            // idGroupBox
            // 
            this.idGroupBox.Controls.Add(this.cloudLabel2);
            this.idGroupBox.Controls.Add(this.nameBox1);
            this.idGroupBox.Controls.Add(this.cloudLabel1);
            this.idGroupBox.Controls.Add(this.idTextBox);
            this.idGroupBox.Controls.Add(this.idLabel);
            this.idGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idGroupBox.Location = new System.Drawing.Point(12, 12);
            this.idGroupBox.Name = "idGroupBox";
            this.idGroupBox.Size = new System.Drawing.Size(613, 121);
            this.idGroupBox.TabIndex = 0;
            this.idGroupBox.TabStop = false;
            this.idGroupBox.Text = "Identification";
            this.idGroupBox.Enter += new System.EventHandler(this.idGroupBox_Enter);
            // 
            // cloudLabel2
            // 
            this.cloudLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cloudLabel2.AutoSize = true;
            this.cloudLabel2.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel2.Location = new System.Drawing.Point(22, 21);
            this.cloudLabel2.Name = "cloudLabel2";
            this.cloudLabel2.Size = new System.Drawing.Size(178, 13);
            this.cloudLabel2.TabIndex = 4;
            this.cloudLabel2.Text = "Please give an identity for the individual";
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(111, 86);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(290, 20);
            this.nameBox1.TabIndex = 3;
            this.nameBox1.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.generalToolTip.SetToolTip(this.nameBox1, "Please enter the name of the individual");
            this.nameBox1.Visible = false;
            // 
            // cloudLabel1
            // 
            this.cloudLabel1.AutoSize = true;
            this.cloudLabel1.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel1.Location = new System.Drawing.Point(70, 89);
            this.cloudLabel1.Name = "cloudLabel1";
            this.cloudLabel1.Size = new System.Drawing.Size(31, 13);
            this.cloudLabel1.TabIndex = 2;
            this.cloudLabel1.Text = "Name";
            this.cloudLabel1.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(111, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(290, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.generalToolTip.SetToolTip(this.idTextBox, "Please Enter an ID to recognise the user.");
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_DoneEditing);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.idLabel.Location = new System.Drawing.Point(70, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // trainingGroup
            // 
            this.trainingGroup.Controls.Add(this.imageGroup);
            this.trainingGroup.Controls.Add(this.instructionLabel);
            this.trainingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingGroup.Location = new System.Drawing.Point(12, 147);
            this.trainingGroup.Name = "trainingGroup";
            this.trainingGroup.Size = new System.Drawing.Size(613, 344);
            this.trainingGroup.TabIndex = 1;
            this.trainingGroup.TabStop = false;
            this.trainingGroup.Text = "Training Images";
            // 
            // imageGroup
            // 
            this.imageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageGroup.Controls.Add(this.imageBox8);
            this.imageGroup.Controls.Add(this.imageBox7);
            this.imageGroup.Controls.Add(this.imageBox6);
            this.imageGroup.Controls.Add(this.imageBox3);
            this.imageGroup.Controls.Add(this.imageBox5);
            this.imageGroup.Controls.Add(this.imageBox2);
            this.imageGroup.Controls.Add(this.imageBox4);
            this.imageGroup.Controls.Add(this.imageBox1);
            this.imageGroup.Location = new System.Drawing.Point(9, 41);
            this.imageGroup.Name = "imageGroup";
            this.imageGroup.Size = new System.Drawing.Size(598, 297);
            this.imageGroup.TabIndex = 1;
            this.imageGroup.TabStop = false;
            // 
            // imageBox8
            // 
            this.imageBox8.Controls.Add(this.browseButton8);
            this.imageBox8.Controls.Add(this.signature8);
            this.imageBox8.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox8.Location = new System.Drawing.Point(202, 200);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(190, 89);
            this.imageBox8.TabIndex = 6;
            this.imageBox8.TabStop = false;
            this.imageBox8.Text = "Eighth Signature ";
            // 
            // browseButton8
            // 
            this.browseButton8.AutoSize = true;
            this.browseButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton8.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton8.Location = new System.Drawing.Point(132, 60);
            this.browseButton8.Name = "browseButton8";
            this.browseButton8.Size = new System.Drawing.Size(47, 23);
            this.browseButton8.TabIndex = 1;
            this.browseButton8.Text = "Browse";
            this.browseButton8.UseVisualStyleBackColor = true;
            this.browseButton8.Click += new System.EventHandler(this.button8_Click);
            // 
            // signature8
            // 
            this.signature8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature8.Location = new System.Drawing.Point(6, 19);
            this.signature8.Name = "signature8";
            this.signature8.Size = new System.Drawing.Size(120, 64);
            this.signature8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature8.TabIndex = 0;
            this.signature8.TabStop = false;
            // 
            // imageBox7
            // 
            this.imageBox7.Controls.Add(this.browseButton7);
            this.imageBox7.Controls.Add(this.signature7);
            this.imageBox7.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox7.Location = new System.Drawing.Point(6, 200);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(190, 89);
            this.imageBox7.TabIndex = 5;
            this.imageBox7.TabStop = false;
            this.imageBox7.Text = "Seventh Signature";
            // 
            // browseButton7
            // 
            this.browseButton7.AutoSize = true;
            this.browseButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton7.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton7.Location = new System.Drawing.Point(132, 60);
            this.browseButton7.Name = "browseButton7";
            this.browseButton7.Size = new System.Drawing.Size(47, 23);
            this.browseButton7.TabIndex = 1;
            this.browseButton7.Text = "Browse";
            this.browseButton7.UseVisualStyleBackColor = true;
            this.browseButton7.Click += new System.EventHandler(this.browseButton7_Click);
            // 
            // signature7
            // 
            this.signature7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature7.Location = new System.Drawing.Point(6, 19);
            this.signature7.Name = "signature7";
            this.signature7.Size = new System.Drawing.Size(120, 64);
            this.signature7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature7.TabIndex = 0;
            this.signature7.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.Controls.Add(this.browseButton6);
            this.imageBox6.Controls.Add(this.signature6);
            this.imageBox6.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox6.Location = new System.Drawing.Point(398, 105);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(190, 89);
            this.imageBox6.TabIndex = 4;
            this.imageBox6.TabStop = false;
            this.imageBox6.Text = "Sixth Signature";
            // 
            // browseButton6
            // 
            this.browseButton6.AutoSize = true;
            this.browseButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton6.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton6.Location = new System.Drawing.Point(132, 60);
            this.browseButton6.Name = "browseButton6";
            this.browseButton6.Size = new System.Drawing.Size(47, 23);
            this.browseButton6.TabIndex = 1;
            this.browseButton6.Text = "Browse";
            this.browseButton6.UseVisualStyleBackColor = true;
            this.browseButton6.Click += new System.EventHandler(this.browseButton6_Click);
            // 
            // signature6
            // 
            this.signature6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature6.Location = new System.Drawing.Point(6, 19);
            this.signature6.Name = "signature6";
            this.signature6.Size = new System.Drawing.Size(120, 64);
            this.signature6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature6.TabIndex = 0;
            this.signature6.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Controls.Add(this.browseButton3);
            this.imageBox3.Controls.Add(this.signature3);
            this.imageBox3.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox3.Location = new System.Drawing.Point(398, 10);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(190, 89);
            this.imageBox3.TabIndex = 3;
            this.imageBox3.TabStop = false;
            this.imageBox3.Text = "Third Signature";
            // 
            // browseButton3
            // 
            this.browseButton3.AutoSize = true;
            this.browseButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton3.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton3.Location = new System.Drawing.Point(132, 60);
            this.browseButton3.Name = "browseButton3";
            this.browseButton3.Size = new System.Drawing.Size(47, 23);
            this.browseButton3.TabIndex = 1;
            this.browseButton3.Text = "Browse";
            this.browseButton3.UseVisualStyleBackColor = true;
            this.browseButton3.Click += new System.EventHandler(this.browseButton3_Click);
            // 
            // signature3
            // 
            this.signature3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature3.Location = new System.Drawing.Point(6, 19);
            this.signature3.Name = "signature3";
            this.signature3.Size = new System.Drawing.Size(120, 64);
            this.signature3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature3.TabIndex = 0;
            this.signature3.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.Controls.Add(this.browseButton5);
            this.imageBox5.Controls.Add(this.signature5);
            this.imageBox5.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox5.Location = new System.Drawing.Point(202, 105);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(190, 89);
            this.imageBox5.TabIndex = 2;
            this.imageBox5.TabStop = false;
            this.imageBox5.Text = "Fifth Signature";
            // 
            // browseButton5
            // 
            this.browseButton5.AutoSize = true;
            this.browseButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton5.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton5.Location = new System.Drawing.Point(132, 60);
            this.browseButton5.Name = "browseButton5";
            this.browseButton5.Size = new System.Drawing.Size(47, 23);
            this.browseButton5.TabIndex = 1;
            this.browseButton5.Text = "Browse";
            this.browseButton5.UseVisualStyleBackColor = true;
            this.browseButton5.Click += new System.EventHandler(this.browseButton5_Click);
            // 
            // signature5
            // 
            this.signature5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature5.Location = new System.Drawing.Point(6, 19);
            this.signature5.Name = "signature5";
            this.signature5.Size = new System.Drawing.Size(120, 64);
            this.signature5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature5.TabIndex = 0;
            this.signature5.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Controls.Add(this.browseButton2);
            this.imageBox2.Controls.Add(this.signature2);
            this.imageBox2.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox2.Location = new System.Drawing.Point(202, 10);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(190, 89);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Text = "Second Signature";
            // 
            // browseButton2
            // 
            this.browseButton2.AutoSize = true;
            this.browseButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton2.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Location = new System.Drawing.Point(132, 60);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(47, 23);
            this.browseButton2.TabIndex = 1;
            this.browseButton2.Text = "Browse";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // signature2
            // 
            this.signature2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature2.Location = new System.Drawing.Point(6, 19);
            this.signature2.Name = "signature2";
            this.signature2.Size = new System.Drawing.Size(120, 64);
            this.signature2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature2.TabIndex = 0;
            this.signature2.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.Controls.Add(this.browseButton4);
            this.imageBox4.Controls.Add(this.signature4);
            this.imageBox4.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox4.Location = new System.Drawing.Point(6, 105);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(190, 89);
            this.imageBox4.TabIndex = 1;
            this.imageBox4.TabStop = false;
            this.imageBox4.Text = "Fourth Signature";
            // 
            // browseButton4
            // 
            this.browseButton4.AutoSize = true;
            this.browseButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton4.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton4.Location = new System.Drawing.Point(132, 60);
            this.browseButton4.Name = "browseButton4";
            this.browseButton4.Size = new System.Drawing.Size(47, 23);
            this.browseButton4.TabIndex = 1;
            this.browseButton4.Text = "Browse";
            this.browseButton4.UseVisualStyleBackColor = true;
            this.browseButton4.Click += new System.EventHandler(this.browseButton4_Click);
            // 
            // signature4
            // 
            this.signature4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature4.Location = new System.Drawing.Point(6, 19);
            this.signature4.Name = "signature4";
            this.signature4.Size = new System.Drawing.Size(120, 64);
            this.signature4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature4.TabIndex = 0;
            this.signature4.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Controls.Add(this.browseButton1);
            this.imageBox1.Controls.Add(this.signature1);
            this.imageBox1.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox1.Location = new System.Drawing.Point(6, 10);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(190, 89);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            this.imageBox1.Text = "First Signature";
            // 
            // browseButton1
            // 
            this.browseButton1.AutoSize = true;
            this.browseButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton1.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton1.Location = new System.Drawing.Point(132, 60);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(47, 23);
            this.browseButton1.TabIndex = 1;
            this.browseButton1.Text = "Browse";
            this.browseButton1.UseVisualStyleBackColor = true;
            this.browseButton1.Click += new System.EventHandler(this.browseButton1_Click);
            // 
            // signature1
            // 
            this.signature1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signature1.Location = new System.Drawing.Point(6, 19);
            this.signature1.Name = "signature1";
            this.signature1.Size = new System.Drawing.Size(120, 64);
            this.signature1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature1.TabIndex = 0;
            this.signature1.TabStop = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.instructionLabel.Location = new System.Drawing.Point(44, 25);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(236, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Please select 8 scaned images containing the signature";
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.Transparent;
            this.trainButton.ButtonText = "Train";
            this.trainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainButton.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.trainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(152)))));
            this.trainButton.Icon = null;
            this.trainButton.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.trainButton.IconSpacingX = 5;
            this.trainButton.IconSpacingY = 5;
            this.trainButton.IconTransparency = 0F;
            this.trainButton.Location = new System.Drawing.Point(420, 512);
            this.trainButton.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.trainButton.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.trainButton.Name = "trainButton";
            this.trainButton.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.trainButton.Size = new System.Drawing.Size(205, 33);
            this.trainButton.TabIndex = 2;
            this.trainButton.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.trainButton.TextSpacingX = 5;
            this.trainButton.TextSpacingY = 5;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 557);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.trainingGroup);
            this.Controls.Add(this.idGroupBox);
            this.Name = "Train";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train";
            this.Load += new System.EventHandler(this.Train_Load);
            this.idGroupBox.ResumeLayout(false);
            this.idGroupBox.PerformLayout();
            this.trainingGroup.ResumeLayout(false);
            this.trainingGroup.PerformLayout();
            this.imageGroup.ResumeLayout(false);
            this.imageBox8.ResumeLayout(false);
            this.imageBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature8)).EndInit();
            this.imageBox7.ResumeLayout(false);
            this.imageBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature7)).EndInit();
            this.imageBox6.ResumeLayout(false);
            this.imageBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature6)).EndInit();
            this.imageBox3.ResumeLayout(false);
            this.imageBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature3)).EndInit();
            this.imageBox5.ResumeLayout(false);
            this.imageBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature5)).EndInit();
            this.imageBox2.ResumeLayout(false);
            this.imageBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature2)).EndInit();
            this.imageBox4.ResumeLayout(false);
            this.imageBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature4)).EndInit();
            this.imageBox1.ResumeLayout(false);
            this.imageBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signature1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox idGroupBox;
        private CloudToolkitN6.CloudTextBox nameBox1;
        private CloudToolkitN6.CloudLabel cloudLabel1;
        private CloudToolkitN6.CloudTextBox idTextBox;
        private CloudToolkitN6.CloudLabel idLabel;
        private System.Windows.Forms.GroupBox trainingGroup;
        private System.Windows.Forms.GroupBox imageGroup;
        private CloudToolkitN6.CloudLabel instructionLabel;
        private System.Windows.Forms.GroupBox imageBox1;
        private System.Windows.Forms.GroupBox imageBox5;
        private System.Windows.Forms.Button browseButton5;
        private System.Windows.Forms.PictureBox signature5;
        private System.Windows.Forms.GroupBox imageBox2;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.PictureBox signature2;
        private System.Windows.Forms.GroupBox imageBox4;
        private System.Windows.Forms.Button browseButton4;
        private System.Windows.Forms.PictureBox signature4;
        private System.Windows.Forms.Button browseButton1;
        private System.Windows.Forms.PictureBox signature1;
        private System.Windows.Forms.GroupBox imageBox8;
        private System.Windows.Forms.Button browseButton8;
        private System.Windows.Forms.PictureBox signature8;
        private System.Windows.Forms.GroupBox imageBox7;
        private System.Windows.Forms.Button browseButton7;
        private System.Windows.Forms.PictureBox signature7;
        private System.Windows.Forms.GroupBox imageBox6;
        private System.Windows.Forms.Button browseButton6;
        private System.Windows.Forms.PictureBox signature6;
        private System.Windows.Forms.GroupBox imageBox3;
        private System.Windows.Forms.Button browseButton3;
        private System.Windows.Forms.PictureBox signature3;
        private CloudToolkitN6.CloudButton trainButton;
        private System.Windows.Forms.ToolTip generalToolTip;
        private CloudToolkitN6.CloudLabel cloudLabel2;
    }
}