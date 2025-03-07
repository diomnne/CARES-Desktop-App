namespace CARES
{
    partial class Admin_LogTrail
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
            this.dtgLogTrail = new Guna.UI.WinForms.GunaDataGridView();
            this.logID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogTrail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLogTrail
            // 
            this.dtgLogTrail.AllowUserToAddRows = false;
            this.dtgLogTrail.AllowUserToDeleteRows = false;
            this.dtgLogTrail.AllowUserToResizeColumns = false;
            this.dtgLogTrail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dtgLogTrail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLogTrail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLogTrail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgLogTrail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgLogTrail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLogTrail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLogTrail.ColumnHeadersHeight = 70;
            this.dtgLogTrail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logID,
            this.accountID,
            this.action,
            this.description,
            this.timeStamp});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLogTrail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLogTrail.EnableHeadersVisualStyles = false;
            this.dtgLogTrail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dtgLogTrail.Location = new System.Drawing.Point(142, 260);
            this.dtgLogTrail.Name = "dtgLogTrail";
            this.dtgLogTrail.ReadOnly = true;
            this.dtgLogTrail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgLogTrail.RowHeadersVisible = false;
            this.dtgLogTrail.RowHeadersWidth = 82;
            this.dtgLogTrail.RowTemplate.Height = 33;
            this.dtgLogTrail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgLogTrail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLogTrail.Size = new System.Drawing.Size(1776, 448);
            this.dtgLogTrail.TabIndex = 0;
            this.dtgLogTrail.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dtgLogTrail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dtgLogTrail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgLogTrail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgLogTrail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgLogTrail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgLogTrail.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtgLogTrail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dtgLogTrail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dtgLogTrail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgLogTrail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.dtgLogTrail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgLogTrail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgLogTrail.ThemeStyle.HeaderStyle.Height = 70;
            this.dtgLogTrail.ThemeStyle.ReadOnly = true;
            this.dtgLogTrail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dtgLogTrail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgLogTrail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgLogTrail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgLogTrail.ThemeStyle.RowsStyle.Height = 33;
            this.dtgLogTrail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dtgLogTrail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // logID
            // 
            this.logID.HeaderText = "Log ID";
            this.logID.MinimumWidth = 10;
            this.logID.Name = "logID";
            this.logID.ReadOnly = true;
            // 
            // accountID
            // 
            this.accountID.HeaderText = "Account ID";
            this.accountID.MinimumWidth = 10;
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.MinimumWidth = 10;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 10;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // timeStamp
            // 
            this.timeStamp.HeaderText = "Time Stamp";
            this.timeStamp.MinimumWidth = 10;
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.ReadOnly = true;
            // 
            // Admin_LogTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(2054, 1314);
            this.Controls.Add(this.dtgLogTrail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_LogTrail";
            this.Text = "Admin_LogTrail";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogTrail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dtgLogTrail;
        private System.Windows.Forms.DataGridViewTextBoxColumn logID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStamp;
    }
}