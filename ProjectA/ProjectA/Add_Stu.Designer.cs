namespace ProjectA
{
    partial class Add_Stu
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
            this.TPStudents = new System.Windows.Forms.TabPage();
            this.TPGroups = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.TPStudents.SuspendLayout();
            this.TPGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPStudents);
            this.tabControl1.Controls.Add(this.TPGroups);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 431);
            this.tabControl1.TabIndex = 66;
            // 
            // TPStudents
            // 
            this.TPStudents.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TPStudents.Controls.Add(this.lblBack);
            this.TPStudents.Controls.Add(this.cmbGender);
            this.TPStudents.Controls.Add(this.label3);
            this.TPStudents.Controls.Add(this.DTP);
            this.TPStudents.Controls.Add(this.cmdCreate);
            this.TPStudents.Controls.Add(this.txtContact);
            this.TPStudents.Controls.Add(this.label7);
            this.TPStudents.Controls.Add(this.label6);
            this.TPStudents.Controls.Add(this.label5);
            this.TPStudents.Controls.Add(this.label4);
            this.TPStudents.Controls.Add(this.label8);
            this.TPStudents.Controls.Add(this.label9);
            this.TPStudents.Controls.Add(this.lblFN);
            this.TPStudents.Controls.Add(this.txtRegNo);
            this.TPStudents.Controls.Add(this.txtLastName);
            this.TPStudents.Controls.Add(this.txtEmail);
            this.TPStudents.Controls.Add(this.txtFirstName);
            this.TPStudents.Location = new System.Drawing.Point(4, 22);
            this.TPStudents.Name = "TPStudents";
            this.TPStudents.Padding = new System.Windows.Forms.Padding(3);
            this.TPStudents.Size = new System.Drawing.Size(695, 405);
            this.TPStudents.TabIndex = 0;
            this.TPStudents.Text = "Manage Students";
            // 
            // TPGroups
            // 
            this.TPGroups.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPGroups.Controls.Add(this.label1);
            this.TPGroups.Location = new System.Drawing.Point(4, 22);
            this.TPGroups.Name = "TPGroups";
            this.TPGroups.Padding = new System.Windows.Forms.Padding(3);
            this.TPGroups.Size = new System.Drawing.Size(692, 417);
            this.TPGroups.TabIndex = 1;
            this.TPGroups.Text = "Manage Groups";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "Add Group";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(275, 228);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(247, 21);
            this.cmbGender.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 80;
            this.label3.Text = "Add new student";
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(275, 202);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(247, 20);
            this.DTP.TabIndex = 79;
            // 
            // cmdCreate
            // 
            this.cmdCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCreate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreate.Location = new System.Drawing.Point(462, 307);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(115, 41);
            this.cmdCreate.TabIndex = 78;
            this.cmdCreate.Text = "Add";
            this.cmdCreate.UseVisualStyleBackColor = false;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click_1);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(275, 150);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(247, 20);
            this.txtContact.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 76;
            this.label7.Text = "Registration Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(115, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 71;
            this.label9.Text = "Last Name";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(115, 96);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(74, 18);
            this.lblFN.TabIndex = 70;
            this.lblFN.Text = "First Name";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(275, 255);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(247, 20);
            this.txtRegNo.TabIndex = 69;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(275, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(247, 20);
            this.txtLastName.TabIndex = 68;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(275, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 67;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(275, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(247, 20);
            this.txtFirstName.TabIndex = 66;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(51, 323);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(67, 13);
            this.lblBack.TabIndex = 82;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back To List";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // Add_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Add_Stu";
            this.Text = "Add Student";
            this.tabControl1.ResumeLayout(false);
            this.TPStudents.ResumeLayout(false);
            this.TPStudents.PerformLayout();
            this.TPGroups.ResumeLayout(false);
            this.TPGroups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPStudents;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TabPage TPGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}