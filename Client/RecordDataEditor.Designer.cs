﻿namespace Client
{
    partial class RecordDataEditor
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
            this.StringField = new System.Windows.Forms.TextBox();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            this.RecordDataID = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StringField
            // 
            this.StringField.Location = new System.Drawing.Point(74, 16);
            this.StringField.Name = "StringField";
            this.StringField.Size = new System.Drawing.Size(290, 20);
            this.StringField.TabIndex = 0;
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(74, 65);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(290, 20);
            this.DateField.TabIndex = 1;
            // 
            // RecordDataID
            // 
            this.RecordDataID.Location = new System.Drawing.Point(0, 112);
            this.RecordDataID.Name = "RecordDataID";
            this.RecordDataID.Size = new System.Drawing.Size(380, 22);
            this.RecordDataID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "StringField";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DateField";
            // 
            // RecordDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordDataID);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.StringField);
            this.Name = "RecordDataEditor";
            this.Text = "RecordDataEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordDataEditor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringField;
        private System.Windows.Forms.DateTimePicker DateField;
        private System.Windows.Forms.StatusStrip RecordDataID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}