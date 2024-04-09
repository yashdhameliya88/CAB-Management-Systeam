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
    public partial class Form_AdminBillUpdate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\YD\CAB Management Systeam\Fast CAB Services\Database1.mdf;Integrated Security=True;User Instance=True");
    
        public Form_AdminBillUpdate()
        {
            InitializeComponent();
        }

        private void pictureBox_CloseButton_Click(object sender, EventArgs e)
        {
            Form_Admin fa = new Form_Admin();
            this.Hide();
            fa.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

  
    }
}