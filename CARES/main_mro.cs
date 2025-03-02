using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using FontAwesome.Sharp;

namespace CARES
{
    public partial class main_mro : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public main_mro()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 100);
            pnl_sidebar.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color off_white = Color.FromArgb(235, 235, 235);
            public static Color teal = Color.FromArgb(0, 157, 162);
            public static Color teal_hover = Color.FromArgb(2, 190, 196);
            public static Color light_blue = Color.FromArgb(202, 234, 235);
            public static Color light_pink = Color.FromArgb(255, 235, 234);
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.light_blue;
                currentBtn.ForeColor = RGBColors.teal;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = RGBColors.teal;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = RGBColors.teal;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.off_white;
                currentBtn.ForeColor = RGBColors.teal;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.teal;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.teal);
        }

        private void btn_medical_records_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.teal);
        }

        private void btn_manage_records_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.teal);
        }
    }
}
