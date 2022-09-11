
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FullReportForm
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
            this.lstbxBank = new System.Windows.Forms.ListBox();
            this.lstbxResident = new System.Windows.Forms.ListBox();
            this.lstbxFullReport = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lstbxApartment = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstbxTemp = new System.Windows.Forms.ListBox();
            this.lstbxTemp2 = new System.Windows.Forms.ListBox();
            this.lstbxBankResult = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFDFull = new System.Windows.Forms.SaveFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxBank
            // 
            this.lstbxBank.Enabled = false;
            this.lstbxBank.FormattingEnabled = true;
            this.lstbxBank.ItemHeight = 16;
            this.lstbxBank.Location = new System.Drawing.Point(13, 13);
            this.lstbxBank.Name = "lstbxBank";
            this.lstbxBank.Size = new System.Drawing.Size(120, 84);
            this.lstbxBank.TabIndex = 0;
            this.lstbxBank.Visible = false;
            // 
            // lstbxResident
            // 
            this.lstbxResident.Enabled = false;
            this.lstbxResident.FormattingEnabled = true;
            this.lstbxResident.ItemHeight = 16;
            this.lstbxResident.Location = new System.Drawing.Point(1232, 13);
            this.lstbxResident.Name = "lstbxResident";
            this.lstbxResident.Size = new System.Drawing.Size(120, 84);
            this.lstbxResident.TabIndex = 1;
            this.lstbxResident.Visible = false;
            // 
            // lstbxFullReport
            // 
            this.lstbxFullReport.FormattingEnabled = true;
            this.lstbxFullReport.ItemHeight = 16;
            this.lstbxFullReport.Location = new System.Drawing.Point(13, 117);
            this.lstbxFullReport.MultiColumn = true;
            this.lstbxFullReport.Name = "lstbxFullReport";
            this.lstbxFullReport.ScrollAlwaysVisible = true;
            this.lstbxFullReport.Size = new System.Drawing.Size(1389, 324);
            this.lstbxFullReport.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(586, 487);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(246, 79);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Preview of Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(456, 526);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(0, 20);
            this.lblBankName.TabIndex = 6;
            // 
            // lstbxApartment
            // 
            this.lstbxApartment.Enabled = false;
            this.lstbxApartment.FormattingEnabled = true;
            this.lstbxApartment.ItemHeight = 16;
            this.lstbxApartment.Location = new System.Drawing.Point(1106, 12);
            this.lstbxApartment.Name = "lstbxApartment";
            this.lstbxApartment.Size = new System.Drawing.Size(120, 84);
            this.lstbxApartment.TabIndex = 8;
            this.lstbxApartment.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(13, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(246, 79);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstbxTemp
            // 
            this.lstbxTemp.Enabled = false;
            this.lstbxTemp.FormattingEnabled = true;
            this.lstbxTemp.ItemHeight = 16;
            this.lstbxTemp.Location = new System.Drawing.Point(139, 12);
            this.lstbxTemp.Name = "lstbxTemp";
            this.lstbxTemp.Size = new System.Drawing.Size(120, 84);
            this.lstbxTemp.TabIndex = 10;
            this.lstbxTemp.Visible = false;
            // 
            // lstbxTemp2
            // 
            this.lstbxTemp2.Enabled = false;
            this.lstbxTemp2.FormattingEnabled = true;
            this.lstbxTemp2.ItemHeight = 16;
            this.lstbxTemp2.Location = new System.Drawing.Point(265, 12);
            this.lstbxTemp2.Name = "lstbxTemp2";
            this.lstbxTemp2.Size = new System.Drawing.Size(120, 84);
            this.lstbxTemp2.TabIndex = 11;
            this.lstbxTemp2.Visible = false;
            // 
            // lstbxBankResult
            // 
            this.lstbxBankResult.FormattingEnabled = true;
            this.lstbxBankResult.ItemHeight = 16;
            this.lstbxBankResult.Location = new System.Drawing.Point(980, 12);
            this.lstbxBankResult.Name = "lstbxBankResult";
            this.lstbxBankResult.Size = new System.Drawing.Size(120, 84);
            this.lstbxBankResult.TabIndex = 12;
            this.lstbxBankResult.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(1156, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(246, 79);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(480, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 39);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Full Report of JohnsApartments";
            // 
            // FullReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 592);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstbxBankResult);
            this.Controls.Add(this.lstbxTemp2);
            this.Controls.Add(this.lstbxTemp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstbxApartment);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstbxFullReport);
            this.Controls.Add(this.lstbxResident);
            this.Controls.Add(this.lstbxBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FullReportForm";
            this.Text = "Full Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxBank;
        private System.Windows.Forms.ListBox lstbxResident;
        private System.Windows.Forms.ListBox lstbxFullReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.ListBox lstbxApartment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstbxTemp;
        private System.Windows.Forms.ListBox lstbxTemp2;
        private System.Windows.Forms.ListBox lstbxBankResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFDFull;
        private System.Windows.Forms.Label lblTitle;
    }
}