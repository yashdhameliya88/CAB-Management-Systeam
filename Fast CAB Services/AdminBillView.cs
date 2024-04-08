using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fast_CAB_Services
{
    public partial class Form_AdminBillView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Sem 4\GUI\Fast CAB Services\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");
    
        public Form_AdminBillView()
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

        private void ManagerRegistationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminManagerRegistation fmr = new Form_AdminManagerRegistation();
            this.Hide();
            fmr.Show();
        }

        private void ManagerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminManagerView famv = new Form_AdminManagerView();
            this.Hide();
            famv.Show();
        }

        private void employeeRegistationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminEmployeeRegistation faer = new Form_AdminEmployeeRegistation();
            this.Hide();
            faer.Show();
        }

        private void employeeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminEmployeeView faev = new Form_AdminEmployeeView();
            this.Hide();
            faev.Show();
        }

        private void routeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminRouteAdd fara = new Form_AdminRouteAdd();
            this.Hide();
            fara.Show();
        }

        private void routeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminRouteView farv = new Form_AdminRouteView();
            this.Hide();
            farv.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_AdminVehicleAdd fava = new Form_AdminVehicleAdd();
            this.Hide();
            fava.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_AdminVehicleView favv = new Form_AdminVehicleView();
            this.Hide();
            favv.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_AdminVenderAdd favea = new Form_AdminVenderAdd();
            this.Hide();
            favea.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_AdminVenderView favev = new Form_AdminVenderView();
            this.Hide();
            favev.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_AdminAllocationAdd faaa = new Form_AdminAllocationAdd();
            this.Hide();
            faaa.Show();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_AdminManagerUpdate1 faav = new Form_AdminManagerUpdate1();
            this.Hide();
            faav.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_AdminBillAdd faba = new Form_AdminBillAdd();
            this.Hide();
            faba.Show();
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_AdminBillView fabv = new Form_AdminBillView();
            this.Hide();
            fabv.Show();
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void managerUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminManagerUpdateForm famuf = new Form_AdminManagerUpdateForm();
            this.Hide();
            famuf.Show();
        }

        private void routeUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminRouteUpdate faru = new Form_AdminRouteUpdate();
            this.Hide();
            faru.Show();
        }

        private void employeeUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AdminEmployeeUpdate faeuf = new Form_AdminEmployeeUpdate();
            this.Hide();
            faeuf.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_AdminVehicleUpdate favup = new Form_AdminVehicleUpdate();
            this.Hide();
            favup.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_AdminVenderUpdate favuf = new Form_AdminVenderUpdate();
            this.Hide();
            favuf.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_AdminAllocationUpdate faauf = new Form_AdminAllocationUpdate();
            this.Hide();
            faauf.Show();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_AdminBillUpdate fabuf = new Form_AdminBillUpdate();
            this.Hide();
            fabuf.Show();
        }
    }
}
