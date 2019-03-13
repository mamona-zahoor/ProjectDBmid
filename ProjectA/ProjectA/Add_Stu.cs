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
    public partial class Add_Stu : Form
    {
        public Add_Stu()
        {
            InitializeComponent();
        }
        string conn = "Data Source=MAMONA\\MAMONA;Initial Catalog=ProjectA;User ID=sa;Password=Mamona123";

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
    }
}
