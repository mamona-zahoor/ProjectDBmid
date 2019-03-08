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
                Add_Student Add_Stu = new Add_Student();
                Add_Stu.Show();
                this.Hide();
            }
        }
    }
}
