using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblErrorLogin.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            
          


        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPword.Text == "FYPAdmin")
            {
                Main Add_Stu = new Main();
                Add_Stu.Show();
                this.Hide();
            }
            else
            {
                lblErrorLogin.Text = "Invalid Username or Password.";
                lblErrorLogin.Show();
            
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
