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

namespace Canvasia.pages.filter_pages.resize
{
    public partial class ResizeImagePage : Form
    {
        public ResizeImagePage()
        {
            InitializeComponent();

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

            if (addWidth.Value <= 0)
            {
                MessageDisplay.ShowWarning("Please enter a valid width to add.");
                addWidth.Focus();
                return;
            }

            if (addHeight.Value <= 0)
            {
                MessageDisplay.ShowWarning("Please enter a valid height to add.");
                addHeight.Focus();
                return;
            }

            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
            }

            PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original =>
                Filters.ResizeImage(original, (int)addWidth.Value, (int)addHeight.Value)
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

            addWidth.Value = 0;
            addHeight.Value = 0;

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
