﻿
namespace SeqDistKPlus
{
    partial class FormSequence
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(593, 450);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            // 
            // FormSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.rtbMain);
            this.Name = "FormSequence";
            this.Text = "FormSequence";
            this.Load += new System.EventHandler(this.FormSequence_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
    }
}