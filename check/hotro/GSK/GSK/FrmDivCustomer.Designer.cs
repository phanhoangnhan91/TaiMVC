﻿namespace GSK
{
    partial class FrmDivCustomer
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnback = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnDMSReprot = new System.Windows.Forms.Button();
            this.TxtfileExcelDMSReport = new System.Windows.Forms.TextBox();
            this.BtnFileDMS = new System.Windows.Forms.Button();
            this.TxtfileExcelDMS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 39);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Công cụ hổ trợ chia khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Btnback);
            this.groupBox2.Controls.Add(this.BtnLogin);
            this.groupBox2.Controls.Add(this.BtnDMSReprot);
            this.groupBox2.Controls.Add(this.TxtfileExcelDMSReport);
            this.groupBox2.Controls.Add(this.BtnFileDMS);
            this.groupBox2.Controls.Add(this.TxtfileExcelDMS);
            this.groupBox2.Location = new System.Drawing.Point(397, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DMS Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DMS";
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(379, 95);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(75, 23);
            this.Btnback.TabIndex = 11;
            this.Btnback.Text = "Thoát";
            this.Btnback.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(298, 95);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Đồng ý";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnDMSReprot
            // 
            this.BtnDMSReprot.Location = new System.Drawing.Point(379, 57);
            this.BtnDMSReprot.Name = "BtnDMSReprot";
            this.BtnDMSReprot.Size = new System.Drawing.Size(75, 23);
            this.BtnDMSReprot.TabIndex = 8;
            this.BtnDMSReprot.Text = "Chọn file";
            this.BtnDMSReprot.UseVisualStyleBackColor = true;
            this.BtnDMSReprot.Click += new System.EventHandler(this.BtnDMSReprot_Click);
            // 
            // TxtfileExcelDMSReport
            // 
            this.TxtfileExcelDMSReport.Location = new System.Drawing.Point(88, 57);
            this.TxtfileExcelDMSReport.Name = "TxtfileExcelDMSReport";
            this.TxtfileExcelDMSReport.ReadOnly = true;
            this.TxtfileExcelDMSReport.Size = new System.Drawing.Size(285, 20);
            this.TxtfileExcelDMSReport.TabIndex = 9;
            // 
            // BtnFileDMS
            // 
            this.BtnFileDMS.Location = new System.Drawing.Point(379, 28);
            this.BtnFileDMS.Name = "BtnFileDMS";
            this.BtnFileDMS.Size = new System.Drawing.Size(75, 23);
            this.BtnFileDMS.TabIndex = 6;
            this.BtnFileDMS.Text = "Chọn file";
            this.BtnFileDMS.UseVisualStyleBackColor = true;
            this.BtnFileDMS.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // TxtfileExcelDMS
            // 
            this.TxtfileExcelDMS.Location = new System.Drawing.Point(88, 31);
            this.TxtfileExcelDMS.Name = "TxtfileExcelDMS";
            this.TxtfileExcelDMS.ReadOnly = true;
            this.TxtfileExcelDMS.Size = new System.Drawing.Size(285, 20);
            this.TxtfileExcelDMS.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 907);
            this.panel1.TabIndex = 2;
            // 
            // FrmDivCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 907);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDivCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chia Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDMSReprot;
        private System.Windows.Forms.TextBox TxtfileExcelDMSReport;
        private System.Windows.Forms.Button BtnFileDMS;
        private System.Windows.Forms.TextBox TxtfileExcelDMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btnback;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}