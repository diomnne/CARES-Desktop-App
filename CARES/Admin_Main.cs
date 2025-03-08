using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CARES.FormMethods;

namespace CARES
{
    public partial class Admin_Main : Form
    {
        private GunaButton currentBtn;
        private GunaPanel leftBorderBtn;
        
        public Admin_Main()
        {
            InitializeComponent();

            leftBorderBtn = new GunaPanel();
            leftBorderBtn.BackColor = Color.FromArgb(0, 157, 162);
            pnlNavbar.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentBtn != null)
                {
                    DisableButton(currentBtn);
                }

                currentBtn = (GunaButton)sender;
                currentBtn.BackColor = Color.FromArgb(216, 237, 236);
                currentBtn.TextAlign = HorizontalAlignment.Center;
                currentBtn.ImageAlign = HorizontalAlignment.Right;
                currentBtn.Font = new Font(currentBtn.Font.FontFamily, currentBtn.Font.Size, FontStyle.Bold);

                leftBorderBtn.Size = new Size(8, currentBtn.Height);

                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton(GunaButton btn)
        {
            if(btn != null)
            {
                btn.BackColor = Color.Transparent;
                btn.TextAlign = HorizontalAlignment.Left;
                btn.ImageAlign = HorizontalAlignment.Left;
                currentBtn.Font = new Font(currentBtn.Font.FontFamily, currentBtn.Font.Size, FontStyle.Regular);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLogTrail_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            LoadChildForm(this, new Admin_LogTrail(), pnlFormContainer);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
