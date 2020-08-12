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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        public Profile (string userName) : this()
        {
            this.lblOutUserName.Text = userName;
            string sql = "select * from registration where username = '" + this.lblOutUserName.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);


            
            lblOutGender.Text = ds.Tables[0].Rows[0][3].ToString();
            lblOutDOB.Text = ds.Tables[0].Rows[0][4].ToString();
            lblOutPhone.Text = ds.Tables[0].Rows[0][5].ToString();
            lblOutEmail.Text = ds.Tables[0].Rows[0][6].ToString();
            lblOutAddress.Text = ds.Tables[0].Rows[0][7].ToString();
            lblOutJoinDate.Text = ds.Tables[0].Rows[0][8].ToString();
            lblOutGymTime.Text = ds.Tables[0].Rows[0][9].ToString();
            lblOutMembershipTime.Text = ds.Tables[0].Rows[0][10].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
