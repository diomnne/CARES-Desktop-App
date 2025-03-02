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
            this.pnl_navbar = new Guna.UI.WinForms.GunaPanel();
            this.pnl_logo = new Guna.UI.WinForms.GunaPanel();
            this.pnl_header = new Guna.UI.WinForms.GunaPanel();
            this.pnl_form_container = new Guna.UI.WinForms.GunaPanel();
            this.btn_manage_records = new FontAwesome.Sharp.IconButton();
            this.btn_medical_records = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.pnl_navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_navbar
            // 
            this.pnl_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnl_navbar.Controls.Add(this.btn_manage_records);
            this.pnl_navbar.Controls.Add(this.btn_medical_records);
            this.pnl_navbar.Controls.Add(this.btn_dashboard);
            this.pnl_navbar.Controls.Add(this.pnl_logo);
            this.pnl_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_navbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_navbar.Name = "pnl_navbar";
            this.pnl_navbar.Size = new System.Drawing.Size(480, 1529);
            this.pnl_navbar.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(480, 150);
            this.pnl_logo.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(480, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(2054, 150);
            this.pnl_header.TabIndex = 1;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            // 
            // pnl_form_container
            // 
            this.pnl_form_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnl_form_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form_container.Location = new System.Drawing.Point(480, 150);
            this.pnl_form_container.Name = "pnl_form_container";
            this.pnl_form_container.Size = new System.Drawing.Size(2054, 1379);
            this.pnl_form_container.TabIndex = 3;
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
            this.btn_manage_records.Location = new System.Drawing.Point(0, 410);
            this.btn_manage_records.Name = "btn_manage_records";
            this.btn_manage_records.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_manage_records.Size = new System.Drawing.Size(480, 130);
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
            this.btn_medical_records.Location = new System.Drawing.Point(0, 280);
            this.btn_medical_records.Name = "btn_medical_records";
            this.btn_medical_records.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_medical_records.Size = new System.Drawing.Size(480, 130);
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
            this.btn_dashboard.Location = new System.Drawing.Point(0, 150);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(480, 130);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "   Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // main_mro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.pnl_form_container);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_navbar);
            this.Name = "main_mro";
            this.Text = "Main";
            this.pnl_navbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_navbar;
        private Guna.UI.WinForms.GunaPanel pnl_logo;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private FontAwesome.Sharp.IconButton btn_manage_records;
        private FontAwesome.Sharp.IconButton btn_medical_records;
        private Guna.UI.WinForms.GunaPanel pnl_header;
        private Guna.UI.WinForms.GunaPanel pnl_form_container;
    }
}