using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Main : Form
    {
        string conn = "Data Source=MAMONA\\MAMONA;Initial Catalog=ProjectA;User ID=sa;Password=Mamona123";

        public Main()
        {
            InitializeComponent();
            TControl.TabPages.Remove(TPAddStu);
            TControl.TabPages.Remove(TPAddAdv);
            TControl.TabPages.Remove(TPAddAdvisor);
            TControl.TabPages.Remove(TPAddProj);
            TControl.TabPages.Remove(TPAddEvaluations);
            TControl.TabPages.Remove(TPEditStu);
            TControl.TabPages.Remove(TPEditAdv);
            TControl.TabPages.Remove(TPEditProj);
            TControl.TabPages.Remove(TPGroups);
            lblEditProjId.Hide();
            lblEditAdvId.Hide();
            lblEditStuId.Hide();
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand();
            string q = "Select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo from Person join Student on Person.Id = Student.Id";
            cmd = new SqlCommand(q, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> stu = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student();
                s.First_Name = reader.GetString(0);
                s.Last_Name = reader.GetString(1);
                s.Contacts = reader.GetString(2);
                s.Emails = reader.GetString(3);
                s.DateOfBirth = reader.GetDateTime(4);
                if (reader.GetInt32(5) == 2)
                {
                    s.gender = "Female";
                }
                else
                {
                    s.gender = "Male";
                }
                s.RegistrationNo = reader.GetString(6);
                stu.Add(s);
            }
            DGV.DataSource = stu;
            DGVgroups.DataSource = stu;
            reader.Close();
            reader.Dispose();
            string q1 = "Select * from Advisor";
            cmd = new SqlCommand(q1, sqlConn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVAd.DataSource = dt;
     
            string q2 = "Select Title, Description from Project";
            cmd = new SqlCommand(q2, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVProj.DataSource = dt;
            reader.Close();
            reader.Dispose();
            q1 = "Select * from ProjectAdvisor";
            cmd = new SqlCommand(q1, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVProjAdv.DataSource = dt;
            q1 = "Select Name, TotalMarks, TotalWeightage from Evaluation";
            cmd = new SqlCommand(q1, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVEvaluations.DataSource = dt;


        }

        public void ChangeTab(int Index)
        {
            TControl.SelectedIndex = Index;
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TControl.TabPages.Insert(1, TPAddStu);
            this.ChangeTab(1);
            TControl.TabPages.Remove(TPStudents);
        }
  
        private void TPStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TControl.TabPages.Insert(2, TPAddAdvisor);
            this.ChangeTab(2);
            TControl.TabPages.Remove(TPAdvisors);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TControl.TabPages.Insert(3, TPAddProj);
            this.ChangeTab(3);
            TControl.TabPages.Remove(TPProjects);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void DGVgroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
        
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);

            if (e.ColumnIndex == 1)
            {
                int Id = 0;
                string q1 = "Select Id from Person where Email = '"+ DGV[e.ColumnIndex + 4, e.RowIndex].Value+"'";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(q1, sqlConn);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
              
                string smd = "DELETE from Student where Id = " + Id + "";
                cmd = new SqlCommand(smd, sqlConn);
                cmd.ExecuteNonQuery();
                string que = "Delete from Person where Id = "+Id+"";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGV.DataSource];
                currencyManager1.SuspendBinding();
                DGV.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();
            }
            if (e.ColumnIndex == 0)
            {
         

                string q1 = "Select Id from Person where Email = '" + DGV[e.ColumnIndex + 5, e.RowIndex].Value + "'";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(q1, sqlConn);
                lblEditStuId.Text = (cmd.ExecuteScalar()).ToString();
                
                string que = "Select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo from Person join Student on Person.Id = Student.Id WHERE Person.Id = "+lblEditStuId.Text+ "";
                 cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtFN.Text = reader.GetString(0);
                    txtLN.Text = reader.GetString(1);
                    txtCN.Text = reader.GetString(2);
                    txtEmailCh.Text = reader.GetString(3);
                    DTP2.Value = reader.GetDateTime(4);
                    if (reader.GetInt32(5) == 2)
                    {
                        cmbGN.Text = "Female";
                    }
                    else
                    {
                        cmbGN.Text = "Male";
                    }
                    txtReg.Text = reader.GetString(6);
                }
                reader.Dispose();
                reader.Close();
                TControl.TabPages.Insert(1, TPEditStu);
                this.ChangeTab(9);
                TControl.TabPages.Remove(TPStudents);

            }
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            int gen = 0;
            if (cmbGender.Text == "Male")
            {
                gen = 1;
            }
            else
            {
                gen = 2;
            }

            string que = "UPDATE PERSON SET FirstName = '"+txtFN.Text+"', LastName = '"+txtLN.Text+"', Contact = '"+txtCN.Text+"', Email = '"+txtEmailCh.Text+"', Gender = "+gen+", DateOfBirth = '"+DTP2.Value+"'  where Person.Id = "+lblEditStuId.Text+"";
           SqlCommand cmd = new SqlCommand(que, sqlConn);
            cmd.ExecuteNonQuery();
             que = "UPDATE Student SET RegistrationNo = '" + txtReg.Text + "' where Id = " + lblEditStuId.Text + "";
            cmd = new SqlCommand(que, sqlConn);
            cmd.ExecuteNonQuery();
            Main m = new Main();
            m.Show();
            this.Hide();

        }
        private void cmdCreate_Click_1(object sender, EventArgs e)
        {
            int gen = 0;
            if (cmbGender.Text == "Male")
            {
                gen = 1;
            }
            else
            {
                gen = 2;
            }
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "INSERT INTO Person(FirstName, LastName,Contact,Email,DateOfBirth, Gender) values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + txtContact.Text + "', '" + txtEmail.Text + "', '" + DTP.Value + "', " + gen + ")";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            string Que3 = "Select id from Person where Email = '" + txtEmail.Text + "'";
            cmd = new SqlCommand(Que3, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            reader.Dispose();
            string Que4 = "INSERT INTO Student(Id, RegistrationNo) values (" + id + ", '" + txtRegNo.Text + "')";
            cmd = new SqlCommand(Que4, sqlConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student has been added!");
            sqlConn.Close();

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(0);
            this.Hide();
            m.Show();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            TControl.TabPages.Insert(4, TPAddAdv);
            this.ChangeTab(4);
            TControl.TabPages.Remove(TPProjAd);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "SELECT Id from Project where Title = '" + txtTitle.Text + "'";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            int Id = 0;
            while (reader.Read())
            {
                Id = reader.GetInt32(0);
            }
            reader.Dispose();
            reader.Close();
            Que1 = "SELECT Id from [Lookup] where Category = 'ADVISOR_ROLE' and Value = '" + cmbRole.Text + "'";
            cmd = new SqlCommand(Que1, sqlConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Id = reader.GetInt32(0);
            }
            reader.Dispose();
            reader.Close();

            Que1 = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) values (" + txtAdvisorId.Text + ", " + Id + ", " + Id + ", '" + DTPAssignmentDate.Value + "')";
            cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Project has been assigned to advisor.");

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(3);
            this.Hide();
            m.Show();

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que = "Select Id from [Lookup] where Category = 'DESIGNATION' and Value = '" + cmbDes.Text + "'";
            SqlCommand cmd = new SqlCommand(Que, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            int Id = 0;
            while (reader.Read())
            {
                Id = reader.GetInt32(0);
            }
            reader.Close();
            reader.Dispose();
            string Que1 = "INSERT INTO advisor(Id, Designation, Salary) values ('" + txtId.Text + "', " + Id + " ," + txtSalary.Text + ")";
            cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Advisor added successfully.");


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(1);
            m.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(2);
            m.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "INSERT INTO Project(Title, Description) values ('" + txtTitle.Text + "', '" + RTBDescr.Text + "')";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Project saved successfully.");

        }

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_3(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();

        }


       
        private void DGVAd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            int EditAdv = 0;
            if (e.ColumnIndex == 1)
            {
                sqlConn.Open();
                string smd = "DELETE from ProjectAdvisor where AdvisorId = " + DGVAd[2, e.RowIndex].Value + "";
                SqlCommand cmd = new SqlCommand(smd, sqlConn);
                cmd.ExecuteNonQuery();
                string que = "Delete from Advisor where Id = " + DGVAd[2, e.RowIndex].Value + "";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGVAd.DataSource];
                currencyManager1.SuspendBinding();
                DGVAd.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();

            }
            if (e.ColumnIndex == 0)
            {
                sqlConn.Open();
                string smd = "SELECT * FROM ADVISOR where Id = " + DGVAd[2, e.RowIndex].Value + "";
                SqlCommand cmd = new SqlCommand(smd, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(1) == 6)
                    {
                        cmbDesCH.Text = "Professor";
                    }
                    else if (reader.GetInt32(1) == 7)
                    {
                        cmbDesCH.Text = "Associate Professor";
                    }
                    else
                    {
                        cmbDesCH.Text = "Assisstant Professor";

                    }
                    txtSalaryCH.Text = reader.GetDecimal(2).ToString();

                }
                reader.Dispose();
                reader.Close();
                EditAdv = Convert.ToInt32(DGVAd[2, e.RowIndex].Value);
                lblEditAdvId.Text = EditAdv.ToString();
                TControl.TabPages.Insert(2, TPEditAdv);
                this.ChangeTab(2);
                TControl.TabPages.Remove(TPAdvisors);
             
            }

        }
        private void cmdSaveAdv_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que = "Select Id from [Lookup] where Category = 'DESIGNATION' and Value = '" + cmbDesCH.Text + "'";
            SqlCommand cmd = new SqlCommand(Que, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            int DesId = 0;
            while (reader.Read())
            {
                DesId = reader.GetInt32(0);
            }
            reader.Close();
            reader.Dispose();
            string smd = "UPDATE ADVISOR set Designation = " + DesId + ", Salary = " + txtSalaryCH.Text + " where Id = "+lblEditAdvId.Text+"";
            cmd = new SqlCommand(smd, sqlConn);
            cmd.ExecuteNonQuery();
            Main m = new Main();
            m.ChangeTab(1);
            m.Show();
            this.Hide();

        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(1);
            m.Show();
            this.Hide();
        }
        
        private void DGVProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ProjId = 0;
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
           if (e.ColumnIndex == 1)
            {
                string que = "SELECT Id from Project where title ='" + DGVProj[2, e.RowIndex].Value + "' and Description = '" + DGVProj[3, e.RowIndex].Value + "' ";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
               ProjId = Convert.ToInt32(cmd.ExecuteScalar());
                que = "DELETE from Project where Id = "+ProjId+" ";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGVProj.DataSource];
                currencyManager1.SuspendBinding();
                DGVProj.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();
            }
            if (e.ColumnIndex == 0)
            {
                string que = "SELECT Id from Project where title ='" + DGVProj[2, e.RowIndex].Value + "' and Description = '" + DGVProj[3, e.RowIndex].Value + "' ";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                ProjId = Convert.ToInt32(cmd.ExecuteScalar());

                que = "SELECT Title, Description from Project where Id = "+ProjId+" ";
                cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtTitleCh.Text = reader.GetString(0);
                    RTBDescCh.Text = reader.GetString(1);
                    lblEditProjId.Text = ProjId.ToString();
                }
                TControl.TabPages.Insert(3, TPEditProj);
                this.ChangeTab(3);
                TControl.TabPages.Remove(TPProjects);
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(2);
            m.Show();
            this.Hide();

        }

        private void cmdSaveProjCh_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que = "UPDATE Project SET Title = '"+txtTitleCh.Text+"', Description = '"+RTBDescCh.Text+"' where Id = "+lblEditProjId.Text+"";
            SqlCommand cmd = new SqlCommand(Que, sqlConn);
            cmd.ExecuteNonQuery();
            Main m = new Main();
            m.ChangeTab(2);
            m.Show();
            this.Hide();


        }

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(4);
            m.Show();
            this.Hide();
        }

        private void lnkAddEvaluation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            TControl.TabPages.Remove(TPEvaluations);
            TControl.TabPages.Insert(4, TPAddEvaluations);
            this.ChangeTab(4);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void cmdAddEva_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) values ('" + txtNameEva.Text + "', " + NUPMarks.Text + ", "+NUPweightage.Text+")";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Evaluation saved successfully.");
            txtNameEva.Text = "";
            NUPMarks.Text = 0.ToString();
            NUPweightage.Text = 0.ToString();
        }

        private void DGVEvaluations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SqlConnection sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                if (e.ColumnIndex == 1)
                {
                    string que = "SELECT Id from Evaluation where Name ='" + DGVEvaluations[2, e.RowIndex].Value + "' and TotalMarks = '" + DGVEvaluations[3, e.RowIndex].Value + "' and TotalWeightage = '"+ DGVEvaluations[4,e.RowIndex].Value +"' ";
                    SqlCommand cmd = new SqlCommand(que, sqlConn);
                    int Id = Convert.ToInt32(cmd.ExecuteScalar());
                    que = "DELETE from Evaluation where Id = " + Id + " ";
                    cmd = new SqlCommand(que, sqlConn);
                    cmd.ExecuteNonQuery();
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGVEvaluations.DataSource];
                    currencyManager1.SuspendBinding();
                    DGVEvaluations.Rows[e.RowIndex].Visible = false;
                    currencyManager1.ResumeBinding();

                }
            }
    }
}
