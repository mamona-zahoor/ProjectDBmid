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
            reader.Close();
            reader.Dispose();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGV.DataSource = dt;
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
   

    }
}
