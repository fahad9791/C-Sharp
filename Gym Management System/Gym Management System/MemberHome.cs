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
    public partial class MemberHome : Form
    {
        public MemberHome()
        {
            InitializeComponent();
        }

        public MemberHome(string userName, string password) : this()
        {
            this.lblUserName.Text = userName;
            this.lblPassword.Text = password;

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile(this.lblUserName.Text);
            pro.Show();
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer tra = new Trainer();
            tra.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout now", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application. \nConfirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(this.lblUserName.Text, this.lblPassword.Text);
            cp.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
