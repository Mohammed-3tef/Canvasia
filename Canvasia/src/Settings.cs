using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia.src
{
    public class Settings
    {
        public static void ApplyTheme(Control parent)
        {
            parent.BackColor = Color.FromArgb(0, 8, 20);
            parent.ForeColor = Color.FromArgb(255, 255, 255);

            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.FromArgb(0, 29, 61);
                    button.ForeColor = Color.White;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.White;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.FromArgb(0, 29, 61);
                    textBox.ForeColor = Color.White;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.BackColor = Color.FromArgb(0, 29, 61);
                    numericUpDown.ForeColor = Color.White;
                    numericUpDown.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is Panel || control is GroupBox || control is TableLayoutPanel || control is FlowLayoutPanel)
                {
                    // Recursively apply the theme to nested containers
                    ApplyTheme(control);
                }
                else
                {
                    // Optional: apply defaults to other controls
                    control.BackColor = parent.BackColor;
                    control.ForeColor = parent.ForeColor;
                }
            }
        }

    }
}
