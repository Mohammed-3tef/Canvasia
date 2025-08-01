using Canvasia.pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia
{
    internal static class Program
    {
        public static List<Image> stack = new List<Image>();
        public static int index = 0;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware(); // Ensure DPI awareness for high DPI displays

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadingPage loadingPage = new LoadingPage();
            loadingPage.ShowDialog();

            Application.Run(new MainWindow());
        }
    }
}
