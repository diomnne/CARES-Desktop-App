using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CARES
{
    public static class FormMethods
    {
        public static void LoadChildForm(Form parentForm, Form childForm, Panel containerPanel)
        {
            foreach (Control ctrl in containerPanel.Controls)
            {
                if (ctrl is Form form)
                {
                    form.Close();
                    break;
                }
            }

            containerPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; 
            containerPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private static GunaButton currentBtn;

        public static void ActivateButton(object sender, Color activeColor)
        {
            if (sender is GunaButton btn)
            {
                if (currentBtn != null)
                {
                    DisableButton(currentBtn);
                }

                currentBtn = btn;
                currentBtn.BaseColor = activeColor; 
                currentBtn.Size = new Size(currentBtn.Width, currentBtn.Height);
            }
        }

        public static void DisableButton(GunaButton btn)
        {
            if (btn != null)
            {
                btn.BaseColor = Color.Transparent;
            }
        }

    }
}

