
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class GenericReportForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBankName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstbxFullReport = new System.Windows.Forms.ListBox();
            this.saveFDFull = new System.Windows.Forms.SaveFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(912, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 76);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(246, 450);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(223, 74);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(457, 519);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(0, 20);
            this.lblBankName.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Silver;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(577, 449);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(229, 76);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Preview of Report";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstbxFullReport
            // 
            this.lstbxFullReport.FormattingEnabled = true;
            this.lstbxFullReport.ItemHeight = 16;
            this.lstbxFullReport.Location = new System.Drawing.Point(15, 111);
            this.lstbxFullReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbxFullReport.MultiColumn = true;
            this.lstbxFullReport.Name = "lstbxFullReport";
            this.lstbxFullReport.ScrollAlwaysVisible = true;
            this.lstbxFullReport.Size = new System.Drawing.Size(1389, 324);
            this.lstbxFullReport.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(394, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 39);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Full Report of JohnsApartments";
            // 
            // GenericReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1455, 606);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstbxFullReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenericReportForm";
            this.Text = "GenericReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstbxFullReport;
        private System.Windows.Forms.SaveFileDialog saveFDFull;
        private System.Windows.Forms.Label lblTitle;
    }
}