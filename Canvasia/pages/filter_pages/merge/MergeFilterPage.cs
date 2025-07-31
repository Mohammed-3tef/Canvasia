using Canvasia.src;
using Canvasia.src.display;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Canvasia.pages.filter_pages.merge
{
    public partial class MergeFilterPage : Form
    {
        public MergeFilterPage()
        {
            InitializeComponent();
            Settings.ApplyTheme(this);

            if (Program.stack.Count > 1 && Program.index >= 1 && Program.index < Program.stack.Count)
            {
                pictureBox1.Image = Program.stack[Program.index];
                pictureBox2.Image = Program.stack[Program.index - 1];
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
        }

        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.LoadPhoto(pictureBox3);
            pictureBox1.Image = Program.stack.LastOrDefault();

            PhotoManager.LoadPhoto(pictureBox3);
            pictureBox2.Image = Program.stack.LastOrDefault();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageDisplay.ShowWarning("Please load an image before applying the filter.");
                return;
            }

            PhotoManager.ApplyFilter(pictureBox1, pictureBox3, original =>
                Filters.mergeImages(original, (Bitmap)pictureBox2.Image)
            );
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.DownloadPhoto(pictureBox3);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.ClearPhoto(pictureBox2);
            PhotoManager.ClearPhoto(pictureBox1);
            PhotoManager.ClearPhoto(pictureBox3);
        }
    }
}
