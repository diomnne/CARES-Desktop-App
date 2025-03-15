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

        private static Dictionary<Form, GunaButton> activeButtons = new Dictionary<Form, GunaButton>();
        private static GunaButton currentBtn;

        public static void ActivateButton(Form form, object sender, Color baseColor, Color foreColor, Color disabledBaseColor, Color disabledForeColor)
        {
            if (sender is GunaButton btn)
            {
                if (activeButtons.ContainsKey(form) && activeButtons[form] != null)
                {
                    DisableButton(activeButtons[form], disabledBaseColor, disabledForeColor);
                }

                activeButtons[form] = btn;
                btn.BaseColor = baseColor;
                btn.ForeColor = foreColor;
            }
        }

        public static void DisableButton(GunaButton btn, Color baseColor, Color foreColor)
        {
            if (btn != null)
            {
                btn.BaseColor = baseColor;
                btn.ForeColor = foreColor;
            }
        }


    }
}

