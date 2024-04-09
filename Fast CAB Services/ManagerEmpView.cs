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
    public partial class Form_ManagerEmpView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\YD\CAB Management Systeam\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_ManagerEmpView()
        {
            InitializeComponent();
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_ManagerAllocationAdd fmaa = new Form_ManagerAllocationAdd();
            this.Hide();
            fmaa.Show();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_ManagerAllocationView fmav = new Form_ManagerAllocationView();
            this.Hide();
            fmav.Show();
        }

        private void Form_ManagerEmpView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Emp_Registation", con);
                adp.Fill(dt);
                dataGridView_EmployeeView.DataSource = dt;


            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong Please try Again...");
            }
        }

        private void dataGridView_EmployeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
