﻿using System.Drawing;
using System.Windows.Forms;

namespace Fuzenet_Data_Checker
{
    partial class Fuzenet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fuzenet));
            this.internetUsageBar = new System.Windows.Forms.ProgressBar();
            this.dataLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.increasedAmountLabel = new System.Windows.Forms.Label();
            this.webBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // internetUsageBar
            // 
            this.internetUsageBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.internetUsageBar.Location = new System.Drawing.Point(0, 0);
            this.internetUsageBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.internetUsageBar.Name = "internetUsageBar";
            this.internetUsageBar.Size = new System.Drawing.Size(716, 62);
            this.internetUsageBar.TabIndex = 2;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(0, 62);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(291, 30);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "Used ??? MB of ??? MB";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.ForeColor = System.Drawing.Color.Transparent;
            this.percentageLabel.Location = new System.Drawing.Point(324, 17);
            this.percentageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(64, 30);
            this.percentageLabel.TabIndex = 5;
            this.percentageLabel.Text = "??%";
            // 
            // increasedAmountLabel
            // 
            this.increasedAmountLabel.AutoSize = true;
            this.increasedAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increasedAmountLabel.Location = new System.Drawing.Point(0, 92);
            this.increasedAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.increasedAmountLabel.Name = "increasedAmountLabel";
            this.increasedAmountLabel.Size = new System.Drawing.Size(117, 29);
            this.increasedAmountLabel.TabIndex = 6;
            this.increasedAmountLabel.Text = "+???? MB";
            // 
            // webBtn
            // 
            this.webBtn.BackgroundImage = global::Fuzenet_Data_Checker.Properties.Resources.web;
            this.webBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.webBtn.Location = new System.Drawing.Point(482, 62);
            this.webBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.webBtn.Name = "webBtn";
            this.webBtn.Size = new System.Drawing.Size(70, 67);
            this.webBtn.TabIndex = 8;
            this.webBtn.UseVisualStyleBackColor = true;
            this.webBtn.Click += new System.EventHandler(this.webBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackgroundImage = global::Fuzenet_Data_Checker.Properties.Resources.information;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutBtn.Location = new System.Drawing.Point(646, 62);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(70, 67);
            this.aboutBtn.TabIndex = 7;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImage = global::Fuzenet_Data_Checker.Properties.Resources.Settings;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsBtn.Location = new System.Drawing.Point(564, 62);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(70, 67);
            this.settingsBtn.TabIndex = 9;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // Fuzenet
            // 
            this.AcceptButton = this.aboutBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 131);
            this.Controls.Add(this.webBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.increasedAmountLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.internetUsageBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fuzenet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fuzenet Data Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar internetUsageBar;
        private Button settingsBtn;
        private Label dataLabel;
        private Label percentageLabel;
        private Label increasedAmountLabel;
        private Button aboutBtn;
        private Button webBtn;
    }
}

