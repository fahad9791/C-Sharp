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
    public partial class DeleteEquipment : Form
    {
        public DeleteEquipment()
        {
            InitializeComponent();

            string sql = "select * from equipments;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string serial = this.dataGridView1.CurrentRow.Cells["serial"].Value.ToString();

                string sql = "delete from equipments where serial = '" + serial + "' ;";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                MessageBox.Show("Deleted", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from equipments where name like '" + this.txtSearch.Text + "%';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from equipments where name = '" + this.txtSearch.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
            string sql = "select * from equipments;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home ho = new Home();
            ho.Show();
        }
    }
}
