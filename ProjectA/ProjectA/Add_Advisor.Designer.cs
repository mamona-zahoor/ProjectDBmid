namespace ProjectA
{
    partial class Add_Advisor
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
            this.TPAdvisors = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmbDes = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPAdvisors.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPAdvisors
            // 
            this.TPAdvisors.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPAdvisors.Controls.Add(this.linkLabel1);
            this.TPAdvisors.Controls.Add(this.cmbDes);
            this.TPAdvisors.Controls.Add(this.cmdAdd);
            this.TPAdvisors.Controls.Add(this.label2);
            this.TPAdvisors.Controls.Add(this.txtId);
            this.TPAdvisors.Controls.Add(this.txtSalary);
            this.TPAdvisors.Controls.Add(this.lblSal);
            this.TPAdvisors.Controls.Add(this.label10);
            this.TPAdvisors.Controls.Add(this.label3);
            this.TPAdvisors.Location = new System.Drawing.Point(4, 22);
            this.TPAdvisors.Name = "TPAdvisors";
            this.TPAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.TPAdvisors.Size = new System.Drawing.Size(695, 405);
            this.TPAdvisors.TabIndex = 1;
            this.TPAdvisors.Text = "Add Advisors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 97;
            this.label3.Text = "Add Advisor";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(260, 163);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(247, 20);
            this.txtSalary.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 99;
            this.label10.Text = "Designation";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(100, 165);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(48, 18);
            this.lblSal.TabIndex = 100;
            this.lblSal.Text = "Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(260, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(247, 20);
            this.txtId.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "Id";
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdAdd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(462, 228);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(115, 41);
            this.cmdAdd.TabIndex = 103;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmbDes
            // 
            this.cmbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDes.FormattingEnabled = true;
            this.cmbDes.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor"});
            this.cmbDes.Location = new System.Drawing.Point(260, 136);
            this.cmbDes.Name = "cmbDes";
            this.cmbDes.Size = new System.Drawing.Size(247, 21);
            this.cmbDes.TabIndex = 104;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(81, 303);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 13);
            this.linkLabel1.TabIndex = 105;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPAdvisors);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 431);
            this.tabControl1.TabIndex = 97;
            // 
            // Add_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Add_Advisor";
            this.Text = "Add_Advisor";
            this.Load += new System.EventHandler(this.Add_Advisor_Load);
            this.TPAdvisors.ResumeLayout(false);
            this.TPAdvisors.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TPAdvisors;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbDes;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}