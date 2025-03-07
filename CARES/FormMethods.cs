using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            /*childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.Show();*/

            containerPanel.Controls.Clear(); // Remove any existing child forms
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Ensure it fills the panel
            containerPanel.Controls.Add(childForm);
            childForm.Show();
        }
    }
}

