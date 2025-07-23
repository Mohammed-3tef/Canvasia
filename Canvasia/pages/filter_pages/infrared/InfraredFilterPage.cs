using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia.pages.infrared
{
    public partial class InfraredFilterPage : Form
    {
        public InfraredFilterPage()
        {
            InitializeComponent();

            if (Program.imgBefore != null) pictureBox1.Image = Program.imgBefore;
            if (Program.imgAfter != null) pictureBox2.Image = Program.imgAfter;
        }

        private void LoadPhoto()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image loadedImage = Image.FromFile(openDialog.FileName);
                pictureBox1.Image = loadedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = loadedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            LoadPhoto();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            using (var temp = pictureBox2.Image)
            {
                Bitmap bmp = new Bitmap(temp);
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                Bitmap filtered = Filters.ApplyInfraredFilter(new Bitmap(bmp));
                pictureBox2.Image = filtered;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                Program.imgBefore = pictureBox1.Image;
                Program.imgAfter = pictureBox2.Image;
            }
        }
    }
}
