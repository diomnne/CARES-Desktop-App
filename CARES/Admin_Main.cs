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
        public static Color activeBtnColor = Color.FromArgb(255, 247, 247);

        public Admin_Main()
        {
            InitializeComponent();

            ActivateButton(btnDashboard, activeBtnColor);
            LoadChildForm(this, new Admin_Dashboard(), pnlFormContainer);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
            LoadChildForm(this, new Admin_Dashboard(), pnlFormContainer);
        }

        private void btnLogTrail_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
            LoadChildForm(this, new Admin_LogTrail(), pnlFormContainer);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
            LoadChildForm(this, new Admin_ManageUsers(), pnlFormContainer);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, activeBtnColor);
        }

    }
}
