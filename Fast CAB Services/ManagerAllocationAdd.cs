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
    public partial class Form_ManagerAllocationAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Sem 4\GUI\Fast CAB Services\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_ManagerAllocationAdd()
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

        private void Form_ManagerAllocationAdd_Load(object sender, EventArgs e)
        {
            //Get Employye Name From Table Employee
            con.Open();
            SqlDataAdapter adapt1 = new SqlDataAdapter("Select * from tbl_Emp_Registation", con);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            ComboBox_EmpName.DisplayMember = "EmpName";
            ComboBox_EmpName.ValueMember = "EmpID";
            ComboBox_EmpName.DataSource = dt1;
            con.Close();

            //Get VenderID From Table Vender
            con.Open();
            SqlDataAdapter adapt2 = new SqlDataAdapter("Select * from tbl_Vender", con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            ComboBox_VenderID.DisplayMember = "VenderID";
            ComboBox_VenderID.ValueMember = "VenderID";
            ComboBox_VenderID.DataSource = dt2;
            con.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Employee ID ComboBox values...
                string strEmpID = Convert.ToString(ComboBox_EmpName.SelectedValue);

                //Get Vender ID comboBox values...
                string strVenderID = Convert.ToString(ComboBox_VenderID.SelectedValue);

                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("insert into tbl_Allocation values('" + strEmpID + "','" + strVenderID + "')", con);
                adp.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Allocation Data Insert SuccessFully...");

                ComboBox_EmpName.Text = "Select Employee Name";
                ComboBox_VenderID.Text = "Select Vender ID";
            }
            catch (Exception)
            {
                MessageBox.Show("Already Allocate This Vender...");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ComboBox_EmpName.Text = "Select Employee Name";
            ComboBox_VenderID.Text = "Select Vender ID";
        }
    }
}
