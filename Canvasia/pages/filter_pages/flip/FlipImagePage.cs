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

namespace Canvasia.pages.filter_pages.flip
{
    public partial class FlipImagePage : Form
    {
        public FlipImagePage()
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

            if (!isVertically.Checked && !isHorizontally.Checked) {
                MessageDisplay.ShowWarning("Please choose Horizontal Flip or Vertical Flip");
                return;
            }

            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
            }

            PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original =>
                Filters.FlipImage(original, isVertically.Checked)
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
            undoBtn.Enabled = false;
            redoBtn.Enabled = false;
            isHorizontally.Checked = false;
            isVertically.Checked = false;
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
