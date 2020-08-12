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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string username, string password) : this()
        {
            this.lblUserName.Text = username;
            this.lblPasswordInfo.Text = password;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(this.txtCurrentPassword.Text == this.lblPasswordInfo.Text && this.txtCurrentPassword.Text != "" && this.txtNewPassword.Text != this.txtCurrentPassword.Text && this.txtNewPassword.Text != "" && this.txtConfirmPassword.Text == this.txtNewPassword.Text && this.txtConfirmPassword.Text != "")
            {
                string sql = @"update registration 
                                set password  = '" + this.txtConfirmPassword.Text + @"' 
                                where username ='" + this.lblUserName.Text + @"';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                MessageBox.Show("Password Changed", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("Incorrect Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
