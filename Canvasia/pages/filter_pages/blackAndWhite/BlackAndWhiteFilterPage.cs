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

namespace Canvasia.pages.filter_pages.blackAndWhite
{
    public partial class BlackAndWhiteFilterPage : Form
    {
        public BlackAndWhiteFilterPage()
        {
            InitializeComponent();

            if (Program.imgBefore != null) pictureBox1.Image = Program.imgBefore;
            if (Program.imgAfter != null) pictureBox2.Image = Program.imgAfter;
            if (Program.index == 0)
            {
                undoBtn.BackColor = Color.Gray;
                undoBtn.Enabled = false;
            }
            redoBtn.BackColor = Color.Gray;
            redoBtn.Enabled = false;
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
                Bitmap filtered = Filters.ApplyBlackAndWhiteFilter(new Bitmap(bmp));
                pictureBox2.Image = filtered;
                Program.imgBefore = pictureBox1.Image;
                Program.imgAfter = pictureBox2.Image;

                if (Program.index == 0)
                {
                    Program.stack.Add(new KeyValuePair<Image, Image>(null, null));
                    Program.index++;
                    Program.stack.Add(new KeyValuePair<Image, Image>((Image)Program.imgBefore.Clone(), (Image)Program.imgBefore.Clone()));
                    Program.index++;
                }
                Program.stack.Add(
                                new KeyValuePair<Image, Image>(
                                    (Image)Program.imgBefore.Clone(),
                                    (Image)Program.imgAfter.Clone()
                                )
                            );
                Program.index = Program.stack.Count - 1;
                Program.index++;
                redoBtn.BackColor = Color.Gray;
                redoBtn.Enabled = false;
                undoBtn.BackColor = downloadBtn.BackColor;
                undoBtn.Enabled = true;
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

        private void redoBtn_Click(object sender, EventArgs e)
        {
            // we can only redo if there's a next item
            if (Program.index < Program.stack.Count - 1)
            {
                undoBtn.BackColor = downloadBtn.BackColor;
                undoBtn.Enabled = true;

                Program.index++; // move one step forward
                pictureBox1.Image = Program.stack[Program.index].Key;
                pictureBox2.Image = Program.stack[Program.index].Value;
            }
            if (Program.index == Program.stack.Count - 1)
            {
                // Already at the latest step
                redoBtn.BackColor = Color.Gray;
                redoBtn.Enabled = false;
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (Program.index > 0)
            {
                // Already at the latest step
                redoBtn.BackColor = downloadBtn.BackColor;
                redoBtn.Enabled = true;
                Program.index--; // move one step back
                pictureBox1.Image = Program.stack[Program.index].Key;
                pictureBox2.Image = Program.stack[Program.index].Value;
            }
            if (Program.index == 0)
            {
                // Already at the oldest step
                undoBtn.BackColor = Color.Gray;
                undoBtn.Enabled = false;
            }
        }
    }
}
