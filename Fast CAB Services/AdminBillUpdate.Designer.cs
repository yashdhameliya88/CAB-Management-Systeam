namespace Fast_CAB_Services
{
    partial class Form_AdminBillUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminBillUpdate));
            this.panel_LoginPage = new System.Windows.Forms.Panel();
            this.gradientColor_Emp_Reg_Form = new Fast_CAB_Services.GradientColor();
            this.comboBox_VenderID = new System.Windows.Forms.ComboBox();
            this.txt_VenderID = new System.Windows.Forms.TextBox();
            this.lbl_VenderID = new System.Windows.Forms.Label();
            this.lbl_BillID = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.lbl_BillUpdate = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gradientColor_TitleBar = new Fast_CAB_Services.GradientColor();
            this.lbl_AdminBillUpdate = new System.Windows.Forms.Label();
            this.pictureBox_MinimizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox_MaximizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox_CloseButton = new System.Windows.Forms.PictureBox();
            this.panel_LoginPage.SuspendLayout();
            this.gradientColor_Emp_Reg_Form.SuspendLayout();
            this.gradientColor_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LoginPage
            // 
            this.panel_LoginPage.BackColor = System.Drawing.Color.Transparent;
            this.panel_LoginPage.Controls.Add(this.gradientColor_Emp_Reg_Form);
            this.panel_LoginPage.Controls.Add(this.gradientColor_TitleBar);
            this.panel_LoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_LoginPage.Location = new System.Drawing.Point(0, 0);
            this.panel_LoginPage.Name = "panel_LoginPage";
            this.panel_LoginPage.Size = new System.Drawing.Size(1294, 768);
            this.panel_LoginPage.TabIndex = 16;
            // 
            // gradientColor_Emp_Reg_Form
            // 
            this.gradientColor_Emp_Reg_Form.ColorBottom = System.Drawing.Color.Khaki;
            this.gradientColor_Emp_Reg_Form.ColorTop = System.Drawing.Color.SkyBlue;
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.comboBox_VenderID);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.txt_VenderID);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.lbl_VenderID);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.lbl_BillID);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.btn_View);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.lbl_BillUpdate);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.btn_Delete);
            this.gradientColor_Emp_Reg_Form.Controls.Add(this.btn_Update);
            this.gradientColor_Emp_Reg_Form.Location = new System.Drawing.Point(12, 48);
            this.gradientColor_Emp_Reg_Form.Name = "gradientColor_Emp_Reg_Form";
            this.gradientColor_Emp_Reg_Form.Size = new System.Drawing.Size(1277, 719);
            this.gradientColor_Emp_Reg_Form.TabIndex = 6;
            // 
            // comboBox_VenderID
            // 
            this.comboBox_VenderID.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_VenderID.FormattingEnabled = true;
            this.comboBox_VenderID.Location = new System.Drawing.Point(526, 276);
            this.comboBox_VenderID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_VenderID.Name = "comboBox_VenderID";
            this.comboBox_VenderID.Size = new System.Drawing.Size(341, 33);
            this.comboBox_VenderID.TabIndex = 86;
            this.comboBox_VenderID.Text = "Select Vender ID";
            // 
            // txt_VenderID
            // 
            this.txt_VenderID.Location = new System.Drawing.Point(526, 235);
            this.txt_VenderID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VenderID.Name = "txt_VenderID";
            this.txt_VenderID.Size = new System.Drawing.Size(341, 30);
            this.txt_VenderID.TabIndex = 85;
            // 
            // lbl_VenderID
            // 
            this.lbl_VenderID.AutoSize = true;
            this.lbl_VenderID.Location = new System.Drawing.Point(401, 284);
            this.lbl_VenderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VenderID.Name = "lbl_VenderID";
            this.lbl_VenderID.Size = new System.Drawing.Size(109, 25);
            this.lbl_VenderID.TabIndex = 84;
            this.lbl_VenderID.Text = "Vender ID";
            // 
            // lbl_BillID
            // 
            this.lbl_BillID.AutoSize = true;
            this.lbl_BillID.Location = new System.Drawing.Point(442, 240);
            this.lbl_BillID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BillID.Name = "lbl_BillID";
            this.lbl_BillID.Size = new System.Drawing.Size(68, 25);
            this.lbl_BillID.TabIndex = 83;
            this.lbl_BillID.Text = "Bill ID";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_View.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_View.Location = new System.Drawing.Point(875, 235);
            this.btn_View.Margin = new System.Windows.Forms.Padding(4);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(119, 37);
            this.btn_View.TabIndex = 80;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            // 
            // lbl_BillUpdate
            // 
            this.lbl_BillUpdate.AutoSize = true;
            this.lbl_BillUpdate.Location = new System.Drawing.Point(592, 154);
            this.lbl_BillUpdate.Name = "lbl_BillUpdate";
            this.lbl_BillUpdate.Size = new System.Drawing.Size(203, 25);
            this.lbl_BillUpdate.TabIndex = 4;
            this.lbl_BillUpdate.Text = "Bill Update / Delete ";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_Delete.Location = new System.Drawing.Point(736, 346);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 37);
            this.btn_Delete.TabIndex = 77;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Location = new System.Drawing.Point(576, 346);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(119, 37);
            this.btn_Update.TabIndex = 67;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // gradientColor_TitleBar
            // 
            this.gradientColor_TitleBar.ColorBottom = System.Drawing.Color.RoyalBlue;
            this.gradientColor_TitleBar.ColorTop = System.Drawing.Color.Cyan;
            this.gradientColor_TitleBar.Controls.Add(this.lbl_AdminBillUpdate);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_MinimizeButton);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_MaximizeButton);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_CloseButton);
            this.gradientColor_TitleBar.Location = new System.Drawing.Point(12, 12);
            this.gradientColor_TitleBar.Name = "gradientColor_TitleBar";
            this.gradientColor_TitleBar.Size = new System.Drawing.Size(1277, 30);
            this.gradientColor_TitleBar.TabIndex = 0;
            // 
            // lbl_AdminBillUpdate
            // 
            this.lbl_AdminBillUpdate.AutoSize = true;
            this.lbl_AdminBillUpdate.Location = new System.Drawing.Point(2, 3);
            this.lbl_AdminBillUpdate.Name = "lbl_AdminBillUpdate";
            this.lbl_AdminBillUpdate.Size = new System.Drawing.Size(197, 25);
            this.lbl_AdminBillUpdate.TabIndex = 5;
            this.lbl_AdminBillUpdate.Text = "Admin - Bill Update";
            // 
            // pictureBox_MinimizeButton
            // 
            this.pictureBox_MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MinimizeButton.Image")));
            this.pictureBox_MinimizeButton.Location = new System.Drawing.Point(1160, 0);
            this.pictureBox_MinimizeButton.Name = "pictureBox_MinimizeButton";
            this.pictureBox_MinimizeButton.Size = new System.Drawing.Size(34, 30);
            this.pictureBox_MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MinimizeButton.TabIndex = 2;
            this.pictureBox_MinimizeButton.TabStop = false;
            // 
            // pictureBox_MaximizeButton
            // 
            this.pictureBox_MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MaximizeButton.Image")));
            this.pictureBox_MaximizeButton.Location = new System.Drawing.Point(1200, 0);
            this.pictureBox_MaximizeButton.Name = "pictureBox_MaximizeButton";
            this.pictureBox_MaximizeButton.Size = new System.Drawing.Size(34, 30);
            this.pictureBox_MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MaximizeButton.TabIndex = 1;
            this.pictureBox_MaximizeButton.TabStop = false;
            // 
            // pictureBox_CloseButton
            // 
            this.pictureBox_CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CloseButton.Image")));
            this.pictureBox_CloseButton.Location = new System.Drawing.Point(1240, 0);
            this.pictureBox_CloseButton.Name = "pictureBox_CloseButton";
            this.pictureBox_CloseButton.Size = new System.Drawing.Size(34, 30);
            this.pictureBox_CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CloseButton.TabIndex = 0;
            this.pictureBox_CloseButton.TabStop = false;
            this.pictureBox_CloseButton.Click += new System.EventHandler(this.pictureBox_CloseButton_Click);
            // 
            // Form_AdminBillUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 768);
            this.Controls.Add(this.panel_LoginPage);
            this.Name = "Form_AdminBillUpdate";
            this.Text = "AdminBillUpdate";
            this.panel_LoginPage.ResumeLayout(false);
            this.gradientColor_Emp_Reg_Form.ResumeLayout(false);
            this.gradientColor_Emp_Reg_Form.PerformLayout();
            this.gradientColor_TitleBar.ResumeLayout(false);
            this.gradientColor_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LoginPage;
        private GradientColor gradientColor_Emp_Reg_Form;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Label lbl_BillUpdate;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private GradientColor gradientColor_TitleBar;
        private System.Windows.Forms.Label lbl_AdminBillUpdate;
        private System.Windows.Forms.PictureBox pictureBox_MinimizeButton;
        private System.Windows.Forms.PictureBox pictureBox_MaximizeButton;
        private System.Windows.Forms.PictureBox pictureBox_CloseButton;
        private System.Windows.Forms.ComboBox comboBox_VenderID;
        private System.Windows.Forms.TextBox txt_VenderID;
        private System.Windows.Forms.Label lbl_VenderID;
        private System.Windows.Forms.Label lbl_BillID;
    }
}