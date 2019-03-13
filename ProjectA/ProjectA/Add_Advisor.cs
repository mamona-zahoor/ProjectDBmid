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
    public partial class Add_Advisor : Form
    {
        string conn = "Data Source=MAMONA\\MAMONA;Initial Catalog=ProjectA;User ID=sa;Password=Mamona123";


        public Add_Advisor()
        {
            InitializeComponent();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void Add_Advisor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
