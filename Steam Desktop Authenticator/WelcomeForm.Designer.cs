﻿namespace Steam_Desktop_Authenticator
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJustStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎来到\r\nSteam 桌面身份验证器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportConfig.Location = new System.Drawing.Point(12, 134);
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.Size = new System.Drawing.Size(366, 51);
            this.btnImportConfig.TabIndex = 1;
            this.btnImportConfig.Text = "我已经在此电脑上的另一个位置设置了 Steam 桌面身份验证器，并且我想导入其帐户。\r\n";
            this.btnImportConfig.UseVisualStyleBackColor = true;
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJustStart
            // 
            this.btnJustStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustStart.Location = new System.Drawing.Point(12, 191);
            this.btnJustStart.Name = "btnJustStart";
            this.btnJustStart.Size = new System.Drawing.Size(366, 52);
            this.btnJustStart.TabIndex = 4;
            this.btnJustStart.Text = "这是我第一次并且\r\n我只想登录我的 Steam 帐户。";
            this.btnJustStart.UseVisualStyleBackColor = true;
            this.btnJustStart.Click += new System.EventHandler(this.btnJustStart_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 255);
            this.Controls.Add(this.btnJustStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportConfig);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam 桌面令牌";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJustStart;
    }
}