﻿namespace Fast_CAB_Services
{
    partial class Form_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manager));
            this.panel_LoginPage = new System.Windows.Forms.Panel();
            this.gradientColor1 = new Fast_CAB_Services.GradientColor();
            this.pictureBox_Logout = new System.Windows.Forms.PictureBox();
            this.menuStrip_HR_Manager = new System.Windows.Forms.MenuStrip();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel_Logout = new System.Windows.Forms.LinkLabel();
            this.panel_CABLogo = new System.Windows.Forms.Panel();
            this.pictureBox__CABLogo = new System.Windows.Forms.PictureBox();
            this.gradientColor_TitleBar = new Fast_CAB_Services.GradientColor();
            this.lbl_Administator = new System.Windows.Forms.Label();
            this.pictureBox_MinimizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox_MaximizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox_CloseButton = new System.Windows.Forms.PictureBox();
            this.panel_LoginPage.SuspendLayout();
            this.gradientColor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).BeginInit();
            this.menuStrip_HR_Manager.SuspendLayout();
            this.panel_CABLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__CABLogo)).BeginInit();
            this.gradientColor_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LoginPage
            // 
            this.panel_LoginPage.BackColor = System.Drawing.Color.Transparent;
            this.panel_LoginPage.Controls.Add(this.gradientColor1);
            this.panel_LoginPage.Controls.Add(this.panel_CABLogo);
            this.panel_LoginPage.Controls.Add(this.gradientColor_TitleBar);
            this.panel_LoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_LoginPage.Location = new System.Drawing.Point(0, 0);
            this.panel_LoginPage.Name = "panel_LoginPage";
            this.panel_LoginPage.Size = new System.Drawing.Size(1296, 774);
            this.panel_LoginPage.TabIndex = 5;
            // 
            // gradientColor1
            // 
            this.gradientColor1.ColorBottom = System.Drawing.Color.White;
            this.gradientColor1.ColorTop = System.Drawing.Color.DarkBlue;
            this.gradientColor1.Controls.Add(this.pictureBox_Logout);
            this.gradientColor1.Controls.Add(this.menuStrip_HR_Manager);
            this.gradientColor1.Controls.Add(this.linkLabel_Logout);
            this.gradientColor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradientColor1.Location = new System.Drawing.Point(12, 175);
            this.gradientColor1.Name = "gradientColor1";
            this.gradientColor1.Size = new System.Drawing.Size(1277, 38);
            this.gradientColor1.TabIndex = 3;
            // 
            // pictureBox_Logout
            // 
            this.pictureBox_Logout.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logout.Image")));
            this.pictureBox_Logout.Location = new System.Drawing.Point(1243, 5);
            this.pictureBox_Logout.Name = "pictureBox_Logout";
            this.pictureBox_Logout.Size = new System.Drawing.Size(34, 30);
            this.pictureBox_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logout.TabIndex = 3;
            this.pictureBox_Logout.TabStop = false;
            this.pictureBox_Logout.Click += new System.EventHandler(this.pictureBox_Logout_Click);
            // 
            // menuStrip_HR_Manager
            // 
            this.menuStrip_HR_Manager.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip_HR_Manager.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_HR_Manager.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_HR_Manager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem3,
            this.shiftScheduleToolStripMenuItem});
            this.menuStrip_HR_Manager.Location = new System.Drawing.Point(0, 5);
            this.menuStrip_HR_Manager.Name = "menuStrip_HR_Manager";
            this.menuStrip_HR_Manager.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_HR_Manager.Size = new System.Drawing.Size(473, 31);
            this.menuStrip_HR_Manager.TabIndex = 4;
            this.menuStrip_HR_Manager.Text = "menuStrip HR Manager";
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegistationToolStripMenuItem,
            this.employeeViewToolStripMenuItem,
            this.employeeUpdateToolStripMenuItem});
            this.EmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(155, 27);
            this.EmployeeToolStripMenuItem.Text = "Employee-Details";
            // 
            // employeeRegistationToolStripMenuItem
            // 
            this.employeeRegistationToolStripMenuItem.Image = global::Fast_CAB_Services.Properties.Resources.Registation;
            this.employeeRegistationToolStripMenuItem.Name = "employeeRegistationToolStripMenuItem";
            this.employeeRegistationToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.employeeRegistationToolStripMenuItem.Text = "Employee Registation";
            this.employeeRegistationToolStripMenuItem.Click += new System.EventHandler(this.employeeRegistationToolStripMenuItem_Click);
            // 
            // employeeViewToolStripMenuItem
            // 
            this.employeeViewToolStripMenuItem.Image = global::Fast_CAB_Services.Properties.Resources.EYE11;
            this.employeeViewToolStripMenuItem.Name = "employeeViewToolStripMenuItem";
            this.employeeViewToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.employeeViewToolStripMenuItem.Text = "Employee View";
            this.employeeViewToolStripMenuItem.Click += new System.EventHandler(this.employeeViewToolStripMenuItem_Click);
            // 
            // employeeUpdateToolStripMenuItem
            // 
            this.employeeUpdateToolStripMenuItem.Name = "employeeUpdateToolStripMenuItem";
            this.employeeUpdateToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.employeeUpdateToolStripMenuItem.Text = "Employee Update";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.viewToolStripMenuItem2,
            this.updateToolStripMenuItem2});
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.changePasswordToolStripMenuItem.Text = "Vender";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(195, 28);
            this.addToolStripMenuItem2.Text = "Vender Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // viewToolStripMenuItem2
            // 
            this.viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            this.viewToolStripMenuItem2.Size = new System.Drawing.Size(195, 28);
            this.viewToolStripMenuItem2.Text = "Vender View";
            this.viewToolStripMenuItem2.Click += new System.EventHandler(this.viewToolStripMenuItem2_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(195, 28);
            this.updateToolStripMenuItem2.Text = "Vender Update";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 27);
            this.toolStripMenuItem3.Text = "Allocation";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(136, 28);
            this.toolStripMenuItem4.Text = "Add";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(136, 28);
            this.toolStripMenuItem5.Text = "View";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(136, 28);
            this.toolStripMenuItem6.Text = "Update";
            // 
            // shiftScheduleToolStripMenuItem
            // 
            this.shiftScheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem4,
            this.viewToolStripMenuItem4,
            this.updateToolStripMenuItem4});
            this.shiftScheduleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftScheduleToolStripMenuItem.Name = "shiftScheduleToolStripMenuItem";
            this.shiftScheduleToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
            this.shiftScheduleToolStripMenuItem.Text = "Bill";
            // 
            // addToolStripMenuItem4
            // 
            this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            this.addToolStripMenuItem4.Size = new System.Drawing.Size(136, 28);
            this.addToolStripMenuItem4.Text = "Add";
            // 
            // viewToolStripMenuItem4
            // 
            this.viewToolStripMenuItem4.Name = "viewToolStripMenuItem4";
            this.viewToolStripMenuItem4.Size = new System.Drawing.Size(136, 28);
            this.viewToolStripMenuItem4.Text = "View";
            // 
            // updateToolStripMenuItem4
            // 
            this.updateToolStripMenuItem4.Name = "updateToolStripMenuItem4";
            this.updateToolStripMenuItem4.Size = new System.Drawing.Size(136, 28);
            this.updateToolStripMenuItem4.Text = "Update";
            // 
            // linkLabel_Logout
            // 
            this.linkLabel_Logout.AutoSize = true;
            this.linkLabel_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_Logout.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Logout.Location = new System.Drawing.Point(1148, 4);
            this.linkLabel_Logout.Name = "linkLabel_Logout";
            this.linkLabel_Logout.Size = new System.Drawing.Size(93, 29);
            this.linkLabel_Logout.TabIndex = 1;
            this.linkLabel_Logout.TabStop = true;
            this.linkLabel_Logout.Text = "Logout";
            this.linkLabel_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Logout_LinkClicked);
            // 
            // panel_CABLogo
            // 
            this.panel_CABLogo.Controls.Add(this.pictureBox__CABLogo);
            this.panel_CABLogo.Location = new System.Drawing.Point(12, 48);
            this.panel_CABLogo.Name = "panel_CABLogo";
            this.panel_CABLogo.Size = new System.Drawing.Size(1277, 128);
            this.panel_CABLogo.TabIndex = 1;
            // 
            // pictureBox__CABLogo
            // 
            this.pictureBox__CABLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__CABLogo.Image")));
            this.pictureBox__CABLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox__CABLogo.Name = "pictureBox__CABLogo";
            this.pictureBox__CABLogo.Size = new System.Drawing.Size(1277, 128);
            this.pictureBox__CABLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__CABLogo.TabIndex = 0;
            this.pictureBox__CABLogo.TabStop = false;
            // 
            // gradientColor_TitleBar
            // 
            this.gradientColor_TitleBar.ColorBottom = System.Drawing.Color.RoyalBlue;
            this.gradientColor_TitleBar.ColorTop = System.Drawing.Color.Cyan;
            this.gradientColor_TitleBar.Controls.Add(this.lbl_Administator);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_MinimizeButton);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_MaximizeButton);
            this.gradientColor_TitleBar.Controls.Add(this.pictureBox_CloseButton);
            this.gradientColor_TitleBar.Location = new System.Drawing.Point(12, 12);
            this.gradientColor_TitleBar.Name = "gradientColor_TitleBar";
            this.gradientColor_TitleBar.Size = new System.Drawing.Size(1277, 30);
            this.gradientColor_TitleBar.TabIndex = 0;
            // 
            // lbl_Administator
            // 
            this.lbl_Administator.AutoSize = true;
            this.lbl_Administator.Location = new System.Drawing.Point(2, 3);
            this.lbl_Administator.Name = "lbl_Administator";
            this.lbl_Administator.Size = new System.Drawing.Size(132, 25);
            this.lbl_Administator.TabIndex = 5;
            this.lbl_Administator.Text = "Administator";
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
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 774);
            this.Controls.Add(this.panel_LoginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Manager";
            this.panel_LoginPage.ResumeLayout(false);
            this.gradientColor1.ResumeLayout(false);
            this.gradientColor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).EndInit();
            this.menuStrip_HR_Manager.ResumeLayout(false);
            this.menuStrip_HR_Manager.PerformLayout();
            this.panel_CABLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__CABLogo)).EndInit();
            this.gradientColor_TitleBar.ResumeLayout(false);
            this.gradientColor_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LoginPage;
        private GradientColor gradientColor1;
        private System.Windows.Forms.PictureBox pictureBox_Logout;
        private System.Windows.Forms.MenuStrip menuStrip_HR_Manager;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shiftScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem4;
        private System.Windows.Forms.LinkLabel linkLabel_Logout;
        private System.Windows.Forms.Panel panel_CABLogo;
        private System.Windows.Forms.PictureBox pictureBox__CABLogo;
        private GradientColor gradientColor_TitleBar;
        private System.Windows.Forms.Label lbl_Administator;
        private System.Windows.Forms.PictureBox pictureBox_MinimizeButton;
        private System.Windows.Forms.PictureBox pictureBox_MaximizeButton;
        private System.Windows.Forms.PictureBox pictureBox_CloseButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}