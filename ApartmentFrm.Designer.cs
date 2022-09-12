
namespace Group_26_Johns_RealEstate_Management_System
{
    partial class ApartmentFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddApartBtn = new System.Windows.Forms.Button();
            this.ApartNumtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.OccupationCal = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateAprtcb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateAprtbtn = new System.Windows.Forms.Button();
            this.UpdateAprtNumtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbUpdateNo = new System.Windows.Forms.RadioButton();
            this.rbUpdateYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateCal = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateRescb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteAprtcb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteAprtbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(864, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Apartment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.AddApartBtn);
            this.panel1.Controls.Add(this.ApartNumtxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OccupationCal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbResName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(96, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 556);
            this.panel1.TabIndex = 1;
            // 
            // AddApartBtn
            // 
            this.AddApartBtn.Location = new System.Drawing.Point(213, 490);
            this.AddApartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddApartBtn.Name = "AddApartBtn";
            this.AddApartBtn.Size = new System.Drawing.Size(175, 42);
            this.AddApartBtn.TabIndex = 10;
            this.AddApartBtn.Text = "Add Apartment";
            this.AddApartBtn.UseVisualStyleBackColor = true;
            this.AddApartBtn.Click += new System.EventHandler(this.AddApartBtn_Click);
            // 
            // ApartNumtxt
            // 
            this.ApartNumtxt.Location = new System.Drawing.Point(336, 47);
            this.ApartNumtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApartNumtxt.Name = "ApartNumtxt";
            this.ApartNumtxt.Size = new System.Drawing.Size(132, 22);
            this.ApartNumtxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apartment number?";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(336, 410);
            this.rbNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 21);
            this.rbNo.TabIndex = 7;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(213, 410);
            this.rbYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(53, 21);
            this.rbYes.TabIndex = 6;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Does the resident want the apartment to be furnished?";
            // 
            // OccupationCal
            // 
            this.OccupationCal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OccupationCal.Location = new System.Drawing.Point(156, 176);
            this.OccupationCal.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.OccupationCal.MaxSelectionCount = 1;
            this.OccupationCal.Name = "OccupationCal";
            this.OccupationCal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the date when new resident moves in:";
            // 
            // cbResName
            // 
            this.cbResName.FormattingEnabled = true;
            this.cbResName.Location = new System.Drawing.Point(213, 113);
            this.cbResName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbResName.Name = "cbResName";
            this.cbResName.Size = new System.Drawing.Size(173, 24);
            this.cbResName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select resident from list below:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(864, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Apartment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.UpdateAprtcb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.UpdateAprtbtn);
            this.panel2.Controls.Add(this.UpdateAprtNumtxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rbUpdateNo);
            this.panel2.Controls.Add(this.rbUpdateYes);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.UpdateCal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.UpdateRescb);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(121, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 556);
            this.panel2.TabIndex = 2;
            // 
            // UpdateAprtcb
            // 
            this.UpdateAprtcb.FormattingEnabled = true;
            this.UpdateAprtcb.Location = new System.Drawing.Point(365, 58);
            this.UpdateAprtcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateAprtcb.Name = "UpdateAprtcb";
            this.UpdateAprtcb.Size = new System.Drawing.Size(160, 24);
            this.UpdateAprtcb.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(211, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Update Apartment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apartment, to update, Number:";
            // 
            // UpdateAprtbtn
            // 
            this.UpdateAprtbtn.Location = new System.Drawing.Point(213, 490);
            this.UpdateAprtbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateAprtbtn.Name = "UpdateAprtbtn";
            this.UpdateAprtbtn.Size = new System.Drawing.Size(175, 42);
            this.UpdateAprtbtn.TabIndex = 10;
            this.UpdateAprtbtn.Text = "Update Apartment";
            this.UpdateAprtbtn.UseVisualStyleBackColor = true;
            // 
            // UpdateAprtNumtxt
            // 
            this.UpdateAprtNumtxt.Location = new System.Drawing.Point(307, 447);
            this.UpdateAprtNumtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateAprtNumtxt.Name = "UpdateAprtNumtxt";
            this.UpdateAprtNumtxt.Size = new System.Drawing.Size(132, 22);
            this.UpdateAprtNumtxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Apartment number?";
            // 
            // rbUpdateNo
            // 
            this.rbUpdateNo.AutoSize = true;
            this.rbUpdateNo.Location = new System.Drawing.Point(336, 410);
            this.rbUpdateNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUpdateNo.Name = "rbUpdateNo";
            this.rbUpdateNo.Size = new System.Drawing.Size(47, 21);
            this.rbUpdateNo.TabIndex = 7;
            this.rbUpdateNo.TabStop = true;
            this.rbUpdateNo.Text = "No";
            this.rbUpdateNo.UseVisualStyleBackColor = true;
            // 
            // rbUpdateYes
            // 
            this.rbUpdateYes.AutoSize = true;
            this.rbUpdateYes.Location = new System.Drawing.Point(213, 410);
            this.rbUpdateYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUpdateYes.Name = "rbUpdateYes";
            this.rbUpdateYes.Size = new System.Drawing.Size(53, 21);
            this.rbUpdateYes.TabIndex = 6;
            this.rbUpdateYes.TabStop = true;
            this.rbUpdateYes.Text = "Yes";
            this.rbUpdateYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Does the resident want the apartment to be furnished?";
            // 
            // UpdateCal
            // 
            this.UpdateCal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateCal.Location = new System.Drawing.Point(156, 176);
            this.UpdateCal.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.UpdateCal.MaxSelectionCount = 1;
            this.UpdateCal.Name = "UpdateCal";
            this.UpdateCal.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select the new date when resident moves in:";
            // 
            // UpdateRescb
            // 
            this.UpdateRescb.FormattingEnabled = true;
            this.UpdateRescb.Location = new System.Drawing.Point(213, 113);
            this.UpdateRescb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateRescb.Name = "UpdateRescb";
            this.UpdateRescb.Size = new System.Drawing.Size(173, 24);
            this.UpdateRescb.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Select resident from list below:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(864, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Apartment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.DeleteAprtcb);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.DeleteAprtbtn);
            this.panel3.Location = new System.Drawing.Point(121, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 556);
            this.panel3.TabIndex = 3;
            // 
            // DeleteAprtcb
            // 
            this.DeleteAprtcb.FormattingEnabled = true;
            this.DeleteAprtcb.Location = new System.Drawing.Point(215, 103);
            this.DeleteAprtcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteAprtcb.Name = "DeleteAprtcb";
            this.DeleteAprtcb.Size = new System.Drawing.Size(160, 24);
            this.DeleteAprtcb.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Delete Apartment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Select which apartment to delete:";
            // 
            // DeleteAprtbtn
            // 
            this.DeleteAprtbtn.Location = new System.Drawing.Point(207, 171);
            this.DeleteAprtbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteAprtbtn.Name = "DeleteAprtbtn";
            this.DeleteAprtbtn.Size = new System.Drawing.Size(175, 42);
            this.DeleteAprtbtn.TabIndex = 10;
            this.DeleteAprtbtn.Text = "Delete Apartment";
            this.DeleteAprtbtn.UseVisualStyleBackColor = true;
            // 
            // ApartmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 698);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ApartmentFrm";
            this.Text = "ApartmentFrm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddApartBtn;
        private System.Windows.Forms.TextBox ApartNumtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar OccupationCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbResName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox UpdateAprtcb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateAprtbtn;
        private System.Windows.Forms.TextBox UpdateAprtNumtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbUpdateNo;
        private System.Windows.Forms.RadioButton rbUpdateYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar UpdateCal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox UpdateRescb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox DeleteAprtcb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DeleteAprtbtn;
    }
}