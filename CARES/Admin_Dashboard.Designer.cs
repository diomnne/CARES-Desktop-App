namespace CARES
{
    partial class Admin_Dashboard
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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.pnlRecentLogins = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblRecentLogins = new Guna.UI.WinForms.GunaLabel();
            this.lblRecentLoginsCtr = new Guna.UI.WinForms.GunaLabel();
            this.pnlPendingApprovals = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblPendingApprovals = new Guna.UI.WinForms.GunaLabel();
            this.lblPendingApprovalsCtr = new Guna.UI.WinForms.GunaLabel();
            this.pnlTotalUsers = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblNewUsers = new Guna.UI.WinForms.GunaLabel();
            this.lblUsersCtr = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnlRecentLogins.SuspendLayout();
            this.pnlPendingApprovals.SuspendLayout();
            this.pnlTotalUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lblDashboard.Location = new System.Drawing.Point(30, 30);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(215, 44);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(1434, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.gunaLinePanel1.Size = new System.Drawing.Size(600, 1630);
            this.gunaLinePanel1.TabIndex = 4;
            // 
            // pnlRecentLogins
            // 
            this.pnlRecentLogins.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.pnlRecentLogins.Controls.Add(this.lblRecentLogins);
            this.pnlRecentLogins.Controls.Add(this.lblRecentLoginsCtr);
            this.pnlRecentLogins.Location = new System.Drawing.Point(510, 219);
            this.pnlRecentLogins.Name = "pnlRecentLogins";
            this.pnlRecentLogins.Radius = 8;
            this.pnlRecentLogins.Size = new System.Drawing.Size(445, 250);
            this.pnlRecentLogins.TabIndex = 5;
            // 
            // lblRecentLogins
            // 
            this.lblRecentLogins.AutoSize = true;
            this.lblRecentLogins.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentLogins.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentLogins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblRecentLogins.Location = new System.Drawing.Point(37, 141);
            this.lblRecentLogins.Name = "lblRecentLogins";
            this.lblRecentLogins.Size = new System.Drawing.Size(197, 33);
            this.lblRecentLogins.TabIndex = 3;
            this.lblRecentLogins.Text = "Recent Logins";
            // 
            // lblRecentLoginsCtr
            // 
            this.lblRecentLoginsCtr.AutoSize = true;
            this.lblRecentLoginsCtr.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentLoginsCtr.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentLoginsCtr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblRecentLoginsCtr.Location = new System.Drawing.Point(31, 66);
            this.lblRecentLoginsCtr.Name = "lblRecentLoginsCtr";
            this.lblRecentLoginsCtr.Size = new System.Drawing.Size(57, 63);
            this.lblRecentLoginsCtr.TabIndex = 2;
            this.lblRecentLoginsCtr.Text = "0";
            // 
            // pnlPendingApprovals
            // 
            this.pnlPendingApprovals.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(219)))), ((int)(((byte)(218)))));
            this.pnlPendingApprovals.Controls.Add(this.lblPendingApprovals);
            this.pnlPendingApprovals.Controls.Add(this.lblPendingApprovalsCtr);
            this.pnlPendingApprovals.Location = new System.Drawing.Point(982, 219);
            this.pnlPendingApprovals.Name = "pnlPendingApprovals";
            this.pnlPendingApprovals.Radius = 8;
            this.pnlPendingApprovals.Size = new System.Drawing.Size(445, 250);
            this.pnlPendingApprovals.TabIndex = 6;
            // 
            // lblPendingApprovals
            // 
            this.lblPendingApprovals.AutoSize = true;
            this.lblPendingApprovals.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingApprovals.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingApprovals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblPendingApprovals.Location = new System.Drawing.Point(34, 141);
            this.lblPendingApprovals.Name = "lblPendingApprovals";
            this.lblPendingApprovals.Size = new System.Drawing.Size(263, 33);
            this.lblPendingApprovals.TabIndex = 9;
            this.lblPendingApprovals.Text = "Pending Approvals";
            // 
            // lblPendingApprovalsCtr
            // 
            this.lblPendingApprovalsCtr.AutoSize = true;
            this.lblPendingApprovalsCtr.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingApprovalsCtr.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingApprovalsCtr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblPendingApprovalsCtr.Location = new System.Drawing.Point(28, 66);
            this.lblPendingApprovalsCtr.Name = "lblPendingApprovalsCtr";
            this.lblPendingApprovalsCtr.Size = new System.Drawing.Size(57, 63);
            this.lblPendingApprovalsCtr.TabIndex = 8;
            this.lblPendingApprovalsCtr.Text = "0";
            // 
            // pnlTotalUsers
            // 
            this.pnlTotalUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.pnlTotalUsers.Controls.Add(this.gunaPictureBox1);
            this.pnlTotalUsers.Controls.Add(this.lblNewUsers);
            this.pnlTotalUsers.Controls.Add(this.lblUsersCtr);
            this.pnlTotalUsers.Location = new System.Drawing.Point(38, 219);
            this.pnlTotalUsers.Name = "pnlTotalUsers";
            this.pnlTotalUsers.Radius = 8;
            this.pnlTotalUsers.Size = new System.Drawing.Size(445, 250);
            this.pnlTotalUsers.TabIndex = 7;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.InitialImage = global::CARES.Properties.Resources.team;
            this.gunaPictureBox1.Location = new System.Drawing.Point(265, 52);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(145, 145);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblNewUsers
            // 
            this.lblNewUsers.AutoSize = true;
            this.lblNewUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsers.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblNewUsers.Location = new System.Drawing.Point(34, 141);
            this.lblNewUsers.Name = "lblNewUsers";
            this.lblNewUsers.Size = new System.Drawing.Size(147, 33);
            this.lblNewUsers.TabIndex = 1;
            this.lblNewUsers.Text = "New Users";
            // 
            // lblUsersCtr
            // 
            this.lblUsersCtr.AutoSize = true;
            this.lblUsersCtr.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersCtr.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCtr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblUsersCtr.Location = new System.Drawing.Point(28, 66);
            this.lblUsersCtr.Name = "lblUsersCtr";
            this.lblUsersCtr.Size = new System.Drawing.Size(57, 63);
            this.lblUsersCtr.TabIndex = 0;
            this.lblUsersCtr.Text = "0";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(38, 496);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1389, 500);
            this.gunaElipsePanel1.TabIndex = 8;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(2034, 1630);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.pnlTotalUsers);
            this.Controls.Add(this.pnlPendingApprovals);
            this.Controls.Add(this.pnlRecentLogins);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.lblDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Dashboard";
            this.Text = "Dashboard";
            this.pnlRecentLogins.ResumeLayout(false);
            this.pnlRecentLogins.PerformLayout();
            this.pnlPendingApprovals.ResumeLayout(false);
            this.pnlPendingApprovals.PerformLayout();
            this.pnlTotalUsers.ResumeLayout(false);
            this.pnlTotalUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaElipsePanel pnlRecentLogins;
        private Guna.UI.WinForms.GunaElipsePanel pnlPendingApprovals;
        private Guna.UI.WinForms.GunaElipsePanel pnlTotalUsers;
        private Guna.UI.WinForms.GunaLabel lblNewUsers;
        private Guna.UI.WinForms.GunaLabel lblUsersCtr;
        private Guna.UI.WinForms.GunaLabel lblRecentLogins;
        private Guna.UI.WinForms.GunaLabel lblRecentLoginsCtr;
        private Guna.UI.WinForms.GunaLabel lblPendingApprovals;
        private Guna.UI.WinForms.GunaLabel lblPendingApprovalsCtr;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}