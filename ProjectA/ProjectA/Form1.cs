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
    public partial class Form1 : Form
    {
        string conn = "Data Source=MAMONA\\MAMONA;Initial Catalog=ProjectA;User ID=sa;Password=Mamona123";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(conn);
            sqlConn.Open();
            string Que1 = "INSERT INTO Person(FirstName, LastName,Contact,Email,DateOfBirth, Gender) values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + txtContact.Text + "', '" + txtEmail.Text + "', '" + DTP.Value + "', '" + Convert.ToInt32(txtGender.Text) + "')";
            SqlCommand cmd = new SqlCommand(Que1, sqlConn);
            cmd.ExecuteNonQuery();
            string Que3 = "Select Id from Person where Email = '" + txtEmail.Text + "'";
            cmd = new SqlCommand(Que3, sqlConn);
           SqlDataReader read =  cmd.ExecuteReader();
           Int32 Id = 0;
           while (read.Read())
           {
               Id = Convert.ToInt32(read.GetSqlInt32(0));
           }
            string Que4 = "INSERT INTO Student(Id, RegistrationNo) value (SELECT, '"+txtRegNo.Text+"')";
            cmd = new SqlCommand(Que4, sqlConn);
            MessageBox.Show("Done");


        }
    }
}
