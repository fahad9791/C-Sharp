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
    public partial class AddTrainer : Form
    {
        public AddTrainer()
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
            if (txtName.Text != "" && cmbGender.Text != "" && dtpDOB.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && dtpJoinDate.Text != "")
            {
                string sql = "insert into trainer values('" + txtName.Text + "','" + cmbGender.Text + "','" + dtpDOB.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + dtpJoinDate.Text + "');";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                MessageBox.Show("Trainer Added Successful", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill all the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtpDOB.Value = DateTime.Now;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            dtpJoinDate.Value = DateTime.Now;
        }
    }
}
