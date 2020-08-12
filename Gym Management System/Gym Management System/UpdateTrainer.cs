using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class UpdateTrainer : Form
    {
        public UpdateTrainer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string sql = @"update trainer 
                            set dateofbirth  = '" + dtpDOB.Text + @"',
                            phone  = '" + txtPhone.Text + @"',
                            email  = '" + txtEmail.Text + @"',
                            address  = '" + txtAddress.Text + @"'
                            where id ='" + txtSearch.Text + @"';";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from trainer where id = '" + txtSearch.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            dtpDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtAddress.Text = ds.Tables[0].Rows[0][6].ToString();
            
        }
    }
}
