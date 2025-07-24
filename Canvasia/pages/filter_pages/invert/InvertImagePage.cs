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

namespace Canvasia.pages.invert
{
    public partial class InvertImagePage : Form
    {
        public InvertImagePage()
        {
            InitializeComponent();

            if (Program.imgBefore != null) pictureBox1.Image = Program.imgBefore;
            if (Program.imgAfter != null) pictureBox2.Image = Program.imgAfter;
        }

        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.LoadPhoto(pictureBox1, pictureBox2);
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageDisplay.ShowWarning("Please load an image before applying the filter.");
                return;
            }

            using (var temp = pictureBox2.Image)
            {
                Bitmap bmp = new Bitmap(temp);
                pictureBox1.Image = bmp;
                Bitmap filtered = Filters.InvertImage(new Bitmap(bmp));
                pictureBox2.Image = filtered;

                Program.imgBefore = pictureBox1.Image;
                Program.imgAfter = pictureBox2.Image;
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.DownloadPhoto(pictureBox2);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.ClearPhoto(pictureBox1);
            PhotoManager.ClearPhoto(pictureBox2);
        }
    }
}
