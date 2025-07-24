using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Canvasia
{
    internal static class Program
    {
        internal static Image imgBefore = null;
        internal static Image imgAfter = null;

        public static List<KeyValuePair<Image, Image>> stack = new List<KeyValuePair<Image, Image>>();
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
            Application.Run(new MainWindow());
        }
    }
}
