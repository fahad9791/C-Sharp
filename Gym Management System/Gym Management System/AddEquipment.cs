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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtEquipmentName.Text != "" && txtMusclesUsed.Text != "" && dtpDeliveryDate.Text != "" && txtCost.Text != "")
            {
                string sql = "insert into equipments values('" + txtEquipmentName.Text + "','" + txtMusclesUsed.Text + "','" + dtpDeliveryDate.Text + "','" + txtCost.Text + "');";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                MessageBox.Show("Equipment Added Successful", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill all the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtEquipmentName.Text = "";
            txtMusclesUsed.Text = "";
            dtpDeliveryDate.Value = DateTime.Now;
            txtCost.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Home ho = new Home();
            ho.Show();
             
        }
    }
}
