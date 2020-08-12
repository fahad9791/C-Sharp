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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.Show();
            this.Close();
        }

        private void addTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrainer at = new AddTrainer();
            at.Show();
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMember um = new UpdateMember();
            um.Show();
            this.Close();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateTrainer ut = new UpdateTrainer();
            ut.Show();
            this.Close();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipment ae = new AddEquipment();
            ae.Show();
            this.Close();
        }

        private void deleteEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEquipment de = new DeleteEquipment();
            de.Show();
            this.Close();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
            this.Close();
        }

        private void trainerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchTrainer st = new SearchTrainer();
            st.Show();
            this.Close();
        }

        private void memberToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
            this.Close();
        }

        private void trainerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteTrainer dt = new DeleteTrainer();
            dt.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout now", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login log = new Login();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close your application. \nConfirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                Application.Exit();
                }
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
