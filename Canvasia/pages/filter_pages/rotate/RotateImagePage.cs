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

namespace Canvasia.pages.filter_pages.rotate
{
    public partial class RotateImagePage : Form
    {
        public RotateImagePage()
        {
            InitializeComponent();
            Settings.ApplyTheme(this);

            if (Program.stack.Count > 0 && Program.index >= 0 && Program.index < Program.stack.Count)
            {
                pictureBox1.Image = Program.stack[Program.index];
            }
            else pictureBox1.Image = null;

            undoBtn.Enabled = Program.index > 0;
            redoBtn.Enabled = false;
        }
        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.LoadPhoto(pictureBox2);
            pictureBox1.Image = Program.stack.LastOrDefault();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageDisplay.ShowWarning("Please load an image before applying the filter.");
                return;
            }

            if (!rotate90Degree.Checked && !rotate180Degree.Checked && !rotate270Degree.Checked)
            {
                MessageDisplay.ShowWarning("Please select a rotation option.");
                return;
            }

            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
            }

            int rotationAngle = 0;
            if (rotate90Degree.Checked) rotationAngle = 90;
            else if (rotate180Degree.Checked) rotationAngle = 180;
            else if (rotate270Degree.Checked) rotationAngle = 270;

            PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original =>
                Filters.RotateImage(original, rotationAngle)
            );

            // Update undo/redo buttons
            redoBtn.Enabled = false;
            undoBtn.Enabled = Program.stack.Count > 1;
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.DownloadPhoto(pictureBox2);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.ClearPhoto(pictureBox1);
            PhotoManager.ClearPhoto(pictureBox2);

            rotate90Degree.Checked = false;
            rotate180Degree.Checked = false;
            rotate270Degree.Checked = false;

            undoBtn.Enabled = false;
            redoBtn.Enabled = false;
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.RedoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.UndoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }
    }
}
