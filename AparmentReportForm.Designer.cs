
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class AparmentReportForm
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
            this.lblApartTitle = new System.Windows.Forms.Label();
            this.lstbxApart = new System.Windows.Forms.ListBox();
            this.lstbxRes = new System.Windows.Forms.ListBox();
            this.lstbxApartReport = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblApartTitle
            // 
            this.lblApartTitle.AutoSize = true;
            this.lblApartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartTitle.Location = new System.Drawing.Point(272, 37);
            this.lblApartTitle.Name = "lblApartTitle";
            this.lblApartTitle.Size = new System.Drawing.Size(259, 29);
            this.lblApartTitle.TabIndex = 0;
            this.lblApartTitle.Text = "Report of Apartments";
            // 
            // lstbxApart
            // 
            this.lstbxApart.Enabled = false;
            this.lstbxApart.FormattingEnabled = true;
            this.lstbxApart.ItemHeight = 16;
            this.lstbxApart.Location = new System.Drawing.Point(25, 37);
            this.lstbxApart.Name = "lstbxApart";
            this.lstbxApart.Size = new System.Drawing.Size(120, 84);
            this.lstbxApart.TabIndex = 1;
            this.lstbxApart.Visible = false;
            // 
            // lstbxRes
            // 
            this.lstbxRes.Enabled = false;
            this.lstbxRes.FormattingEnabled = true;
            this.lstbxRes.ItemHeight = 16;
            this.lstbxRes.Location = new System.Drawing.Point(618, 37);
            this.lstbxRes.Name = "lstbxRes";
            this.lstbxRes.Size = new System.Drawing.Size(120, 84);
            this.lstbxRes.TabIndex = 2;
            this.lstbxRes.Visible = false;
            // 
            // lstbxApartReport
            // 
            this.lstbxApartReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxApartReport.FormattingEnabled = true;
            this.lstbxApartReport.ItemHeight = 16;
            this.lstbxApartReport.Location = new System.Drawing.Point(12, 69);
            this.lstbxApartReport.Name = "lstbxApartReport";
            this.lstbxApartReport.Size = new System.Drawing.Size(809, 388);
            this.lstbxApartReport.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(12, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 77);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(325, 504);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(191, 77);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Preview of Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(630, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 77);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AparmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 598);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstbxApartReport);
            this.Controls.Add(this.lstbxRes);
            this.Controls.Add(this.lstbxApart);
            this.Controls.Add(this.lblApartTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AparmentReportForm";
            this.Text = "Apartment Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApartTitle;
        private System.Windows.Forms.ListBox lstbxRes;
        private System.Windows.Forms.ListBox lstbxApartReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstbxApart;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}