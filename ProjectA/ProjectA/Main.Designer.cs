namespace ProjectA
{
    partial class Main
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
            this.lnkAdd = new System.Windows.Forms.LinkLabel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TPAdvisors = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DGVAd = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TPStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.TPAdvisors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPStudents);
            this.tabControl1.Controls.Add(this.TPAdvisors);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 443);
            this.tabControl1.TabIndex = 35;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TPStudents
            // 
            this.TPStudents.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TPStudents.Controls.Add(this.lnkAdd);
            this.TPStudents.Controls.Add(this.DGV);
            this.TPStudents.Location = new System.Drawing.Point(4, 22);
            this.TPStudents.Name = "TPStudents";
            this.TPStudents.Padding = new System.Windows.Forms.Padding(3);
            this.TPStudents.Size = new System.Drawing.Size(692, 417);
            this.TPStudents.TabIndex = 0;
            this.TPStudents.Text = "Manage Students";
            this.TPStudents.Click += new System.EventHandler(this.TPStudents_Click);
            // 
            // lnkAdd
            // 
            this.lnkAdd.AutoSize = true;
            this.lnkAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAdd.Location = new System.Drawing.Point(16, 24);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(79, 18);
            this.lnkAdd.TabIndex = 1;
            this.lnkAdd.TabStop = true;
            this.lnkAdd.Text = "Create New";
            this.lnkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdd_LinkClicked);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(6, 61);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(668, 345);
            this.DGV.TabIndex = 0;
            // 
            // TPAdvisors
            // 
            this.TPAdvisors.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPAdvisors.Controls.Add(this.linkLabel1);
            this.TPAdvisors.Controls.Add(this.DGVAd);
            this.TPAdvisors.Location = new System.Drawing.Point(4, 22);
            this.TPAdvisors.Name = "TPAdvisors";
            this.TPAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.TPAdvisors.Size = new System.Drawing.Size(692, 417);
            this.TPAdvisors.TabIndex = 1;
            this.TPAdvisors.Text = "Manage Advisors";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(22, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DGVAd
            // 
            this.DGVAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAd.Location = new System.Drawing.Point(12, 54);
            this.DGVAd.Name = "DGVAd";
            this.DGVAd.Size = new System.Drawing.Size(668, 345);
            this.DGVAd.TabIndex = 2;
            this.DGVAd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(699, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "FYP Management System";
            this.tabControl1.ResumeLayout(false);
            this.TPStudents.ResumeLayout(false);
            this.TPStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.TPAdvisors.ResumeLayout(false);
            this.TPAdvisors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPStudents;
        private System.Windows.Forms.TabPage TPAdvisors;
        private System.Windows.Forms.LinkLabel lnkAdd;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView DGVAd;
    }
}