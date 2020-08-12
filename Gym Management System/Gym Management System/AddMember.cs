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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Home ho = new Home();
            ho.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtName.Text != "" && txtPassword.Text != "" && cmbGender.Text != "" && dtpDOB.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && dtpJoinDate.Text != "" && cmbGymTime.Text != "" && cmbMembershipTime.Text != "")
                {
                    string sql = "insert into registration values('" + txtUserName.Text + "','" + txtName.Text + "','" + txtPassword.Text + "','" + cmbGender.Text + "','" + dtpDOB.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + dtpJoinDate.Text + "','" + cmbGymTime.Text + "','" + cmbMembershipTime.Text + "');";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    MessageBox.Show("Member Added Successful", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Fill all the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("This user name already used", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            dtpDOB.Value = DateTime.Now;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            dtpJoinDate.Value = DateTime.Now;

        }
    }
}
