﻿namespace ViwerSteps
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1_filename = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_status = new System.Windows.Forms.Button();
            this.label1_per = new System.Windows.Forms.Label();
            this.button_token = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_key = new System.Windows.Forms.TextBox();
            this.textBox_Consumer_Secret = new System.Windows.Forms.TextBox();
            this.label2_Consumer_Secret = new System.Windows.Forms.Label();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBucketName = new System.Windows.Forms.TextBox();
            this.btnCreateBucket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Upload file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1_filename
            // 
            this.label1_filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_filename.Location = new System.Drawing.Point(246, 205);
            this.label1_filename.Name = "label1_filename";
            this.label1_filename.Size = new System.Drawing.Size(725, 40);
            this.label1_filename.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(246, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 247);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 171);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_status
            // 
            this.button_status.Location = new System.Drawing.Point(32, 263);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(196, 40);
            this.button_status.TabIndex = 7;
            this.button_status.Text = "Status";
            this.button_status.UseVisualStyleBackColor = true;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            // 
            // label1_per
            // 
            this.label1_per.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_per.Location = new System.Drawing.Point(246, 263);
            this.label1_per.Name = "label1_per";
            this.label1_per.Size = new System.Drawing.Size(725, 40);
            this.label1_per.TabIndex = 8;
            // 
            // button_token
            // 
            this.button_token.Location = new System.Drawing.Point(32, 100);
            this.button_token.Name = "button_token";
            this.button_token.Size = new System.Drawing.Size(196, 38);
            this.button_token.TabIndex = 9;
            this.button_token.Text = "Token";
            this.button_token.UseVisualStyleBackColor = true;
            this.button_token.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consumer Key:";
            // 
            // textBox1_key
            // 
            this.textBox1_key.Location = new System.Drawing.Point(246, 19);
            this.textBox1_key.Name = "textBox1_key";
            this.textBox1_key.Size = new System.Drawing.Size(431, 25);
            this.textBox1_key.TabIndex = 11;
            // 
            // textBox_Consumer_Secret
            // 
            this.textBox_Consumer_Secret.Location = new System.Drawing.Point(246, 64);
            this.textBox_Consumer_Secret.Name = "textBox_Consumer_Secret";
            this.textBox_Consumer_Secret.Size = new System.Drawing.Size(431, 25);
            this.textBox_Consumer_Secret.TabIndex = 13;
            // 
            // label2_Consumer_Secret
            // 
            this.label2_Consumer_Secret.Location = new System.Drawing.Point(88, 64);
            this.label2_Consumer_Secret.Name = "label2_Consumer_Secret";
            this.label2_Consumer_Secret.Size = new System.Drawing.Size(140, 21);
            this.label2_Consumer_Secret.TabIndex = 12;
            this.label2_Consumer_Secret.Text = "Consumer Secret:";
            // 
            // textBox_token
            // 
            this.textBox_token.Location = new System.Drawing.Point(246, 109);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.Size = new System.Drawing.Size(431, 25);
            this.textBox_token.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(81, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bucket Name:";
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(246, 154);
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(431, 25);
            this.txtBucketName.TabIndex = 16;
            // 
            // btnCreateBucket
            // 
            this.btnCreateBucket.Location = new System.Drawing.Point(694, 146);
            this.btnCreateBucket.Name = "btnCreateBucket";
            this.btnCreateBucket.Size = new System.Drawing.Size(196, 38);
            this.btnCreateBucket.TabIndex = 17;
            this.btnCreateBucket.Text = "Create Bucket";
            this.btnCreateBucket.UseVisualStyleBackColor = true;
            this.btnCreateBucket.Click += new System.EventHandler(this.btnCreateBucket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 579);
            this.Controls.Add(this.btnCreateBucket);
            this.Controls.Add(this.txtBucketName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_token);
            this.Controls.Add(this.textBox_Consumer_Secret);
            this.Controls.Add(this.label2_Consumer_Secret);
            this.Controls.Add(this.textBox1_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_token);
            this.Controls.Add(this.label1_per);
            this.Controls.Add(this.button_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1_filename);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Autodesk One viewer - .NET App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1_filename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Label label1_per;
        private System.Windows.Forms.Button button_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_key;
        private System.Windows.Forms.TextBox textBox_Consumer_Secret;
        private System.Windows.Forms.Label label2_Consumer_Secret;
        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBucketName;
        private System.Windows.Forms.Button btnCreateBucket;

    }
}

