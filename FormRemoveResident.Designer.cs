
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormRemoveResident
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
            this.gbRemove = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvResidents = new System.Windows.Forms.DataGridView();
            this.gbRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRemove
            // 
            this.gbRemove.Controls.Add(this.btnCancel);
            this.gbRemove.Controls.Add(this.btnRefresh);
            this.gbRemove.Controls.Add(this.tbID);
            this.gbRemove.Controls.Add(this.btnRemove);
            this.gbRemove.Controls.Add(this.lblID);
            this.gbRemove.Location = new System.Drawing.Point(12, 12);
            this.gbRemove.Name = "gbRemove";
            this.gbRemove.Size = new System.Drawing.Size(200, 241);
            this.gbRemove.TabIndex = 1;
            this.gbRemove.TabStop = false;
            this.gbRemove.Text = "Remove Resident:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(51, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(96, 139);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 43);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(6, 80);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(162, 20);
            this.tbID.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 139);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 43);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(113, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Number of resident:";
            // 
            // dgvResidents
            // 
            this.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidents.Location = new System.Drawing.Point(245, 12);
            this.dgvResidents.Name = "dgvResidents";
            this.dgvResidents.Size = new System.Drawing.Size(543, 241);
            this.dgvResidents.TabIndex = 2;
            // 
            // FormRemoveResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.dgvResidents);
            this.Controls.Add(this.gbRemove);
            this.Name = "FormRemoveResident";
            this.Text = "FormRemoveResident";
            this.Load += new System.EventHandler(this.FormRemoveResident_Load);
            this.gbRemove.ResumeLayout(false);
            this.gbRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvResidents;
    }
}