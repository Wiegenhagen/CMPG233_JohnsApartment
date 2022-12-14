
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class ResidentsReportForm
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
            this.lblResTitle = new System.Windows.Forms.Label();
            this.lstbxResidents = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFDResidents = new System.Windows.Forms.SaveFileDialog();
            this.lblSort = new System.Windows.Forms.Label();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblResTitle
            // 
            this.lblResTitle.AutoSize = true;
            this.lblResTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTitle.Location = new System.Drawing.Point(267, 13);
            this.lblResTitle.Name = "lblResTitle";
            this.lblResTitle.Size = new System.Drawing.Size(245, 29);
            this.lblResTitle.TabIndex = 0;
            this.lblResTitle.Text = "Report of Residents";
            // 
            // lstbxResidents
            // 
            this.lstbxResidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxResidents.FormattingEnabled = true;
            this.lstbxResidents.ItemHeight = 16;
            this.lstbxResidents.Location = new System.Drawing.Point(26, 45);
            this.lstbxResidents.Name = "lstbxResidents";
            this.lstbxResidents.Size = new System.Drawing.Size(731, 324);
            this.lstbxResidents.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(26, 474);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(317, 474);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(177, 56);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Preview of Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(580, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(136, 410);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(253, 25);
            this.lblSort.TabIndex = 5;
            this.lblSort.Text = "Sort by Last name alfabetic:";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYes.Location = new System.Drawing.Point(436, 412);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(58, 24);
            this.rbtnYes.TabIndex = 6;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // ResidentsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 583);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstbxResidents);
            this.Controls.Add(this.lblResTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResidentsReportForm";
            this.Text = "Residents Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResTitle;
        private System.Windows.Forms.ListBox lstbxResidents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFDResidents;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton rbtnYes;
    }
}