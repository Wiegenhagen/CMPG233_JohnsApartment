
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormAddNewResident
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
            this.gbAddResident = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbBank = new System.Windows.Forms.GroupBox();
            this.tbBranch = new System.Windows.Forms.ComboBox();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.cbContract = new System.Windows.Forms.CheckBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCell = new System.Windows.Forms.ErrorProvider(this.components);
            this.epID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBranch = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAccNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddResident.SuspendLayout();
            this.tbBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccNum)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddResident
            // 
            this.gbAddResident.Controls.Add(this.tbID);
            this.gbAddResident.Controls.Add(this.tbCell);
            this.gbAddResident.Controls.Add(this.tbSurname);
            this.gbAddResident.Controls.Add(this.tbName);
            this.gbAddResident.Controls.Add(this.lblID);
            this.gbAddResident.Controls.Add(this.lblCell);
            this.gbAddResident.Controls.Add(this.lblSurname);
            this.gbAddResident.Controls.Add(this.lblName);
            this.gbAddResident.Location = new System.Drawing.Point(12, 12);
            this.gbAddResident.Name = "gbAddResident";
            this.gbAddResident.Size = new System.Drawing.Size(300, 223);
            this.gbAddResident.TabIndex = 1;
            this.gbAddResident.TabStop = false;
            this.gbAddResident.Text = "Add New Resident:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(167, 172);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 7;
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(167, 127);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(100, 20);
            this.tbCell.TabIndex = 6;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(167, 79);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(167, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 175);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Number:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(22, 130);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(67, 13);
            this.lblCell.TabIndex = 2;
            this.lblCell.Text = "Cell Number:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbBank
            // 
            this.tbBank.Controls.Add(this.tbBranch);
            this.tbBank.Controls.Add(this.tbAccNum);
            this.tbBank.Controls.Add(this.cbContract);
            this.tbBank.Controls.Add(this.lblAccNum);
            this.tbBank.Controls.Add(this.lblBranch);
            this.tbBank.Location = new System.Drawing.Point(332, 12);
            this.tbBank.Name = "tbBank";
            this.tbBank.Size = new System.Drawing.Size(244, 223);
            this.tbBank.TabIndex = 2;
            this.tbBank.TabStop = false;
            this.tbBank.Text = "Bank Details:";
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
            this.tbBranch.Location = new System.Drawing.Point(115, 43);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.Size = new System.Drawing.Size(121, 21);
            this.tbBranch.TabIndex = 4;
            // 
            // tbAccNum
            // 
            this.tbAccNum.Location = new System.Drawing.Point(136, 96);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(100, 20);
            this.tbAccNum.TabIndex = 3;
            // 
            // cbContract
            // 
            this.cbContract.AutoSize = true;
            this.cbContract.Location = new System.Drawing.Point(54, 161);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(141, 21);
            this.cbContract.TabIndex = 2;
            this.cbContract.Text = "Acknowledge Contract";
            this.cbContract.UseVisualStyleBackColor = true;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Location = new System.Drawing.Point(21, 99);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(90, 13);
            this.lblAccNum.TabIndex = 1;
            this.lblAccNum.Text = "Account Number:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(21, 42);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(66, 13);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "Bank Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Resident";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
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
            // FormAddNewResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbBank);
            this.Controls.Add(this.gbAddResident);
            this.Name = "FormAddNewResident";
            this.Text = "FormAddNewResident";
            this.Load += new System.EventHandler(this.FormAddNewResident_Load);
            this.gbAddResident.ResumeLayout(false);
            this.gbAddResident.PerformLayout();
            this.tbBank.ResumeLayout(false);
            this.tbBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddResident;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox tbBank;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.CheckBox cbContract;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Button btnAdd;
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