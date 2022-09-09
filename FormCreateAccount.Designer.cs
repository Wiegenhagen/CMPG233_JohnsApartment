
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormCreateAccount
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.lblCancel);
            this.panelContainer.Controls.Add(this.txtConfirmPassword);
            this.panelContainer.Controls.Add(this.btnCreateAccount);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.txtUsername);
            this.panelContainer.Controls.Add(this.lblCreateAccount);
            this.panelContainer.Location = new System.Drawing.Point(285, 88);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(231, 241);
            this.panelContainer.TabIndex = 0;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(188, 222);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(40, 13);
            this.lblCancel.TabIndex = 4;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseEnter += new System.EventHandler(this.lblCancel_MouseEnter);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(65, 139);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(65, 201);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Location = new System.Drawing.Point(62, 31);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(106, 13);
            this.lblCreateAccount.TabIndex = 5;
            this.lblCreateAccount.Text = "Create New Account";
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epConfirmPassword
            // 
            this.epConfirmPassword.ContainerControl = this;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormCreateAccount";
            this.Text = "FormCreateAccount";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.ErrorProvider epConfirmPassword;
    }
}