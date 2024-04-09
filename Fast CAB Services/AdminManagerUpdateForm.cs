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
    public partial class Form_AdminManagerUpdateForm : Form
    {
        public Form_AdminManagerUpdateForm()
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
