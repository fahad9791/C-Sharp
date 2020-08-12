using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkShow.Text == "Show")
            {
                linkShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                linkShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void linkJoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration regi = new Registration();
            regi.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string sql = "select * from registration where username = '" + this.txtUserName.Text + "' and password = '" + this.txtPassword.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);


            if (txtUserName.Text == "Admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Login approved for " + txtUserName.Text);
                Home ho = new Home();
                ho.Show();
                txtUserName.Text = "";
                txtPassword.Text = "";

            }
            else if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login approved for " + ds.Tables[0].Rows[0][1].ToString());
                MemberHome mh = new MemberHome(this.txtUserName.Text, this.txtPassword.Text);
                mh.Show();
                txtUserName.Text = "";
                txtPassword.Text = "";

            }
            else
            {
                MessageBox.Show("Login Invalid");
                
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
