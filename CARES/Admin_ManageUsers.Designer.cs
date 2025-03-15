namespace CARES
{
    partial class Admin_ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlRight = new Guna.UI.WinForms.GunaLinePanel();
            this.pnlUsersContainer = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnlOutline = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnAllUsers = new Guna.UI.WinForms.GunaButton();
            this.btnClinicStaff = new Guna.UI.WinForms.GunaButton();
            this.btnStudents = new Guna.UI.WinForms.GunaButton();
            this.dtgUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.profilePic = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUsersContainer.SuspendLayout();
            this.pnlOutline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lblDashboard.Location = new System.Drawing.Point(30, 30);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(272, 44);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Manage Users";
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlRight.LineLeft = 1;
            this.pnlRight.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlRight.Location = new System.Drawing.Point(1434, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.pnlRight.Size = new System.Drawing.Size(600, 1229);
            this.pnlRight.TabIndex = 5;
            // 
            // pnlUsersContainer
            // 
            this.pnlUsersContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsersContainer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnlUsersContainer.Controls.Add(this.dtgUsers);
            this.pnlUsersContainer.Location = new System.Drawing.Point(2, 1);
            this.pnlUsersContainer.Name = "pnlUsersContainer";
            this.pnlUsersContainer.Radius = 8;
            this.pnlUsersContainer.Size = new System.Drawing.Size(1385, 796);
            this.pnlUsersContainer.TabIndex = 8;
            // 
            // pnlOutline
            // 
            this.pnlOutline.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlOutline.Controls.Add(this.pnlUsersContainer);
            this.pnlOutline.Location = new System.Drawing.Point(38, 250);
            this.pnlOutline.Name = "pnlOutline";
            this.pnlOutline.Radius = 8;
            this.pnlOutline.Size = new System.Drawing.Size(1389, 800);
            this.pnlOutline.TabIndex = 7;
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.AnimationHoverSpeed = 0.07F;
            this.btnAllUsers.AnimationSpeed = 0.03F;
            this.btnAllUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnAllUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnAllUsers.BorderSize = 1;
            this.btnAllUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllUsers.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAllUsers.Image = null;
            this.btnAllUsers.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAllUsers.Location = new System.Drawing.Point(38, 160);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAllUsers.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnAllUsers.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnAllUsers.OnHoverImage = null;
            this.btnAllUsers.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnAllUsers.Radius = 8;
            this.btnAllUsers.Size = new System.Drawing.Size(250, 100);
            this.btnAllUsers.TabIndex = 8;
            this.btnAllUsers.Text = "All Users";
            this.btnAllUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // btnClinicStaff
            // 
            this.btnClinicStaff.AnimationHoverSpeed = 0.07F;
            this.btnClinicStaff.AnimationSpeed = 0.03F;
            this.btnClinicStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnClinicStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnClinicStaff.BorderSize = 1;
            this.btnClinicStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicStaff.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClinicStaff.Image = null;
            this.btnClinicStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClinicStaff.Location = new System.Drawing.Point(296, 160);
            this.btnClinicStaff.Name = "btnClinicStaff";
            this.btnClinicStaff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClinicStaff.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnClinicStaff.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnClinicStaff.OnHoverImage = null;
            this.btnClinicStaff.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnClinicStaff.Radius = 8;
            this.btnClinicStaff.Size = new System.Drawing.Size(250, 100);
            this.btnClinicStaff.TabIndex = 10;
            this.btnClinicStaff.Text = "Clinic Staff";
            this.btnClinicStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClinicStaff.Click += new System.EventHandler(this.btnClinicStaff_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.AnimationHoverSpeed = 0.07F;
            this.btnStudents.AnimationSpeed = 0.03F;
            this.btnStudents.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnStudents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnStudents.BorderSize = 1;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStudents.Image = null;
            this.btnStudents.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStudents.Location = new System.Drawing.Point(554, 160);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStudents.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnStudents.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnStudents.OnHoverImage = null;
            this.btnStudents.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btnStudents.Radius = 8;
            this.btnStudents.Size = new System.Drawing.Size(250, 100);
            this.btnStudents.TabIndex = 11;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AllowUserToDeleteRows = false;
            this.dtgUsers.AllowUserToResizeColumns = false;
            this.dtgUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsers.ColumnHeadersHeight = 40;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profilePic,
            this.ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgUsers.EnableHeadersVisualStyles = false;
            this.dtgUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgUsers.Location = new System.Drawing.Point(3, 11);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgUsers.RowHeadersVisible = false;
            this.dtgUsers.RowHeadersWidth = 70;
            this.dtgUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgUsers.RowTemplate.Height = 45;
            this.dtgUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsers.Size = new System.Drawing.Size(1379, 764);
            this.dtgUsers.TabIndex = 1;
            this.dtgUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dtgUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgUsers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.dtgUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgUsers.ThemeStyle.ReadOnly = true;
            this.dtgUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgUsers.ThemeStyle.RowsStyle.Height = 45;
            this.dtgUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // profilePic
            // 
            this.profilePic.HeaderText = "";
            this.profilePic.MinimumWidth = 10;
            this.profilePic.Name = "profilePic";
            this.profilePic.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Admin_ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(2034, 1229);
            this.Controls.Add(this.pnlOutline);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnAllUsers);
            this.Controls.Add(this.btnClinicStaff);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_ManageUsers";
            this.Text = "Admin_ManageUsers";
            this.pnlUsersContainer.ResumeLayout(false);
            this.pnlOutline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private Guna.UI.WinForms.GunaLinePanel pnlRight;
        private Guna.UI.WinForms.GunaElipsePanel pnlUsersContainer;
        private Guna.UI.WinForms.GunaElipsePanel pnlOutline;
        private Guna.UI.WinForms.GunaButton btnAllUsers;
        private Guna.UI.WinForms.GunaButton btnClinicStaff;
        private Guna.UI.WinForms.GunaButton btnStudents;
        private Guna.UI.WinForms.GunaDataGridView dtgUsers;
        private System.Windows.Forms.DataGridViewImageColumn profilePic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}