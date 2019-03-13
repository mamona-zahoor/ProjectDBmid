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
            this.TPGroups = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TPStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.TPGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPStudents);
            this.tabControl1.Controls.Add(this.TPGroups);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 443);
            this.tabControl1.TabIndex = 35;
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
            // TPGroups
            // 
            this.TPGroups.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TPGroups.Controls.Add(this.label1);
            this.TPGroups.Location = new System.Drawing.Point(4, 22);
            this.TPGroups.Name = "TPGroups";
            this.TPGroups.Padding = new System.Windows.Forms.Padding(3);
            this.TPGroups.Size = new System.Drawing.Size(538, 364);
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
            this.TPGroups.ResumeLayout(false);
            this.TPGroups.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPStudents;
        private System.Windows.Forms.TabPage TPGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkAdd;
        private System.Windows.Forms.DataGridView DGV;
    }
}