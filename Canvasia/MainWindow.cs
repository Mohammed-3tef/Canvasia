using Canvasia.pages.about_page;
using Canvasia.pages.detectEdges;
using Canvasia.pages.filter_pages.addFrame;
using Canvasia.pages.filter_pages.blackAndWhite;
using Canvasia.pages.filter_pages.blur;
using Canvasia.pages.filter_pages.crop;
using Canvasia.pages.filter_pages.flip;
using Canvasia.pages.filter_pages.grayscale;
using Canvasia.pages.filter_pages.merge;
using Canvasia.pages.filter_pages.resize;
using Canvasia.pages.filter_pages.rotate;
using Canvasia.pages.filter_pages.skew;
using Canvasia.pages.infrared;
using Canvasia.pages.invert;
using Canvasia.pages.lightenDarken;
using Canvasia.pages.purple;
using Canvasia.pages.sunlight;
using Canvasia.src;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosing += this.formClosing;

            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button btn)
                {
                    if (AppSettings.isDarkModeEnabled) btn.BackColor = Color.FromArgb(0, 29, 61);
                    else btn.BackColor = SystemColors.ControlLight;
                }
            }
        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ask for confirmation before closing
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit?", "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No) e.Cancel = true; // Cancel the close event
                else Application.Exit(); // Kill the entire application
            }
        }

        private void OpenForm(Form form)
        {
            // close any form that is currently open in the panel
            if (this.panel2.Controls.Count > 0)
            {
                Form currentForm = this.panel2.Controls[0] as Form;
                if (currentForm != null) currentForm.Close();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void HighlightActiveButton(Button activeButton)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button btn)
                {
                    if (AppSettings.isDarkModeEnabled) btn.BackColor = Color.FromArgb(0, 29, 61);
                    else btn.BackColor = SystemColors.ControlLight;
                }
            }

            if (AppSettings.isDarkModeEnabled) activeButton.BackColor = Color.FromArgb(51, 65, 92); // Set active
            else activeButton.BackColor = SystemColors.Control;

            AppSettings.inAboutPage = false;
        }

        private void infraredBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new InfraredFilterPage());
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new InvertImagePage());
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new PurpleFilterPage());
        }

        private void sunlightBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new SunlightFilterPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new LightenDarkenFilterPage());
        }

        private void detectEdgesBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new DetectEdgesFilterPage());
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button btn)
                {
                    if (AppSettings.isDarkModeEnabled) btn.BackColor = Color.FromArgb(0, 29, 61);
                    else btn.BackColor = SystemColors.ControlLight;
                }
            }

            OpenForm(new AboutPage());
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new GrayscaleFilterPage());
        }

        private void blackAndWhiteBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new BlackAndWhiteFilterPage());
        }

        private void blurBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new BlurFilterPage());
        }

        private void flipBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new FlipImagePage());
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new RotateImagePage());
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new CropImagePage());
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new ResizeImagePage());
        }

        private void addingFrameBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new AddFrameFilterPage());
        }

        private void skewBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new SkewFilterPage());
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            OpenForm(new MergeFilterPage());
        }

        private void darkModeBtn_Click(object sender, EventArgs e)
        {
            AppSettings.isDarkModeEnabled = !AppSettings.isDarkModeEnabled;

            if (AppSettings.isDarkModeEnabled)
            {
                AppSettings.DarkMainWindow(this, this.panel1);
                if (this.panel2.Controls.Count > 0)
                    AppSettings.ApplyDarkModeTheme(this.panel2.Controls[0]);
                panel2.BackColor = Color.Transparent;

                darkModeBtn.BackgroundImage = Properties.Resources.light;
                aboutBtn.BackgroundImage = Properties.Resources.light_about;
            }
            else
            {
                AppSettings.LightMainWindow(this, this.panel1);
                if (this.panel2.Controls.Count > 0)
                    AppSettings.ApplyLightModeTheme(this.panel2.Controls[0]);
                panel2.BackColor = Color.Transparent;

                darkModeBtn.BackgroundImage = Properties.Resources.dark;
                aboutBtn.BackgroundImage = Properties.Resources.dark_about;
            }

            if (AppSettings.inAboutPage) OpenForm(new AboutPage());
        }
    }
}
