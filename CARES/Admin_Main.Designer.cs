﻿namespace CARES
{
    partial class Admin_Main
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
            this.pnlNavbar = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblCopyright = new Guna.UI.WinForms.GunaLabel();
            this.btnInventory = new Guna.UI.WinForms.GunaButton();
            this.btnRecords = new Guna.UI.WinForms.GunaButton();
            this.btnSchedule = new Guna.UI.WinForms.GunaButton();
            this.btnUsers = new Guna.UI.WinForms.GunaButton();
            this.btnLogTrail = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.pnlLogo = new Guna.UI.WinForms.GunaPanel();
            this.btnLogo = new Guna.UI.WinForms.GunaImageButton();
            this.pnlOuterContainer = new Guna.UI.WinForms.GunaPanel();
            this.pnlFormContainer = new Guna.UI.WinForms.GunaPanel();
            this.pnlHeader = new Guna.UI.WinForms.GunaLinePanel();
            this.pnlNavbar.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlOuterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.pnlNavbar.Controls.Add(this.gunaPanel1);
            this.pnlNavbar.Controls.Add(this.btnInventory);
            this.pnlNavbar.Controls.Add(this.btnRecords);
            this.pnlNavbar.Controls.Add(this.btnSchedule);
            this.pnlNavbar.Controls.Add(this.btnUsers);
            this.pnlNavbar.Controls.Add(this.btnLogTrail);
            this.pnlNavbar.Controls.Add(this.btnDashboard);
            this.pnlNavbar.Controls.Add(this.pnlLogo);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.pnlNavbar.Size = new System.Drawing.Size(500, 1529);
            this.pnlNavbar.TabIndex = 39;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lblCopyright);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(25, 1379);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(450, 150);
            this.gunaPanel1.TabIndex = 12;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCopyright.Location = new System.Drawing.Point(57, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(306, 30);
            this.lblCopyright.TabIndex = 11;
            this.lblCopyright.Text = "Copyright © 2025, WLC-CARES.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInventory
            // 
            this.btnInventory.AnimationHoverSpeed = 0.07F;
            this.btnInventory.AnimationSpeed = 0.03F;
            this.btnInventory.BaseColor = System.Drawing.Color.Transparent;
            this.btnInventory.BorderColor = System.Drawing.Color.Black;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnInventory.Image = global::CARES.Properties.Resources.medicineIcon;
            this.btnInventory.ImageOffsetX = 10;
            this.btnInventory.ImageSize = new System.Drawing.Size(17, 17);
            this.btnInventory.Location = new System.Drawing.Point(25, 750);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnInventory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInventory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnInventory.OnHoverImage = null;
            this.btnInventory.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnInventory.Radius = 7;
            this.btnInventory.Size = new System.Drawing.Size(450, 120);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "Medicine Inventory";
            this.btnInventory.TextOffsetX = 10;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.AnimationHoverSpeed = 0.07F;
            this.btnRecords.AnimationSpeed = 0.03F;
            this.btnRecords.BaseColor = System.Drawing.Color.Transparent;
            this.btnRecords.BorderColor = System.Drawing.Color.Black;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecords.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnRecords.Image = global::CARES.Properties.Resources.recordsIcon;
            this.btnRecords.ImageOffsetX = 10;
            this.btnRecords.ImageSize = new System.Drawing.Size(17, 17);
            this.btnRecords.Location = new System.Drawing.Point(25, 630);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnRecords.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRecords.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnRecords.OnHoverImage = null;
            this.btnRecords.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnRecords.Radius = 7;
            this.btnRecords.Size = new System.Drawing.Size(450, 120);
            this.btnRecords.TabIndex = 9;
            this.btnRecords.Text = "Medical Records";
            this.btnRecords.TextOffsetX = 10;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.AnimationHoverSpeed = 0.07F;
            this.btnSchedule.AnimationSpeed = 0.03F;
            this.btnSchedule.BaseColor = System.Drawing.Color.Transparent;
            this.btnSchedule.BorderColor = System.Drawing.Color.Black;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnSchedule.Image = global::CARES.Properties.Resources.scheduleIcon;
            this.btnSchedule.ImageOffsetX = 10;
            this.btnSchedule.ImageSize = new System.Drawing.Size(17, 17);
            this.btnSchedule.Location = new System.Drawing.Point(25, 510);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSchedule.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSchedule.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnSchedule.OnHoverImage = null;
            this.btnSchedule.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnSchedule.Radius = 7;
            this.btnSchedule.Size = new System.Drawing.Size(450, 120);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Consultation Schedule";
            this.btnSchedule.TextOffsetX = 10;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AnimationHoverSpeed = 0.07F;
            this.btnUsers.AnimationSpeed = 0.03F;
            this.btnUsers.BaseColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnUsers.Image = global::CARES.Properties.Resources.accountsIcon;
            this.btnUsers.ImageOffsetX = 10;
            this.btnUsers.ImageSize = new System.Drawing.Size(17, 17);
            this.btnUsers.Location = new System.Drawing.Point(25, 390);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUsers.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnUsers.OnHoverImage = null;
            this.btnUsers.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnUsers.Radius = 7;
            this.btnUsers.Size = new System.Drawing.Size(450, 120);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.TextOffsetX = 10;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogTrail
            // 
            this.btnLogTrail.AnimationHoverSpeed = 0.07F;
            this.btnLogTrail.AnimationSpeed = 0.03F;
            this.btnLogTrail.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogTrail.BorderColor = System.Drawing.Color.Black;
            this.btnLogTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogTrail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogTrail.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogTrail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnLogTrail.Image = global::CARES.Properties.Resources.logsIcon;
            this.btnLogTrail.ImageOffsetX = 10;
            this.btnLogTrail.ImageSize = new System.Drawing.Size(17, 17);
            this.btnLogTrail.Location = new System.Drawing.Point(25, 270);
            this.btnLogTrail.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnLogTrail.Name = "btnLogTrail";
            this.btnLogTrail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnLogTrail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogTrail.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnLogTrail.OnHoverImage = null;
            this.btnLogTrail.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnLogTrail.Radius = 7;
            this.btnLogTrail.Size = new System.Drawing.Size(450, 120);
            this.btnLogTrail.TabIndex = 6;
            this.btnLogTrail.Text = "Log Trail";
            this.btnLogTrail.TextOffsetX = 10;
            this.btnLogTrail.Click += new System.EventHandler(this.btnLogTrail_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnDashboard.Image = global::CARES.Properties.Resources.dashIcon;
            this.btnDashboard.ImageOffsetX = 10;
            this.btnDashboard.ImageSize = new System.Drawing.Size(17, 17);
            this.btnDashboard.Location = new System.Drawing.Point(25, 150);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(234)))));
            this.btnDashboard.Radius = 7;
            this.btnDashboard.Size = new System.Drawing.Size(450, 120);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffsetX = 10;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(25, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(450, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.Image = global::CARES.Properties.Resources.online_doctor_concept_illustration;
            this.btnLogo.ImageSize = new System.Drawing.Size(120, 120);
            this.btnLogo.Location = new System.Drawing.Point(92, 22);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.OnHoverImage = null;
            this.btnLogo.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogo.Size = new System.Drawing.Size(287, 104);
            this.btnLogo.TabIndex = 0;
            // 
            // pnlOuterContainer
            // 
            this.pnlOuterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnlOuterContainer.Controls.Add(this.pnlFormContainer);
            this.pnlOuterContainer.Controls.Add(this.pnlHeader);
            this.pnlOuterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuterContainer.Location = new System.Drawing.Point(500, 0);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Size = new System.Drawing.Size(2034, 1529);
            this.pnlOuterContainer.TabIndex = 40;
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContainer.Location = new System.Drawing.Point(0, 150);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(2034, 1379);
            this.pnlFormContainer.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LineBottom = 1;
            this.pnlHeader.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlHeader.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2034, 150);
            this.pnlHeader.TabIndex = 3;
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.pnlOuterContainer);
            this.Controls.Add(this.pnlNavbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNavbar.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlOuterContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel pnlNavbar;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private Guna.UI.WinForms.GunaPanel pnlLogo;
        private Guna.UI.WinForms.GunaPanel pnlOuterContainer;
        private Guna.UI.WinForms.GunaButton btnInventory;
        private Guna.UI.WinForms.GunaButton btnRecords;
        private Guna.UI.WinForms.GunaButton btnSchedule;
        private Guna.UI.WinForms.GunaButton btnUsers;
        private Guna.UI.WinForms.GunaButton btnLogTrail;
        private Guna.UI.WinForms.GunaImageButton btnLogo;
        private Guna.UI.WinForms.GunaPanel pnlFormContainer;
        private Guna.UI.WinForms.GunaLinePanel pnlHeader;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lblCopyright;
    }
}