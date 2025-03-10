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

            ActivateButton(btnDashboard);
            LoadChildForm(this, new Admin_Dashboard(), pnlFormContainer);
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
                currentBtn.BaseColor = Color.FromArgb(255, 247, 247); //lightblue 216, 237, 236 lightpink 255, 247, 247

                currentBtn.Radius = 7;
                currentBtn.Size = new Size(currentBtn.Width, currentBtn.Height);
            }
        }

        private void DisableButton(GunaButton btn)
        {
            if(btn != null)
            {
                btn.BaseColor = Color.Transparent;
                //btn.Radius = 7;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            LoadChildForm(this, new Admin_Dashboard(), pnlFormContainer);
        }

        private void btnLogTrail_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            LoadChildForm(this, new Admin_LogTrail(), pnlFormContainer);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            LoadChildForm(this, new Admin_ManageUsers(), pnlFormContainer);
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
