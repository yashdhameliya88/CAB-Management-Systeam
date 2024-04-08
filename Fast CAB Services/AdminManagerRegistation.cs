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
    public partial class Form_AdminManagerRegistation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Sem 4\GUI\Fast CAB Services\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");
        
        public Form_AdminManagerRegistation()
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
                if (radioButton_Male.Checked == true)
                {
                    strGender = radioButton_Male.Text;
                }
                else
                {
                    strGender = radioButton_Female.Text;
                }

                //Get City ComboBox values...
                string strCity = comboBox_City.SelectedItem.ToString();

                //Get User Post ComboBox values...
                string strUserPost = ComboBox_UserPost.SelectedItem.ToString();
                
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("insert into tbl_Manager_Registation values('"+txt_ManagerID.Text+"','" + txt_ManagerName.Text + "','" + txt_Contact.Text + "','" + dt + "','" + strGender + "','" + strCity + "','" + txt_CurrentAddress.Text + "','" + txt_PerAddress.Text + "','"+ strUserPost +"','"+txt_UserID.Text+"','"+txt_Password.Text+"')", con);
                adp.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Manager's Data Insert SuccessFully...");

                txt_ManagerID.Text = "";
                txt_ManagerName.Text = "";
                txt_Contact.Text = "";
                dateTimePicker_DOB.Text = "";
                txt_CurrentAddress.Text = "";
                txt_PerAddress.Text = "";
                txt_UserID.Text = "";
                txt_Password.Text = "";
                comboBox_City.Text = "Select City";
                ComboBox_UserPost.Text = "Select User Post";

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
            Form_Admin fah = new Form_Admin();
            this.Hide();
            fah.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ManagerID.Text = "";
            txt_ManagerName.Text = "";
            txt_Contact.Text = "";
            dateTimePicker_DOB.Text = "";
            txt_CurrentAddress.Text = "";
            txt_PerAddress.Text = "";
            txt_UserID.Text = "";
            txt_Password.Text = "";
            comboBox_City.Text = "Select City";
            ComboBox_UserPost.Text = "Select User Post";
        }
    }
}
