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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from registration where username = '" + txtSearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);


                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                dtpDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][7].ToString();
                cmbGymTime.Text = ds.Tables[0].Rows[0][9].ToString();
                cmbMembershipTime.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                string sql = @"update registration 
                            set name  = '" + txtName.Text + @"',
                            dateofbirth  = '" + dtpDOB.Text + @"',
                            phone  = '" + txtPhone.Text + @"',
                            email  = '" + txtEmail.Text + @"',
                            address  = '" + txtAddress.Text + @"',
                            gymtime  = '" + cmbGymTime.Text + @"',
                            membershiptime  = '" + cmbMembershipTime.Text + @"'
                            where username ='" + txtSearch.Text + @"';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);


                MessageBox.Show("Saved", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You didn't enter any Username", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Home ho = new Home();
            ho.Show();
        }
    }
}
