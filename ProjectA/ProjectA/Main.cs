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
            reader.Close();
            reader.Dispose();
            string q1 = "Select * from Advisor";
            cmd = new SqlCommand(q1, sqlConn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGVAd.DataSource = dt;

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
        }
   
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCreate_Click_1(object sender, EventArgs e)
        {

        }

        private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Stu add = new Add_Stu();
            add.Show();
            this.Hide();
        }
  
        private void TPStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Advisor ad = new Add_Advisor();
            ad.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
