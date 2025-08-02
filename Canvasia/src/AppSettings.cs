using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Canvasia.src
{
    public static class AppSettings
    {
        public static bool isDarkModeEnabled = true;

        public static void DarkMainWindow(MainWindow mainWindow, Panel panel)
        {
            mainWindow.BackColor = Color.FromArgb(0, 8, 20);

            foreach (Control control in mainWindow.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(0, 29, 61);
                    button.ForeColor = Color.White;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.White;
                }
                else if (control is Panel || control is GroupBox || control is TableLayoutPanel || control is FlowLayoutPanel)
                {
                    control.BackColor = Color.FromArgb(0, 29, 61);
                }
            }

            foreach (Control control in panel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(0, 29, 61);
                    button.ForeColor = Color.White;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.White;
                }
            }
        }

        public static void LightMainWindow(MainWindow mainWindow, Panel panel)
        {
            mainWindow.BackColor = SystemColors.Control;
            mainWindow.ForeColor = Color.Black;

            foreach (Control control in mainWindow.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.Black;
                }
                else if (control is Panel || control is GroupBox || control is TableLayoutPanel || control is FlowLayoutPanel)
                {
                    control.BackColor = SystemColors.ControlLight;
                }
            }

            foreach (Control control in panel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SystemColors.ControlLight;
                    button.ForeColor = Color.Black;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }

        public static void ApplyDarkModeTheme(Control parent)
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
                    ApplyDarkModeTheme(control);
                }
                else
                {
                    // Optional: apply defaults to other controls
                    control.BackColor = parent.BackColor;
                    control.ForeColor = parent.ForeColor;
                }
            }
        }

        public static void ApplyLightModeTheme(Control parent)
        {
            parent.BackColor = SystemColors.Control;
            parent.ForeColor = Color.Black;

            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderSize = 1;
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.Black;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.Black;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.Black;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.BackColor = Color.White;
                    numericUpDown.ForeColor = Color.Black;
                }
                else if (control is Panel || control is GroupBox || control is TableLayoutPanel || control is FlowLayoutPanel)
                {
                    // Recursively apply the theme to nested containers
                    ApplyLightModeTheme(control);
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
