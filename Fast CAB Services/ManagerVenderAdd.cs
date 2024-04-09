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
    public partial class Form_ManagerVenderAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\YD\CAB Management Systeam\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");

        public Form_ManagerVenderAdd()
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

        private void Form_ManagerVenderAdd_Load(object sender, EventArgs e)
        {
            //Get Vihicle Name From Table Vehicle
            con.Open();
            SqlDataAdapter adapt1 = new SqlDataAdapter("Select * from tbl_Vehicle", con);
            DataTable dt1 = new DataTable();
            adapt1.Fill(dt1);
            comboBox_VehicleName.DisplayMember = "VName";
            comboBox_VehicleName.ValueMember = "VID";
            comboBox_VehicleName.DataSource = dt1;
            con.Close();

            //Get Source & Destination List From Table Route
            con.Open();
            SqlDataAdapter adapt2 = new SqlDataAdapter("Select * from tbl_Route", con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            ComboBox_Source.DisplayMember = "Source";
            ComboBox_Source.ValueMember = "RouteID";
            ComboBox_Source.DataSource = dt2;
            con.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Vehicle Type radioButton values...
                string strVType = "";
                if (radiobtn_AC.Checked == true)
                {
                    strVType = radiobtn_AC.Text;
                }
                else
                {
                    strVType = radiobtn_NonAC.Text;
                }

                //Get DOB Values...
                DateTime dt = dateTimePicker_DOB.Value;


                //Get Vehicle Name comboBox values...
                string strVehicle = Convert.ToString(comboBox_VehicleName.SelectedValue);

                //Get Source Name comboBox values...
                string strSource = Convert.ToString(ComboBox_Source.SelectedValue);

                //Get Destination Name comboBox values...
                string strDestination = Convert.ToString(ComboBox_Destination.SelectedValue);

                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("insert into tbl_Vender values('" + txt_VenderID.Text + "','" + txt_VenderName.Text + "','" + strVehicle + "','" + strVType + "','" + dt + "','" + strSource + "','" + strDestination + "','" + txt_Address.Text + "','" + txt_PhoneNo.Text + "')", con);
                adp.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Vender Data Insert SuccessFully...");

                txt_VenderID.Text = "";
                txt_VenderName.Text = "";
                comboBox_VehicleName.Text = "Select Vehicle";
                dateTimePicker_DOB.Text = "";
                ComboBox_Source.Text = "Select Source";
                ComboBox_Destination.Text = "Select Destination";
                txt_Address.Text = "";
                txt_PhoneNo.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Something Want to Worng Please Try Again...");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_VenderID.Text = "";
            txt_VenderName.Text = "";
            comboBox_VehicleName.Text = "Select Vehicle";
            dateTimePicker_DOB.Text = "";
            ComboBox_Source.Text = "Select Source";
            ComboBox_Destination.Text = "Select Destination";
            txt_Address.Text = "";
            txt_PhoneNo.Text = "";
        }
    }
}
