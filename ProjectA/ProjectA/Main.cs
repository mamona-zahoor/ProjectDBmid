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
using System.Text.RegularExpressions;
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
            TControl.TabPages.Remove(TPEditEva);
            TControl.TabPages.Remove(TPEditProjAdv);
           // TControl.TabPages.Remove(TPAddGroup);
            TControl.TabPages.Remove(TPGroupDetail);
            TControl.TabPages.Remove(TPEditGroupMem);
            TControl.TabPages.Remove(TPAddGrpMem);

            lblEditProjId.Hide();
            lblEditAdvId.Hide();
            lblEditEvaId.Hide();
            lblEditStuId.Hide();
            lblGrpMem.Hide();
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand();
            string q = "Select  Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender from Person join Student on Person.Id = Student.Id";
            cmd = new SqlCommand(q, sqlConn);
          SqlDataReader reader = cmd.ExecuteReader();
            
                List<Student> stu = new List<Student>();
                  while (reader.Read())
                  {
                    Student s = new Student();
                s.RegistrationNo = reader.GetString(0);
                if (!reader.IsDBNull(0))
                    {
                        s.First_Name = reader.GetString(1);
                    }
                        s.Last_Name = reader.GetString(2);
                     if (!reader.IsDBNull(3))
                    {
                       s.Contacts = reader.GetString(3);
                    }
                          s.Emails = reader.GetString(4);
                          s.DateOfBirth = reader.GetDateTime(5);
                        if (!reader.IsDBNull(6))
                        {
                    
                        if (reader.GetInt32(6) == 2)
                            {
                                s.gender = "Female";
                            }
                            else
                            {
                                s.gender = "Male";
                            }
                        }
                      stu.Add(s);
                  }
            reader.Close();
            reader.Dispose();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DGV.DataSource =stu;
           
            string q1 = "Select * from Advisor";
            cmd = new SqlCommand(q1, sqlConn);
            List<Advisor> adv = new List<Advisor>();
            reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                Advisor ad = new Advisor();
                ad.Id = reader.GetInt32(0);
                if (reader.GetInt32(1) == 6)
                {
                    ad.Designation = "Professor";
                }
                else if (reader.GetInt32(1) == 7)
                {
                    ad.Designation = "Associate Professor";
                }
                else if (reader.GetInt32(1) == 9)
                {
                    ad.Designation = "Lecturer";
                }
                else if (reader.GetInt32(1) == 10)
                {
                    ad.Designation = "Industry Professional";
                }
                else
                {
                    ad.Designation = "Assisstant Professor";

                }

                if (!reader.IsDBNull(2))
                {
                    ad.Salary = reader.GetDecimal(2);
                }
                adv.Add(ad);
            }
            DGVAd.DataSource = adv;
            reader.Dispose();
            reader.Close();
            string q2 = "Select Title, Description from Project";
            cmd = new SqlCommand(q2, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVProj.DataSource = dt;
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
            q1 = "Select * from [Group]";
            cmd = new SqlCommand(q1, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVGroupsList.DataSource = dt;
            q1 = "SELECT m.RegistrationNo, person.FirstName, Person.LastName, Person.Email  FROM (SELECT * from Student where Id not in (SELECT StudentId from GroupStudent)) as m join Person on Person.Id = m.Id";
            cmd = new SqlCommand(q1, sqlConn);
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVgroupStudents.DataSource = dt;



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
            lblErrMemCount.Hide();
            lblIdAdvisor.Hide();
            lblProjAdvId.Hide();
            lblWCH.Hide();
            lblTMCh.Hide();
            lblNameCh.Hide();
            lblNEva.Hide();
            lblMarks.Hide();
            lblWeightage.Hide();
            lblErrTitleEdit.Hide();
            lblErrContact.Hide();
            lblErrDOB.Hide();
            lblErrEmail.Hide();
            lblErrFN.Hide();
            lblErrLN.Hide();
            lblErrGen.Hide();
            lblErrRegNo.Hide();
            lblErrContactEdit.Hide();
            lblErrDOBEdit.Hide();
            lblErrEmailEdit.Hide();
            lblErrFNEdit.Hide();
            lblErrLNEdit.Hide();
            lblErrGenEdit.Hide();
            lblErrRegNoEdit.Hide();
            lblErrDes.Hide();
            lblErrSal.Hide();
            lblErrId.Hide();
            lblErrTitle.Hide();
            lblErrAssignDate.Hide();
            lblErrAdvId.Hide();
            lblErrProject.Hide();
            lblErrAdvRole.Hide();
            lblErrProjTitleCh.Hide();
            lblErrAdvIdCh.Hide();
            lblErrAssigndateCh.Hide();
            lblAdvRoleCh.Hide();
            lnkAddNewMem.Hide();
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
                string q1 = "Select Id from Person where Email = '" + DGV[6, e.RowIndex].Value + "'";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(q1, sqlConn);
                Id = Convert.ToInt32(cmd.ExecuteScalar());

                string smd = "DELETE from Student where Id = " + Id + "";
                cmd = new SqlCommand(smd, sqlConn);
                cmd.ExecuteNonQuery();
                string que = "Delete from Person where Id = " + Id + "";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGV.DataSource];
                currencyManager1.SuspendBinding();
                DGV.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();
            }
            if (e.ColumnIndex == 0)
            {
                string q1 = "Select Id from Person where Email = '" + DGV[6, e.RowIndex].Value + "'";
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(q1, sqlConn);
                lblEditStuId.Text = (cmd.ExecuteScalar()).ToString();
                string que = "Select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo from Person join Student on Person.Id = Student.Id WHERE Person.Id = " + lblEditStuId.Text + "";
                cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        txtFN.Text = reader.GetString(0);
                    }
                    txtLN.Text = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                    {
                        txtCN.Text = reader.GetString(2);
                    }
                    txtEmailCh.Text = reader.GetString(3);
                    DTP2.Value = reader.GetDateTime(4);
                    if (!reader.IsDBNull(5))
                    {

                        if (reader.GetInt32(5) == 2)
                        {
                            cmbGN.Text = "Female";
                        }
                        else
                        {
                            cmbGN.Text = "Male";
                        }
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
            lblErrContactEdit.Hide();
            lblErrDOBEdit.Hide();
            lblErrEmailEdit.Hide();
            lblErrFNEdit.Hide();
            lblErrLNEdit.Hide();
            lblErrGenEdit.Hide();
            lblErrRegNoEdit.Hide();

            bool Okay = false;
            if (txtFN.Text.Any(Char.IsDigit) || txtFirstName.Text.Any(Char.IsPunctuation))
            {
                lblErrFNEdit.Text = "Invalid Entry.";
                lblErrFNEdit.Show();
                Okay = true;

            }
            if ((txtFN.Text == ""))
            {
                lblErrFNEdit.Text = "Required field.";
                lblErrFNEdit.Show();
                Okay = true;
            }
            if (txtLN.Text.Any(Char.IsDigit) || txtLN.Text.Any(Char.IsPunctuation))
            {
                lblErrLNEdit.Text = "Invalid Entry.";
                lblErrLNEdit.Show();
                Okay = true;
            }
            if (txtCN.Text != "")
            {
                if (txtCN.Text.Any(Char.IsLetter) || txtCN.Text.Any(Char.IsPunctuation) || txtCN.Text.Length != 11)
                {
                    lblErrContactEdit.Text = "Contact number can have 11 digits only.";
                    lblErrContactEdit.Show();
                    Okay = true;
                }
            }
            if (txtEmailCh.Text == (""))
            {
                lblErrEmailEdit.Text = "Required field.";
                lblErrEmailEdit.Show();
                Okay = true;

            }
            Regex Email = new Regex("[0-9a-zA-Z._]{1,20}@[a-z]{3,5}.[a-z]{2,3}");

            if (!Email.IsMatch(txtEmailCh.Text))
            {
                lblErrEmailEdit.Text = "Invalid Email.";
                lblErrEmailEdit.Show();
                Okay = true;
            }

            if (DTP2.Value > DateTime.Now)
            {
                lblErrDOBEdit.Text = "Invalid Date of birth.";
                lblErrDOBEdit.Show();
                Okay = true;

            }
            if (cmbGN.Text == "")
            {
                lblErrGenEdit.Text = "Required field.";
                lblErrGenEdit.Show();
                Okay = true;
            }
            if (txtReg.Text == "")
            {
                lblErrRegNoEdit.Text = "Required field";
                lblErrRegNoEdit.Show();
                Okay = true;

            }

            Regex RegNo = new Regex("[0-9]{4}-[A-Z]{2,4}-[0-9]{1,4}");
            if (!RegNo.IsMatch(txtReg.Text))
            {
                lblErrRegNoEdit.Text = "Wrong format. It should be as 2017-CS-987";
                lblErrRegNoEdit.Show();
                Okay = true;
            }
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "Select Id from Student where RegistrationNo = '" + txtReg.Text + "'";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            int exist = 0;
            exist = Convert.ToInt32(cmd.ExecuteScalar());
            if (exist != 0 && exist != Convert.ToInt32(lblEditStuId.Text))
            {
                lblErrRegNoEdit.Text = "This Regitration Number already exists.";
                lblErrRegNoEdit.Show();
                Okay = true;
            }
            Que1 = "Select Id from Person where Email = '" + txtEmailCh.Text + "'";
            exist = 0;
            cmd = new SqlCommand(Que1, sqlConn);
            exist = Convert.ToInt32(cmd.ExecuteScalar());
            if (exist != 0 && exist != Convert.ToInt32(lblEditStuId.Text))
            {
                lblErrEmailEdit.Text = "This Email already exists.";
                lblErrEmailEdit.Show();
                Okay = true;
            }
            if (!Okay)
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

                string que = "UPDATE PERSON SET FirstName = '" + txtFN.Text + "', LastName = '" + txtLN.Text + "', Contact = '" + txtCN.Text + "', Email = '" + txtEmailCh.Text + "', Gender = " + gen + ", DateOfBirth = '" + DTP2.Value + "'  where Person.Id = " + lblEditStuId.Text + "";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                que = "UPDATE Student SET RegistrationNo = '" + txtReg.Text + "' where Id = " + lblEditStuId.Text + "";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                Main m = new Main();
                m.Show();
                this.Hide();
            }
        }
        private void cmdCreate_Click_1(object sender, EventArgs e)
        {
            lblErrContact.Hide();
            lblErrDOB.Hide();
            lblErrEmail.Hide();
            lblErrFN.Hide();
            lblErrLN.Hide();
            lblErrGen.Hide();
            lblErrRegNo.Hide();
            bool Okay = false;
            if (txtFirstName.Text == "")
            {
                lblErrFN.Text = "Required field.";
                lblErrFN.Show();
                Okay = true;


            }
            if (txtFirstName.Text.Any(Char.IsDigit) || txtFirstName.Text.Any(Char.IsPunctuation))
            {
                lblErrFN.Text = "Invalid Entry.";
                lblErrFN.Show();
                Okay = true;

            }
           if (txtLastName.Text.Any(Char.IsDigit) || txtLastName.Text.Any(Char.IsPunctuation))
            {
                lblErrLN.Text = "Invalid Entry.";
                lblErrLN.Show();
                Okay = true;
            }
            if (txtContact.Text != "")
            {
                if (txtContact.Text.Any(Char.IsLetter) || txtContact.Text.Any(Char.IsPunctuation) || txtContact.Text.Length != 11)
                {
                    lblErrContact.Text = "Contact number can have 11 digits only.";
                    lblErrContact.Show();
                    Okay = true;
                }
            }
            if (txtEmail.Text == (""))
            {
                lblErrEmail.Text = "Required field.";
                lblErrEmail.Show();
                Okay = true;

            }
            Regex Email = new Regex("[0-9a-zA-Z._]{1,20}@[a-z]{3,5}.[a-z]{2,3}");

            if (!Email.IsMatch(txtEmail.Text))
            {
                lblErrEmail.Text = "Invalid Email.";
                lblErrEmail.Show();
                Okay = true;
            }

            if (DTP.Value > DateTime.Now)
            {
                lblErrDOB.Text = "Invalid Date of birth.";
                lblErrDOB.Show();
                Okay = true;

            }
            if (txtRegNo.Text == "")
            {
                lblErrRegNo.Text = "Required field";
                lblErrRegNo.Show();
                Okay = true;

            }

            Regex RegNo = new Regex("[0-9]{4}-[A-Z]{2,4}-[0-9]{1,4}");
            if (!RegNo.IsMatch(txtRegNo.Text))
            {
                lblErrRegNo.Text = "Wrong format. It should be as 2017-CS-987";
                lblErrRegNo.Show();
                Okay = true;
            }
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "Select Id from Student where RegistrationNo = '" + txtRegNo.Text + "'";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            int exist = 0;

            if (txtRegNo.Text != "")
            {
                exist = Convert.ToInt32(cmd.ExecuteScalar());
                if (exist != 0)
                {
                    lblErrRegNo.Text = "This Regitration Number already exists.";
                    lblErrRegNo.Show();
                    Okay = true;
                }
            }
            if (txtEmail.Text != "")

            {
                Que1 = "Select Id from Person where Email = '" + txtEmail.Text + "'";
                exist = 0;
                cmd = new SqlCommand(Que1, sqlConn);
                exist = Convert.ToInt32(cmd.ExecuteScalar());
                if (exist != 0)
                {
                    lblErrEmail.Text = "This Email already exists.";
                    lblErrEmail.Show();
                    Okay = true;
                }
            }
            if (cmbGender.Text == "")

            {
                lblErrGen.Text = "Required field.";
                lblErrGen.Show();
                Okay = true;

            }
            if (!Okay)
            {
                int gen = 0;
                if(cmbGender.Text != "")
                { 
                    if (cmbGender.Text == "Male")
                    {
                        gen = 1;
                    }
                    else
                    {
                        gen = 2;
                    }
                }
                Que1 = "INSERT INTO Person(FirstName, LastName,Contact,Email,DateOfBirth, Gender) values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + txtContact.Text + "', '" + txtEmail.Text + "', '" + DTP.Value + "', " + gen + ")";

                cmd = new SqlCommand(Que1, sqlConn);
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
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtContact.Text = "";
                cmbGender.Text = "";
                txtRegNo.Text = "";
                txtEmail.Text = "";
               

            }
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
            bool Okay = true;
            string Que1 = "Select Id from Project where Title = '" + txtTitle.Text + "'";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            int Id = -1;
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            if (txtTitle.Text == "")
            {
                lblErrProject.Text = "Required field";
                lblErrProject.Show();
                Okay = true;
            }
            if (Id == 0)
            {
                Okay = false;
                lblErrProject.Text = "This project does not exist.";
                lblErrProject.Show();
            }
            if (txtAdvisorId.Text == "")
            {
                Okay = false;
                lblErrAdvId.Text = "Required field.";
                lblErrAdvId.Show();
            }
            int exist = -1;
            if (Okay)
            {
               
                Que1 = "Select 1 from Advisor where Id = '" + txtAdvisorId.Text + "'";
                cmd = new SqlCommand(Que1, sqlConn);
                exist = Convert.ToInt32(cmd.ExecuteScalar());
                if (exist == 0)
                {
                    Okay = false;
                    lblErrAdvId.Text = "Advisor does not exist.";
                    lblErrAdvId.Show();
                }
            }
            if (DTPAssignmentDate.Value > DateTime.Now)
            {
                lblErrAssignDate.Text = "Invalid Assignment date.";
                lblErrAssignDate.Show();
                Okay = false;

            }
            if (cmbRole.Text == "")
            {
                lblErrAdvRole.Text = "Required field.";
                lblErrAdvRole.Show();
                Okay = false;
            }
            if (Okay)
            {
                Que1 = "SELECT Id from [Lookup] where Category = 'ADVISOR_ROLE' and Value = '" + cmbRole.Text + "'";
                cmd = new SqlCommand(Que1, sqlConn);
                exist  = Convert.ToInt32(cmd.ExecuteScalar());
                Que1 = "SELECT 1 from ProjectAdvisor where ProjectId = "+Id+" and AdvisorRole = "+exist+"";
                cmd = new SqlCommand(Que1, sqlConn);
                exist = Convert.ToInt32(cmd.ExecuteScalar());
                if (exist != 0)
                {
                    Okay = false;
                    lblErrAdvRole.Text = "This project has already been assigned a " + cmbRole.Text+". \n Change the role or edit from list.";
                    lblErrAdvRole.Show();
                }

            }
            if (Okay)
            {
                Que1 = "SELECT Id from [Lookup] where Category = 'ADVISOR_ROLE' and Value = '" + cmbRole.Text + "'";
                cmd = new SqlCommand(Que1, sqlConn);
                int AdvId = Convert.ToInt32(cmd.ExecuteScalar());
                Que1 = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) values (" + txtAdvisorId.Text + ", " + Id + ", " + AdvId + ", '" + DTPAssignmentDate.Value + "')";
                cmd = new SqlCommand(Que1, sqlConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project has  been assigned to advisor.");

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(4);
            this.Hide();
            m.Show();

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            lblErrDes.Hide();
            lblErrSal.Hide();
            lblErrId.Hide();
            bool Okay = false;
            if (txtId.Text == "")
            {
                lblErrId.Text = "Required field";
                lblErrId.Show();
                Okay = true;

            }
            if (txtId.Text.Any(Char.IsLetter) || txtId.Text.Any(Char.IsPunctuation))
            {
                lblErrId.Text = "Id can have digits only.";
                lblErrId.Show();
                Okay = true;
            }
            if (cmbDes.Text == "")
            {
                lblErrDes.Text = "Required field";
                lblErrDes.Show();
                Okay = true;

            }
            if (txtSalary.Text != "")
            {
                if (txtSalary.Text.Any(Char.IsLetter) || txtSalary.Text.Any(Char.IsPunctuation) || txtSalary.Text.Length < 4)
                {
                    lblErrSal.Text = "Salary can be in thousands only.";
                    lblErrSal.Show();
                    Okay = true;
                }
            }
            
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            if (txtId.Text != "")
            {
                string Que1 = "Select Id from Advisor where Id = " + txtId.Text + "";
                SqlCommand cmd = new SqlCommand(Que1, sqlConn);
                int exist = 0;
                exist = Convert.ToInt32(cmd.ExecuteScalar());
                if (exist != 0)
                {
                    lblErrId.Text = "This Advisor Id already exists.";
                    lblErrId.Show();
                    Okay = true;
                }
            }
            if (!Okay)
            {
                sqlConn = new SqlConnection(conn);
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
                string Que1 = "INSERT INTO advisor(Id, Designation, Salary) values (" + txtId.Text + ", " + Id + " ," + txtSalary.Text + ")";
                cmd = new SqlCommand(Que1, sqlConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Advisor added successfully.");
                sqlConn.Close();
                txtId.Text = "";
                cmbDes.Text = "";
                txtSalary.Text = "";
            }
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
            lblErrTitle.Hide();
            bool Okay = true;
            if (txtTitleProj.Text == "")
            {
                lblErrTitle.Text = "Required field";
                lblErrTitle.Show();
                Okay = false;
            }
            if (txtTitleProj.Text.Any(Char.IsDigit) || txtTitleProj.Text.Any(Char.IsPunctuation))
            {
                lblErrTitle.Text = "Invalid title.";
                lblErrTitle.Show();
                Okay = false;

            }
            if (Okay)
            {
                SqlConnection sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                string Que1 = "INSERT INTO Project(Title, Description) values ('" + txtTitleProj.Text + "', '" + RTBDescr.Text + "')";
                SqlCommand cmd = new SqlCommand(Que1, sqlConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project saved successfully.");
                txtTitleProj.Text = "";
                RTBDescr.Text = "";
            
            }

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
                string smd = "DELETE from ProjectAdvisor where AdvisorId = " + DGVAd[3, e.RowIndex].Value + "";
                SqlCommand cmd = new SqlCommand(smd, sqlConn);
                cmd.ExecuteNonQuery();
                string que = "Delete from Advisor where Id = " + DGVAd[3, e.RowIndex].Value + "";
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
                string smd = "SELECT * FROM ADVISOR where Id = " + DGVAd[3, e.RowIndex].Value + "";
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
                    if (!reader.IsDBNull(2))
                    {
                        txtSalaryCH.Text = reader.GetDecimal(2).ToString();
                    }

                }
                reader.Dispose();
                reader.Close();
                EditAdv = Convert.ToInt32(DGVAd[3, e.RowIndex].Value);
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
            string smd = "UPDATE ADVISOR set Designation = " + DesId + ", Salary = " + txtSalaryCH.Text + " where Id = " + lblEditAdvId.Text + "";
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
                que = "DELETE from Project where Id = " + ProjId + " ";
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

                que = "SELECT Title, Description from Project where Id = " + ProjId + " ";
                cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtTitleCh.Text = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                    {
                        RTBDescCh.Text = reader.GetString(1);
                    }

                }
                lblEditProjId.Text = ProjId.ToString();
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
            lblErrTitleEdit.Hide();
            bool Okay = true;
            if (txtTitleCh.Text == "")
            {
                lblErrTitleEdit.Text = "Required field";
                lblErrTitleEdit.Show();
                Okay = false;
            }
            if (txtTitleCh.Text.Any(Char.IsDigit) || txtTitleCh.Text.Any(Char.IsPunctuation))
            {
                lblErrTitleEdit.Text = "Invalid title.";
                lblErrTitleEdit.Show();
                Okay = false;

            }
            if (Okay)
            {
                SqlConnection sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                string Que = "UPDATE Project SET Title = '" + txtTitleCh.Text + "', Description = '" + RTBDescCh.Text + "' where Id = " + lblEditProjId.Text + "";
                SqlCommand cmd = new SqlCommand(Que, sqlConn);
                cmd.ExecuteNonQuery();
                Main m = new Main();
                m.ChangeTab(2);
                m.Show();
                this.Hide();
            }

        }

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(3);
            m.Show();
            this.Hide();
        }

        private void lnkAddEvaluation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            TControl.TabPages.Remove(TPEvaluations);
            TControl.TabPages.Insert(3, TPAddEvaluations);
            this.ChangeTab(3);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void cmdAddEva_Click(object sender, EventArgs e)
        {

            lblNEva.Hide();
            lblMarks.Hide();
            lblWeightage.Hide();
            bool Fine = true;
            if (txtNameEva.Text == "")
            {
                lblNEva.Text = "Required field";
                lblNEva.Show();
                Fine = false;
            }
            if (NUPMarks.Text == 0.ToString())
            {
                lblMarks.Text = "Marks must be greater than 0.";
                lblMarks.Show();
                Fine = false;
            }
            if (NUPweightage.Text == 0.ToString())
            {
                lblWeightage.Text = "Weightage must be greater than 0.";
                lblWeightage.Show();
                Fine = false;
            }
            if (Fine)
            {
                SqlConnection sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                string Que1 = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) values ('" + txtNameEva.Text + "', " + NUPMarks.Text + ", " + NUPweightage.Text + ")";
                SqlCommand cmd = new SqlCommand(Que1, sqlConn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation saved successfully.");
                txtNameEva.Text = "";
                NUPMarks.Text = 0.ToString();
                NUPweightage.Text = 0.ToString();
            }
        }

        private void DGVEvaluations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();

            if (e.ColumnIndex == 1)
            {
                string que = "SELECT Id from Evaluation where Name ='" + DGVEvaluations[2, e.RowIndex].Value + "' and TotalMarks = '" + DGVEvaluations[3, e.RowIndex].Value + "' and TotalWeightage = '" + DGVEvaluations[4, e.RowIndex].Value + "' ";
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
            if (e.ColumnIndex == 0)
            {
                string que = "SELECT Id from Evaluation where Name ='" + DGVEvaluations[2, e.RowIndex].Value + "' and TotalMarks = '" + DGVEvaluations[3, e.RowIndex].Value + "' and TotalWeightage = '" + DGVEvaluations[4, e.RowIndex].Value + "' ";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                lblEditEvaId.Text = (cmd.ExecuteScalar()).ToString();
                que = "Select Name, TotalMarks, TotalWeightage from Evaluation where Id = " + lblEditEvaId.Text + "";
                cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtNameEvaCh.Text = reader.GetString(0);
                    NUDTMarksCh.Text = reader.GetInt32(1).ToString();
                    NUDweightageCh.Text = reader.GetInt32(2).ToString();
                }
                TControl.TabPages.Remove(TPEvaluations);
                TControl.TabPages.Insert(3, TPEditEva);
                this.ChangeTab(3);
                
            }

        }

        private void cmdsaveEva_Click(object sender, EventArgs e)
        {
            bool Okay = true;
            lblWCH.Hide();
            lblTMCh.Hide();
            lblNameCh.Hide();
            if (txtNameEvaCh.Text == "")
            {
                lblNameCh.Text = "Required field";
                lblNameCh.Show();
               Okay = false;
            }
            if (NUDTMarksCh.Text == 0.ToString())
            {
                lblTMCh.Text = "Marks must be greater than 0.";
                lblTMCh.Show();
                Okay = false;
            }
            if (NUDweightageCh.Text == 0.ToString())
            {
                lblWCH.Text = "Weightage must be greater than 0.";
                lblWCH.Show();
                Okay = false;
            }
            if (Okay)
            {
                SqlConnection sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                string Que = "UPDATE Evaluation SET Name = '" + txtNameEvaCh.Text + "', TotalMarks = '" + NUDTMarksCh.Text + "', TotalWeightage = '" + NUDweightageCh.Text + "' where Id = " + lblEditEvaId.Text + "";
                SqlCommand cmd = new SqlCommand(Que, sqlConn);
                cmd.ExecuteNonQuery();
                Main m = new Main();
                m.ChangeTab(3);
                m.Show();
                this.Hide();
            }

        }

        private void DGVProjAdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);

            sqlConn.Open();
            if (e.ColumnIndex == 1)
            {
                string que = "DELETE from ProjectAdvisor where AdvisorId ='" + DGVProjAdv[2, e.RowIndex].Value + "' and ProjectId = '" + DGVProjAdv[3, e.RowIndex].Value + "' and AdvisorRole = '" + DGVProjAdv[4, e.RowIndex].Value + "' and AssignmentDate = '" + DGVProjAdv[5, e.RowIndex].Value + "'";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGVProjAdv.DataSource];
                currencyManager1.SuspendBinding();
                DGVProjAdv.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();
            }
            else if (e.ColumnIndex == 0)
            {
                lblProjAdvId.Text = DGVProjAdv[3, e.RowIndex].Value.ToString();
                lblIdAdvisor.Text = DGVProjAdv[2, e.RowIndex].Value.ToString(); 
                string que = "SELECT Title from Project where  Id = " + DGVProjAdv[3, e.RowIndex].Value + "";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtProjTitleCh.Text = reader.GetString(0);
                }
                reader.Dispose();
                reader.Close();
                DTPProjAdvCh.Text = DGVProjAdv[5, e.RowIndex].Value.ToString();
                txtAdvIdCh.Text = DGVProjAdv[2, e.RowIndex].Value.ToString();
               que = "SELECT Value from [Lookup] where  Category = 'ADVISOR_ROLE' and Id = " + DGVProjAdv[4, e.RowIndex].Value + "";
               cmd = new SqlCommand(que, sqlConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbAdvRoleCh.Text = reader.GetString(0);
                }
                TControl.TabPages.Insert(4, TPEditProjAdv);

                TControl.TabPages.Remove(TPProjAd);
                this.ChangeTab(4);

            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(3);
            m.Show();
            this.Hide();
        }

        private void txtContact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que = "Select Id from [Lookup] where Category = 'ADVISOR_ROLE' and Value = '" + cmbAdvRoleCh.Text + "'";
            SqlCommand cmd = new SqlCommand(Que, sqlConn);
            int IdAdvRole = Convert.ToInt32(cmd.ExecuteScalar());
            Que = "Select Id from Project where Title = '" + txtProjTitleCh.Text + "'";
            cmd = new SqlCommand(Que, sqlConn);
            int Id = Convert.ToInt32(cmd.ExecuteScalar());
            Que = "UPDATE ProjectAdvisor set AdvisorId = "+ txtAdvIdCh.Text+ ", ProjectId = "+ Id+ ", AssignmentDate = '"+DTPProjAdvCh.Value+"', AdvisorRole = "+IdAdvRole+" where AdvisorId = "+ lblIdAdvisor.Text+ " and ProjectId = "+lblProjAdvId.Text+"";
            cmd = new SqlCommand(Que, sqlConn);
            cmd.ExecuteNonQuery();
            Main m = new Main();
            m.ChangeTab(4);
            m.Show();
            this.Hide();

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lblBackProjEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(4);
            m.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void cmdCreateGroup_Click(object sender, EventArgs e)
        {
         }

        private void cmdCreateGroup_Click_1(object sender, EventArgs e)
        {
            lblErrMemCount.Hide();
            bool Okay = true;
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            DateTime Creation = DateTime.Now;
            List<int> Ids = new List<int>(), Status = new List<int>();
            int count = 0;
            for (int i = 0; i < DGVgroupStudents.RowCount; ++i)
            {
                if (Convert.ToInt32(DGVgroupStudents[0, i].Value) == 1)
                {
                    count++;
                   string qu = "SELECT Id from Student where RegistrationNo = '"+DGVgroupStudents[2,i].Value+"'";
                   SqlCommand cm = new SqlCommand(qu, sqlConn);
                  Ids.Add(Convert.ToInt32(cm.ExecuteScalar()));
                    if (Convert.ToInt32(DGVgroupStudents[1, i].Value) == 1)
                    {
                        qu = "SELECT Id from [LookUp] where Category = 'STATUS' and Value = 'Active'";
                       cm = new SqlCommand(qu, sqlConn);
                        Status.Add(Convert.ToInt32(cm.ExecuteScalar()));
                    }
                    else
                    {
                        qu = "SELECT Id from [LookUp] where Category = 'STATUS' and Value = 'InActive'";
                         cm = new SqlCommand(qu, sqlConn);
                        Status.Add(Convert.ToInt32(cm.ExecuteScalar()));

                    }

                }
            }
            if (count > 4)
            {
                lblErrMemCount.Text = "A group can have maximum 4 members only.";
                lblErrMemCount.Show();
                Okay = false;
            }
            else if (count == 0)
            {
                lblErrMemCount.Text = "A group should have minimum 1 member.";
                lblErrMemCount.Show();
                Okay = false;
            }
            if (Okay)
            {
                int Id;
                string que = "INSERT INTO [Group](Created_On) values ('" + Creation + "')";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                que = "SELECT Max(Id) from [Group]";
                cmd = new SqlCommand(que, sqlConn);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < count; ++i)
                {
                    que = "INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) values (" + Id + ", " + Ids[i] + ", " + Status[i] + ", '" + Creation + "')";
                    cmd = new SqlCommand(que, sqlConn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Group has been created.");
                Main m = new Main();
                TControl.TabPages.Remove(TPGroups);
                TControl.TabPages.Insert(5, TPAddGroup);
                m.ChangeTab(5);
                m.Show();
                this.Hide();


            }
        }

        private void lnkAddGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.TControl.TabPages.Insert(5, TPAddGroup);
            m.TControl.TabPages.Remove(TPGroups);
            m.ChangeTab(6);
            m.Show();
            this.Hide();
            
        }

        private void DGVGroupsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            if (e.ColumnIndex == 0)
            {
                string que = "SELECT RegistrationNo, Status FROM GroupStudent join Student on GroupStudent.StudentId = Student.Id where GroupStudent.GroupId = "+DGVGroupsList[2, e.RowIndex].Value+"";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                lblIdGroup.Text = DGVGroupsList[2, e.RowIndex].Value.ToString();
                lblGroupIdMem.Text = DGVGroupsList[2, e.RowIndex].Value.ToString();
                DGVDetails.DataSource = dt;
                if(dt.Rows.Count < 4)
                {
                    lnkAddNewMem.Show();
                }
                TControl.TabPages.Remove(TPGroups);
                TControl.TabPages.Insert(5, TPGroupDetail);
                this.ChangeTab(5);
            }
            else if (e.ColumnIndex == 1)
            {
                string que = "DELETE from GroupStudent where GroupId= " + DGVGroupsList[2, e.RowIndex].Value + "";
                SqlCommand cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                que = "DELETE from [Group] where Id = "+ DGVGroupsList[2, e.RowIndex].Value + "";
                cmd = new SqlCommand(que, sqlConn);
                cmd.ExecuteNonQuery();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGVGroupsList.DataSource];
                currencyManager1.SuspendBinding();
                DGVGroupsList.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();

            }

        }

        private void lblBacktoGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(5);
            m.Show();
            this.Hide();

        }

        private void lnkbackToGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.ChangeTab(5);
            m.Show();
            this.Hide();

        }

        private void lnkAddNewMem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TControl.TabPages.Remove(TPGroupDetail);
            TControl.TabPages.Insert(5, TPAddGrpMem);
            this.ChangeTab(5);
           

        }

        private void cmdAddMem_Click(object sender, EventArgs e)
        {

        }

        private void DGVgroupStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkBackToDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            TControl.TabPages.Remove(TPGroups);
            TControl.TabPages.Insert(5, TPGroupDetail);
            m.ChangeTab(5);
            m.Show();
            this.Hide();

        }
    }
}

