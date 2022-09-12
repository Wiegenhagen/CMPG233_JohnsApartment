
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormEditResident
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
            this.components = new System.ComponentModel.Container();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAccnum = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvResidents = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCell = new System.Windows.Forms.ErrorProvider(this.components);
            this.epID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBranch = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAccNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbBranch = new System.Windows.Forms.ComboBox();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccNum)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.tbBranch);
            this.gbEdit.Controls.Add(this.tbAccNum);
            this.gbEdit.Controls.Add(this.tbID);
            this.gbEdit.Controls.Add(this.tbCell);
            this.gbEdit.Controls.Add(this.tbSurname);
            this.gbEdit.Controls.Add(this.tbName);
            this.gbEdit.Controls.Add(this.lblAccnum);
            this.gbEdit.Controls.Add(this.lblBranch);
            this.gbEdit.Controls.Add(this.lblID);
            this.gbEdit.Controls.Add(this.lblCell);
            this.gbEdit.Controls.Add(this.lblSurname);
            this.gbEdit.Controls.Add(this.lblName);
            this.gbEdit.Location = new System.Drawing.Point(12, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(339, 325);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit Resident Details (Please occupy all fields) :";
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(157, 268);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(140, 20);
            this.tbAccNum.TabIndex = 11;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(157, 175);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(140, 20);
            this.tbID.TabIndex = 9;
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(157, 128);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(140, 20);
            this.tbCell.TabIndex = 8;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(157, 76);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(140, 20);
            this.tbSurname.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(157, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 20);
            this.tbName.TabIndex = 6;
            // 
            // lblAccnum
            // 
            this.lblAccnum.AutoSize = true;
            this.lblAccnum.Location = new System.Drawing.Point(21, 271);
            this.lblAccnum.Name = "lblAccnum";
            this.lblAccnum.Size = new System.Drawing.Size(90, 13);
            this.lblAccnum.TabIndex = 5;
            this.lblAccnum.Text = "Account Number:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(21, 222);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(66, 13);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "Bank Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 178);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Number:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(21, 131);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(67, 13);
            this.lblCell.TabIndex = 2;
            this.lblCell.Text = "Cell Number:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 79);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // dgvResidents
            // 
            this.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidents.Location = new System.Drawing.Point(357, 12);
            this.dgvResidents.Name = "dgvResidents";
            this.dgvResidents.RowHeadersWidth = 62;
            this.dgvResidents.Size = new System.Drawing.Size(567, 325);
            this.dgvResidents.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 43);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(184, 361);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 43);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(800, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epSurname
            // 
            this.epSurname.ContainerControl = this;
            // 
            // epCell
            // 
            this.epCell.ContainerControl = this;
            // 
            // epID
            // 
            this.epID.ContainerControl = this;
            // 
            // epBranch
            // 
            this.epBranch.ContainerControl = this;
            // 
            // epAccNum
            // 
            this.epAccNum.ContainerControl = this;
            // 
            // tbBranch
            // 
            this.tbBranch.FormattingEnabled = true;
            this.tbBranch.Items.AddRange(new object[] {
            "Standard Bank\t",
            "FirstRand",
            "Absa",
            "NedBank",
            "Investec ",
            "Capitec",
            "FNB"});
            this.tbBranch.Location = new System.Drawing.Point(176, 219);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.Size = new System.Drawing.Size(121, 21);
            this.tbBranch.TabIndex = 12;
            // 
            // FormEditResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvResidents);
            this.Controls.Add(this.gbEdit);
            this.Name = "FormEditResident";
            this.Text = "FormEditResident";
            this.Load += new System.EventHandler(this.FormEditResident_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblAccnum;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvResidents;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epSurname;
        private System.Windows.Forms.ErrorProvider epCell;
        private System.Windows.Forms.ErrorProvider epID;
        private System.Windows.Forms.ErrorProvider epBranch;
        private System.Windows.Forms.ErrorProvider epAccNum;
        private System.Windows.Forms.ComboBox tbBranch;
    }
}