
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appartmentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryOfResidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactHelpDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResidents = new System.Windows.Forms.Label();
            this.lblApartments = new System.Windows.Forms.Label();
            this.lblTAppartments = new System.Windows.Forms.Label();
            this.pAppartments = new System.Windows.Forms.Panel();
            this.pResidents = new System.Windows.Forms.Panel();
            this.lblTResidents = new System.Windows.Forms.Label();
            this.pUsers = new System.Windows.Forms.Panel();
            this.lblTUsers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.mcCal = new System.Windows.Forms.MonthCalendar();
            this.msMain.SuspendLayout();
            this.pAppartments.SuspendLayout();
            this.pResidents.SuspendLayout();
            this.pUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.DarkGray;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.reToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1067, 28);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residentsToolStripMenuItem,
            this.apartmentsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // residentsToolStripMenuItem
            // 
            this.residentsToolStripMenuItem.Name = "residentsToolStripMenuItem";
            this.residentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.residentsToolStripMenuItem.Text = "Residents";
            this.residentsToolStripMenuItem.Click += new System.EventHandler(this.residentsToolStripMenuItem_Click);
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apartmentsToolStripMenuItem.Text = "Apartments";
            this.apartmentsToolStripMenuItem.Click += new System.EventHandler(this.apartmentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestAReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // requestAReportToolStripMenuItem
            // 
            this.requestAReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullReportToolStripMenuItem,
            this.residentsReportToolStripMenuItem,
            this.appartmentsReportToolStripMenuItem,
            this.summaryOfResidentsToolStripMenuItem,
            this.summaryByDateToolStripMenuItem,
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem});
            this.requestAReportToolStripMenuItem.Name = "requestAReportToolStripMenuItem";
            this.requestAReportToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.requestAReportToolStripMenuItem.Text = "Request a Report";
            // 
            // fullReportToolStripMenuItem
            // 
            this.fullReportToolStripMenuItem.Name = "fullReportToolStripMenuItem";
            this.fullReportToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.fullReportToolStripMenuItem.Text = "Full Report";
            this.fullReportToolStripMenuItem.Click += new System.EventHandler(this.fullReportToolStripMenuItem_Click);
            // 
            // residentsReportToolStripMenuItem
            // 
            this.residentsReportToolStripMenuItem.Name = "residentsReportToolStripMenuItem";
            this.residentsReportToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.residentsReportToolStripMenuItem.Text = "Residents Report";
            this.residentsReportToolStripMenuItem.Click += new System.EventHandler(this.residentsReportToolStripMenuItem_Click);
            // 
            // appartmentsReportToolStripMenuItem
            // 
            this.appartmentsReportToolStripMenuItem.Name = "appartmentsReportToolStripMenuItem";
            this.appartmentsReportToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.appartmentsReportToolStripMenuItem.Text = "Apartments Report";
            this.appartmentsReportToolStripMenuItem.Click += new System.EventHandler(this.appartmentsReportToolStripMenuItem_Click);
            // 
            // summaryOfResidentsToolStripMenuItem
            // 
            this.summaryOfResidentsToolStripMenuItem.Name = "summaryOfResidentsToolStripMenuItem";
            this.summaryOfResidentsToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.summaryOfResidentsToolStripMenuItem.Text = "Count of Furnished Apartments";
            this.summaryOfResidentsToolStripMenuItem.Click += new System.EventHandler(this.summaryOfResidentsToolStripMenuItem_Click);
            // 
            // summaryByDateToolStripMenuItem
            // 
            this.summaryByDateToolStripMenuItem.Name = "summaryByDateToolStripMenuItem";
            this.summaryByDateToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.summaryByDateToolStripMenuItem.Text = "Apartments Sorted By Date In Descending Order";
            this.summaryByDateToolStripMenuItem.Click += new System.EventHandler(this.summaryByDateToolStripMenuItem_Click);
            // 
            // residentsSortedByAlphabeticalOrderToolStripMenuItem
            // 
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem.Name = "residentsSortedByAlphabeticalOrderToolStripMenuItem";
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem.Text = "Full Report Sorted by Alphabetical Order";
            this.residentsSortedByAlphabeticalOrderToolStripMenuItem.Click += new System.EventHandler(this.residentsSortedByAlphabeticalOrderToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.accountToolStripMenuItem.Text = "Users";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete User";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactHelpDeskToolStripMenuItem,
            this.exitProgramToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitProgramToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactHelpDeskToolStripMenuItem
            // 
            this.contactHelpDeskToolStripMenuItem.Name = "contactHelpDeskToolStripMenuItem";
            this.contactHelpDeskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contactHelpDeskToolStripMenuItem.Text = "Contact Help Desk";
            this.contactHelpDeskToolStripMenuItem.Click += new System.EventHandler(this.contactHelpDeskToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitProgramToolStripMenuItem.Text = "Report An Issue";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem1
            // 
            this.exitProgramToolStripMenuItem1.Name = "exitProgramToolStripMenuItem1";
            this.exitProgramToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitProgramToolStripMenuItem1.Text = "Exit Program";
            this.exitProgramToolStripMenuItem1.Click += new System.EventHandler(this.exitProgramToolStripMenuItem1_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.reToolStripMenuItem.Text = "Re";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(373, 66);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(135, 29);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(371, 133);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(262, 41);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "1 Januaruy 2020";
            // 
            // lblResidents
            // 
            this.lblResidents.AutoSize = true;
            this.lblResidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidents.Location = new System.Drawing.Point(19, 16);
            this.lblResidents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResidents.Name = "lblResidents";
            this.lblResidents.Size = new System.Drawing.Size(162, 25);
            this.lblResidents.TabIndex = 4;
            this.lblResidents.Text = "Total Residents";
            // 
            // lblApartments
            // 
            this.lblApartments.AutoSize = true;
            this.lblApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartments.Location = new System.Drawing.Point(16, 16);
            this.lblApartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartments.Name = "lblApartments";
            this.lblApartments.Size = new System.Drawing.Size(177, 25);
            this.lblApartments.TabIndex = 5;
            this.lblApartments.Text = "Total Apartments";
            // 
            // lblTAppartments
            // 
            this.lblTAppartments.AutoSize = true;
            this.lblTAppartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAppartments.Location = new System.Drawing.Point(72, 71);
            this.lblTAppartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTAppartments.Name = "lblTAppartments";
            this.lblTAppartments.Size = new System.Drawing.Size(0, 36);
            this.lblTAppartments.TabIndex = 6;
            // 
            // pAppartments
            // 
            this.pAppartments.BackColor = System.Drawing.Color.CadetBlue;
            this.pAppartments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAppartments.Controls.Add(this.lblApartments);
            this.pAppartments.Controls.Add(this.lblTAppartments);
            this.pAppartments.Location = new System.Drawing.Point(413, 516);
            this.pAppartments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pAppartments.Name = "pAppartments";
            this.pAppartments.Size = new System.Drawing.Size(210, 161);
            this.pAppartments.TabIndex = 7;
            // 
            // pResidents
            // 
            this.pResidents.BackColor = System.Drawing.Color.CadetBlue;
            this.pResidents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pResidents.Controls.Add(this.lblTResidents);
            this.pResidents.Controls.Add(this.lblResidents);
            this.pResidents.Location = new System.Drawing.Point(107, 516);
            this.pResidents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pResidents.Name = "pResidents";
            this.pResidents.Size = new System.Drawing.Size(209, 161);
            this.pResidents.TabIndex = 8;
            // 
            // lblTResidents
            // 
            this.lblTResidents.AutoSize = true;
            this.lblTResidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTResidents.Location = new System.Drawing.Point(73, 71);
            this.lblTResidents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTResidents.Name = "lblTResidents";
            this.lblTResidents.Size = new System.Drawing.Size(0, 36);
            this.lblTResidents.TabIndex = 6;
            // 
            // pUsers
            // 
            this.pUsers.BackColor = System.Drawing.Color.CadetBlue;
            this.pUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pUsers.Controls.Add(this.lblTUsers);
            this.pUsers.Controls.Add(this.lblUsers);
            this.pUsers.Location = new System.Drawing.Point(729, 516);
            this.pUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pUsers.Name = "pUsers";
            this.pUsers.Size = new System.Drawing.Size(209, 161);
            this.pUsers.TabIndex = 9;
            // 
            // lblTUsers
            // 
            this.lblTUsers.AutoSize = true;
            this.lblTUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTUsers.Location = new System.Drawing.Point(73, 71);
            this.lblTUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTUsers.Name = "lblTUsers";
            this.lblTUsers.Size = new System.Drawing.Size(0, 36);
            this.lblTUsers.TabIndex = 6;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(40, 16);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(123, 25);
            this.lblUsers.TabIndex = 4;
            this.lblUsers.Text = "Total Users";
            // 
            // mcCal
            // 
            this.mcCal.BackColor = System.Drawing.Color.Silver;
            this.mcCal.Location = new System.Drawing.Point(375, 249);
            this.mcCal.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcCal.Name = "mcCal";
            this.mcCal.TabIndex = 10;
            this.mcCal.TitleBackColor = System.Drawing.Color.Silver;
            this.mcCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCal_DateChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 721);
            this.Controls.Add(this.mcCal);
            this.Controls.Add(this.pUsers);
            this.Controls.Add(this.pResidents);
            this.Controls.Add(this.pAppartments);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pAppartments.ResumeLayout(false);
            this.pAppartments.PerformLayout();
            this.pResidents.ResumeLayout(false);
            this.pResidents.PerformLayout();
            this.pUsers.ResumeLayout(false);
            this.pUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestAReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residentsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appartmentsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactHelpDeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblResidents;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.Label lblTAppartments;
        private System.Windows.Forms.Panel pAppartments;
        private System.Windows.Forms.Panel pResidents;
        private System.Windows.Forms.Label lblTResidents;
        private System.Windows.Forms.Panel pUsers;
        private System.Windows.Forms.Label lblTUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.MonthCalendar mcCal;
        private System.Windows.Forms.ToolStripMenuItem summaryOfResidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residentsSortedByAlphabeticalOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
    }
}