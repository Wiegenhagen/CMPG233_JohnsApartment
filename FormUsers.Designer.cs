
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormUsers
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReEnter = new System.Windows.Forms.Label();
            this.txtReEnter = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnChangeDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epReEnterPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.pChange = new System.Windows.Forms.Panel();
            this.pDelete = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassDelete = new System.Windows.Forms.TextBox();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.epDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDeletePass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReEnterPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).BeginInit();
            this.pChange.SuspendLayout();
            this.pDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDeletePass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Password";
            // 
            // lblReEnter
            // 
            this.lblReEnter.AutoSize = true;
            this.lblReEnter.Location = new System.Drawing.Point(16, 45);
            this.lblReEnter.Name = "lblReEnter";
            this.lblReEnter.Size = new System.Drawing.Size(98, 13);
            this.lblReEnter.TabIndex = 1;
            this.lblReEnter.Text = "Re-Enter Password";
            // 
            // txtReEnter
            // 
            this.txtReEnter.Location = new System.Drawing.Point(19, 70);
            this.txtReEnter.Name = "txtReEnter";
            this.txtReEnter.Size = new System.Drawing.Size(134, 20);
            this.txtReEnter.TabIndex = 2;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(16, 110);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(78, 13);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(16, 173);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(91, 13);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(19, 199);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(134, 20);
            this.txtConfirm.TabIndex = 6;
            // 
            // btnChangeDelete
            // 
            this.btnChangeDelete.Location = new System.Drawing.Point(45, 263);
            this.btnChangeDelete.Name = "btnChangeDelete";
            this.btnChangeDelete.Size = new System.Drawing.Size(91, 23);
            this.btnChangeDelete.TabIndex = 7;
            this.btnChangeDelete.Text = "Change";
            this.btnChangeDelete.UseVisualStyleBackColor = true;
            this.btnChangeDelete.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // epReEnterPassword
            // 
            this.epReEnterPassword.ContainerControl = this;
            // 
            // epConfirmPassword
            // 
            this.epConfirmPassword.ContainerControl = this;
            // 
            // pChange
            // 
            this.pChange.BackColor = System.Drawing.SystemColors.Window;
            this.pChange.Controls.Add(this.lblTitle);
            this.pChange.Controls.Add(this.lblReEnter);
            this.pChange.Controls.Add(this.txtReEnter);
            this.pChange.Controls.Add(this.txtConfirm);
            this.pChange.Controls.Add(this.lblNew);
            this.pChange.Controls.Add(this.txtPassword);
            this.pChange.Controls.Add(this.lblConfirm);
            this.pChange.Location = new System.Drawing.Point(45, 12);
            this.pChange.Name = "pChange";
            this.pChange.Size = new System.Drawing.Size(219, 234);
            this.pChange.TabIndex = 9;
            this.pChange.Visible = false;
            // 
            // pDelete
            // 
            this.pDelete.BackColor = System.Drawing.SystemColors.Window;
            this.pDelete.Controls.Add(this.lblUsername);
            this.pDelete.Controls.Add(this.txtDelete);
            this.pDelete.Controls.Add(this.lblPassword);
            this.pDelete.Controls.Add(this.txtPassDelete);
            this.pDelete.Controls.Add(this.lblDeleteAccount);
            this.pDelete.Location = new System.Drawing.Point(45, 12);
            this.pDelete.Name = "pDelete";
            this.pDelete.Size = new System.Drawing.Size(219, 234);
            this.pDelete.TabIndex = 12;
            this.pDelete.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 68);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 13);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Enter Username To Delete";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(21, 93);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(154, 20);
            this.txtDelete.TabIndex = 17;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 13);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Please Enter Your Password";
            // 
            // txtPassDelete
            // 
            this.txtPassDelete.Location = new System.Drawing.Point(21, 157);
            this.txtPassDelete.Name = "txtPassDelete";
            this.txtPassDelete.Size = new System.Drawing.Size(154, 20);
            this.txtPassDelete.TabIndex = 19;
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(33, 8);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(156, 25);
            this.lblDeleteAccount.TabIndex = 15;
            this.lblDeleteAccount.Text = "Delete Accoount";
            // 
            // epDelete
            // 
            this.epDelete.ContainerControl = this;
            // 
            // epDeletePass
            // 
            this.epDeletePass.ContainerControl = this;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 298);
            this.Controls.Add(this.pDelete);
            this.Controls.Add(this.pChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeDelete);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReEnterPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).EndInit();
            this.pChange.ResumeLayout(false);
            this.pChange.PerformLayout();
            this.pDelete.ResumeLayout(false);
            this.pDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDeletePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReEnter;
        private System.Windows.Forms.TextBox txtReEnter;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnChangeDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epReEnterPassword;
        private System.Windows.Forms.ErrorProvider epConfirmPassword;
        private System.Windows.Forms.Panel pChange;
        private System.Windows.Forms.ErrorProvider epDelete;
        private System.Windows.Forms.ErrorProvider epDeletePass;
        private System.Windows.Forms.Panel pDelete;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassDelete;
        private System.Windows.Forms.Label lblDeleteAccount;
    }
}