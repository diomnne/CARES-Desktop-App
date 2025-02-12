namespace CARES
{
    partial class sign_up_page
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.txt_first_name = new Guna.UI.WinForms.GunaTextBox();
            this.txt_last_name = new Guna.UI.WinForms.GunaTextBox();
            this.txt_email = new Guna.UI.WinForms.GunaTextBox();
            this.txt_password = new Guna.UI.WinForms.GunaTextBox();
            this.txt_confirm_password = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_first_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_last_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_email = new Guna.UI.WinForms.GunaLabel();
            this.lbl_password = new Guna.UI.WinForms.GunaLabel();
            this.lbl_confirm = new Guna.UI.WinForms.GunaLabel();
            this.btn_view2 = new Guna.UI.WinForms.GunaImageButton();
            this.btn_view1 = new Guna.UI.WinForms.GunaImageButton();
            this.btn_hide1 = new Guna.UI.WinForms.GunaImageButton();
            this.btn_hide2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1280, 1600);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(1280, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1280, 1600);
            this.gunaPanel2.TabIndex = 1;
            // 
            // txt_first_name
            // 
            this.txt_first_name.BaseColor = System.Drawing.Color.White;
            this.txt_first_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_first_name.BorderSize = 1;
            this.txt_first_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_first_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_first_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            this.txt_first_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_first_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.txt_first_name.Location = new System.Drawing.Point(1679, 501);
            this.txt_first_name.MaxLength = 50;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.PasswordChar = '\0';
            this.txt_first_name.Radius = 5;
            this.txt_first_name.Size = new System.Drawing.Size(500, 65);
            this.txt_first_name.TabIndex = 2;
            this.txt_first_name.TextOffsetX = 8;
            // 
            // txt_last_name
            // 
            this.txt_last_name.BaseColor = System.Drawing.Color.White;
            this.txt_last_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_last_name.BorderSize = 1;
            this.txt_last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_last_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_last_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            this.txt_last_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_last_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.txt_last_name.Location = new System.Drawing.Point(1679, 628);
            this.txt_last_name.MaxLength = 50;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.PasswordChar = '\0';
            this.txt_last_name.Radius = 5;
            this.txt_last_name.Size = new System.Drawing.Size(500, 65);
            this.txt_last_name.TabIndex = 3;
            this.txt_last_name.TextOffsetX = 8;
            this.txt_last_name.Click += new System.EventHandler(this.tb_last_name_Click);
            // 
            // txt_email
            // 
            this.txt_email.BaseColor = System.Drawing.Color.White;
            this.txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.BorderSize = 1;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            this.txt_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.txt_email.Location = new System.Drawing.Point(1679, 753);
            this.txt_email.MaxLength = 255;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.Radius = 5;
            this.txt_email.Size = new System.Drawing.Size(500, 65);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextOffsetX = 8;
            this.txt_email.Click += new System.EventHandler(this.tb_email_Click);
            // 
            // txt_password
            // 
            this.txt_password.BaseColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.BorderSize = 1;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            this.txt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.txt_password.Location = new System.Drawing.Point(1679, 880);
            this.txt_password.MaxLength = 255;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Radius = 5;
            this.txt_password.Size = new System.Drawing.Size(500, 65);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextOffsetX = 8;
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.BaseColor = System.Drawing.Color.White;
            this.txt_confirm_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirm_password.BorderSize = 1;
            this.txt_confirm_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirm_password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_confirm_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            this.txt_confirm_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_confirm_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_confirm_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.txt_confirm_password.Location = new System.Drawing.Point(1679, 1005);
            this.txt_confirm_password.MaxLength = 255;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.PasswordChar = '●';
            this.txt_confirm_password.Radius = 5;
            this.txt_confirm_password.Size = new System.Drawing.Size(500, 65);
            this.txt_confirm_password.TabIndex = 6;
            this.txt_confirm_password.TextOffsetX = 8;
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lbl_first_name.Location = new System.Drawing.Point(1682, 459);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(132, 32);
            this.lbl_first_name.TabIndex = 10;
            this.lbl_first_name.Text = "First Name";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lbl_last_name.Location = new System.Drawing.Point(1682, 585);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(130, 32);
            this.lbl_last_name.TabIndex = 11;
            this.lbl_last_name.Text = "Last Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lbl_email.Location = new System.Drawing.Point(1682, 711);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(72, 32);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lbl_password.Location = new System.Drawing.Point(1682, 838);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(214, 32);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Create a Password";
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(55)))));
            this.lbl_confirm.Location = new System.Drawing.Point(1682, 963);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(209, 32);
            this.lbl_confirm.TabIndex = 14;
            this.lbl_confirm.Text = "Confirm Password";
            // 
            // btn_view2
            // 
            this.btn_view2.Image = global::CARES.Properties.Resources.view;
            this.btn_view2.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_view2.Location = new System.Drawing.Point(2115, 1013);
            this.btn_view2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view2.Name = "btn_view2";
            this.btn_view2.OnHoverImage = global::CARES.Properties.Resources.view_hover;
            this.btn_view2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_view2.Size = new System.Drawing.Size(50, 50);
            this.btn_view2.TabIndex = 15;
            this.btn_view2.Click += new System.EventHandler(this.btn_view2_Click);
            // 
            // btn_view1
            // 
            this.btn_view1.Image = global::CARES.Properties.Resources.view;
            this.btn_view1.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_view1.Location = new System.Drawing.Point(2115, 887);
            this.btn_view1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view1.Name = "btn_view1";
            this.btn_view1.OnHoverImage = global::CARES.Properties.Resources.view_hover;
            this.btn_view1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_view1.Size = new System.Drawing.Size(50, 50);
            this.btn_view1.TabIndex = 8;
            this.btn_view1.Click += new System.EventHandler(this.btn_view1_password_Click);
            // 
            // btn_hide1
            // 
            this.btn_hide1.Image = global::CARES.Properties.Resources.hide;
            this.btn_hide1.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_hide1.Location = new System.Drawing.Point(2115, 887);
            this.btn_hide1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hide1.Name = "btn_hide1";
            this.btn_hide1.OnHoverImage = global::CARES.Properties.Resources.hide_hover;
            this.btn_hide1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_hide1.Size = new System.Drawing.Size(50, 50);
            this.btn_hide1.TabIndex = 9;
            this.btn_hide1.Click += new System.EventHandler(this.btn_hide1_Click);
            // 
            // btn_hide2
            // 
            this.btn_hide2.Image = global::CARES.Properties.Resources.hide;
            this.btn_hide2.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_hide2.Location = new System.Drawing.Point(2115, 1013);
            this.btn_hide2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hide2.Name = "btn_hide2";
            this.btn_hide2.OnHoverImage = global::CARES.Properties.Resources.hide_hover;
            this.btn_hide2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_hide2.Size = new System.Drawing.Size(50, 50);
            this.btn_hide2.TabIndex = 16;
            this.btn_hide2.Click += new System.EventHandler(this.btn_hide2_Click);
            // 
            // sign_up_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.btn_view2);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.btn_view1);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btn_hide1);
            this.Controls.Add(this.btn_hide2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sign_up_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox txt_first_name;
        private Guna.UI.WinForms.GunaTextBox txt_last_name;
        private Guna.UI.WinForms.GunaTextBox txt_email;
        private Guna.UI.WinForms.GunaTextBox txt_password;
        private Guna.UI.WinForms.GunaTextBox txt_confirm_password;
        private Guna.UI.WinForms.GunaImageButton btn_view1;
        private Guna.UI.WinForms.GunaImageButton btn_hide1;
        private Guna.UI.WinForms.GunaLabel lbl_first_name;
        private Guna.UI.WinForms.GunaLabel lbl_last_name;
        private Guna.UI.WinForms.GunaLabel lbl_email;
        private Guna.UI.WinForms.GunaLabel lbl_password;
        private Guna.UI.WinForms.GunaLabel lbl_confirm;
        private Guna.UI.WinForms.GunaImageButton btn_hide2;
        private Guna.UI.WinForms.GunaImageButton btn_view2;
    }
}

