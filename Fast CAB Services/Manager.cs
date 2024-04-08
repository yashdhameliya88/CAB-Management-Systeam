using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fast_CAB_Services
{
    public partial class Form_Manager : Form
    {
        public Form_Manager()
        {
            InitializeComponent();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Login fl = new Form_Login();
            this.Hide();
            fl.Show();
        }

        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            this.Hide();
            fl.Show();
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeRegistationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ManagerEmpRegistation fmer = new Form_ManagerEmpRegistation();
            this.Hide();
            fmer.Show();
        }

        private void employeeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ManagerEmpView fmev = new Form_ManagerEmpView();
            this.Hide();
            fmev.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_ManagerVenderAdd fmva = new Form_ManagerVenderAdd();
            this.Hide();
            fmva.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_ManagerVenderView fmvv = new Form_ManagerVenderView();
            this.Hide();
            fmvv.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_ManagerAllocationAdd fmaa = new Form_ManagerAllocationAdd();
            this.Hide();
            fmaa.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form_ManagerAllocationView fmav = new Form_ManagerAllocationView();
            this.Hide();
            fmav.Show();
        }

    }
}
