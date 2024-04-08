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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void txt_UserName_Enter(object sender, EventArgs e)
        {
            string userid = txt_UserID.Text;
            if (userid.ToLower().Trim().Equals("user id"))
            {
                txt_UserID.Text = "";
                txt_UserID.ForeColor = Color.Black;

            }
        }
        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            string userid = txt_UserID.Text;
            if (userid.ToLower().Trim().Equals("user id") || userid.Trim().Equals(""))
            {
                txt_UserID.Text = "user id";
                txt_UserID.ForeColor = Color.Gray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            string password = txt_Password.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                txt_Password.Text = "";
                txt_Password.UseSystemPasswordChar = true;
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            string password = txt_Password.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                txt_Password.Text = "password";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.Gray;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string strUserPost = comboBox_UserPost.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Sem 4\GUI\Fast CAB Services\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");
                if (strUserPost == "Admin")
                {
                    String query = "select * from tbl_Administator_Login where UserID='" + txt_UserID.Text.Trim() + "' and Password='" + txt_Password.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    //Admin Login...
                    if (dt.Rows.Count == 1)
                    {

                        MessageBox.Show("Admin Login SuccessFully...");
                        Form_Admin fa = new Form_Admin();
                        this.Hide();
                        fa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check Your Password/UserName invalid...");
                    }
                }


                //Manager Login...
                if (strUserPost == "Manager")
                {
                    String query1 = "select * from tbl_Manager_Registation where UserPost='" + strUserPost.Trim() + "' and UserID='" + txt_UserID.Text.Trim() + "' and Password='" + txt_Password.Text.Trim() + "'";
                    SqlDataAdapter adp1 = new SqlDataAdapter(query1, con);
                    DataTable dt1 = new DataTable();
                    adp1.Fill(dt1);
                    if (dt1.Rows.Count == 1)
                    {
                        comboBox_UserPost.SelectedIndex = -1;
                        txt_UserID.Text = "";
                        txt_Password.Text = "";
                        MessageBox.Show("Manager Login SuccessFully...");
                        Form_Manager fm = new Form_Manager();
                        this.Hide();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check Your Password/UserName invalid...");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Want to Wrong Please Try Again...");
            }
        }
     }
}
            





