using Canvasia.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using Canvasia.src.display;

namespace Canvasia.pages.about_page
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();

            if (AppSettings.isDarkModeEnabled) AppSettings.ApplyDarkModeTheme(this);
            else AppSettings.ApplyLightModeTheme(this);
        }

        private async Task LoadAboutPage()
        {
            await this.webView.EnsureCoreWebView2Async(null);

            string htmlPath = Path.Combine(Application.StartupPath, "AboutUs.html");

            if (File.Exists(htmlPath))
            {
                this.webView.CoreWebView2.Navigate($"file:///{htmlPath.Replace("\\", "/")}");
                this.panel.BackColor = Color.White;
            }
            else MessageDisplay.ShowError("AboutUs.html not found. Please ensure the file exists in the application directory.");
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            LoadAboutPage();
        }
    }
}
