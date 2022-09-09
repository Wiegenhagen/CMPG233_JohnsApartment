
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epReEnterPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReEnterPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Password";
            // 
            // lblReEnter
            // 
            this.lblReEnter.AutoSize = true;
            this.lblReEnter.Location = new System.Drawing.Point(12, 56);
            this.lblReEnter.Name = "lblReEnter";
            this.lblReEnter.Size = new System.Drawing.Size(98, 13);
            this.lblReEnter.TabIndex = 1;
            this.lblReEnter.Text = "Re-Enter Password";
            // 
            // txtReEnter
            // 
            this.txtReEnter.Location = new System.Drawing.Point(15, 81);
            this.txtReEnter.Name = "txtReEnter";
            this.txtReEnter.Size = new System.Drawing.Size(134, 20);
            this.txtReEnter.TabIndex = 2;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(12, 121);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(78, 13);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(12, 184);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(91, 13);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(15, 210);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(134, 20);
            this.txtConfirm.TabIndex = 6;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 263);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 263);
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
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.txtReEnter);
            this.Controls.Add(this.lblReEnter);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReEnterPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReEnter;
        private System.Windows.Forms.TextBox txtReEnter;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epReEnterPassword;
        private System.Windows.Forms.ErrorProvider epConfirmPassword;
    }
}