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
            this.lblLogTrail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogTrail
            // 
            this.lblLogTrail.AutoSize = true;
            this.lblLogTrail.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTrail.Location = new System.Drawing.Point(70, 60);
            this.lblLogTrail.Name = "lblLogTrail";
            this.lblLogTrail.Size = new System.Drawing.Size(189, 49);
            this.lblLogTrail.TabIndex = 1;
            this.lblLogTrail.Text = "Log Trail";
            // 
            // Admin_LogTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2054, 1464);
            this.Controls.Add(this.lblLogTrail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_LogTrail";
            this.Text = "Admin_LogTrail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogTrail;
    }
}