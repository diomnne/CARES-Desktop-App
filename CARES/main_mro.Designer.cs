namespace CARES
{
    partial class main_mro
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
            this.pnl_sidebar = new Guna.UI.WinForms.GunaPanel();
            this.btn_manage_records = new FontAwesome.Sharp.IconButton();
            this.btn_medical_records = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.pnl_logo = new Guna.UI.WinForms.GunaPanel();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnl_sidebar.Controls.Add(this.btn_manage_records);
            this.pnl_sidebar.Controls.Add(this.btn_medical_records);
            this.pnl_sidebar.Controls.Add(this.btn_dashboard);
            this.pnl_sidebar.Controls.Add(this.pnl_logo);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(450, 1529);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // btn_manage_records
            // 
            this.btn_manage_records.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manage_records.FlatAppearance.BorderSize = 0;
            this.btn_manage_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_records.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_records.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_manage_records.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btn_manage_records.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_manage_records.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_manage_records.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manage_records.Location = new System.Drawing.Point(0, 400);
            this.btn_manage_records.Name = "btn_manage_records";
            this.btn_manage_records.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_manage_records.Size = new System.Drawing.Size(450, 100);
            this.btn_manage_records.TabIndex = 3;
            this.btn_manage_records.Text = "   Manage Records";
            this.btn_manage_records.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manage_records.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_manage_records.UseVisualStyleBackColor = true;
            this.btn_manage_records.Click += new System.EventHandler(this.btn_manage_records_Click);
            // 
            // btn_medical_records
            // 
            this.btn_medical_records.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_medical_records.FlatAppearance.BorderSize = 0;
            this.btn_medical_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medical_records.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medical_records.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_medical_records.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_medical_records.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_medical_records.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_medical_records.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medical_records.Location = new System.Drawing.Point(0, 300);
            this.btn_medical_records.Name = "btn_medical_records";
            this.btn_medical_records.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_medical_records.Size = new System.Drawing.Size(450, 100);
            this.btn_medical_records.TabIndex = 2;
            this.btn_medical_records.Text = "   Medical Records";
            this.btn_medical_records.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medical_records.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_medical_records.UseVisualStyleBackColor = true;
            this.btn_medical_records.Click += new System.EventHandler(this.btn_medical_records_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
            this.btn_dashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(162)))));
            this.btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 200);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(450, 100);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "   Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(450, 200);
            this.pnl_logo.TabIndex = 0;
            // 
            // main_mro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.pnl_sidebar);
            this.Name = "main_mro";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_sidebar;
        private Guna.UI.WinForms.GunaPanel pnl_logo;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private FontAwesome.Sharp.IconButton btn_manage_records;
        private FontAwesome.Sharp.IconButton btn_medical_records;
    }
}