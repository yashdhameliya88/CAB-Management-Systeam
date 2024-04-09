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
    public partial class Form_AdminEmployeeRegistation : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\YD\CAB Management Systeam\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");
        
        public Form_AdminEmployeeRegistation()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {

                //Get DOB Values...
                DateTime dt = dateTimePicker_DOB.Value;

                //Get Gender radioButton values...
                string strGender = "";
                if (RadioBtn_Male.Checked == true)
                {
                    strGender = RadioBtn_Male.Text;
                }
                else
                {
                    strGender = RadioBtn_Female.Text;
                }

                //Get City comboBox values...
                string strCity = ComboBox_City.SelectedItem.ToString();

                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("insert into tbl_Emp_Registation values('"+txt_EmployeeID.Text+"','" + txt_Emp_Name.Text + "','" + txt_Contact.Text + "','" + dt + "','" + strGender + "','" + strCity + "','" + txt_CurrentAddress.Text + "','" + txt_PerAddress.Text + "','" + txt_Vehicle_Require.Text + "','" + txt_Qulification.Text + "','" + txt_Time_Span.Text + "')", con);
                adp.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Data Insert SuccessFully...");

                txt_EmployeeID.Text = "";
                txt_Emp_Name.Text = "";
                txt_Contact.Text = "";
                dateTimePicker_DOB.Text = "";
                ComboBox_City.Text = "Select City";
                txt_CurrentAddress.Text = "";
                txt_PerAddress.Text = "";
                txt_Vehicle_Require.Text = "";
                txt_Qulification.Text = "";
                txt_Time_Span.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Something Want to Worng Please Try Again...");
            }
        
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Form_Admin fa = new Form_Admin();
            this.Hide();
            fa.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Admin fa = new Form_Admin();
            this.Hide();
            fa.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.Text = "";
            txt_Emp_Name.Text = "";
            txt_Contact.Text = "";
            dateTimePicker_DOB.Text = "";
            ComboBox_City.Text = "Select City";
            txt_CurrentAddress.Text = "";
            txt_PerAddress.Text = "";
            txt_Vehicle_Require.Text = "";
            txt_Qulification.Text = "";
            txt_Time_Span.Text = "";
        }

    }

}
