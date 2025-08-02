using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canvasia.src;
using Canvasia.src.display;

namespace Canvasia.pages.filter_pages.addFrame
{
    public partial class AddFrameFilterPage : Form
    {
        private int frameWidthOuter = 0;
        private Color frameColorOuter = Color.Black;
        private int frameWidthInner = 0;
        private Color frameColorInner = Color.White;

        public AddFrameFilterPage()
        {
            InitializeComponent();

            if (AppSettings.isDarkModeEnabled) AppSettings.ApplyDarkModeTheme(this);
            else AppSettings.ApplyLightModeTheme(this);

            if (Program.stack.Count > 0 && Program.index >= 0 && Program.index < Program.stack.Count)
            {
                pictureBox1.Image = Program.stack[Program.index];
            }
            else pictureBox1.Image = null;

            chooseColorInnerBtn.BackColor = frameColorInner;
            chooseColorOuterBtn.BackColor = frameColorOuter;

            if (Program.index == 0) undoBtn.Enabled = false;
            redoBtn.Enabled = false;
        }

        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.LoadPhoto(pictureBox2);
            pictureBox1.Image = Program.stack.LastOrDefault();
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageDisplay.ShowWarning("Please load an image before applying the filter.");
                return;
            }

            if (addWidthOuter.Value <= 0)
            {
                MessageDisplay.ShowWarning("Please enter a valid width to add.");
                addWidthOuter.Focus();
                return;
            }

            frameWidthOuter = (int)addWidthOuter.Value;
            frameWidthInner = (int)addWidthInner.Value; 

            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
            }

            PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original =>
                Filters.AddFrame(original, frameWidthOuter, frameColorOuter, frameWidthInner, frameColorInner)
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

            addWidthOuter.Value = 0;
            addWidthInner.Value = 0;

            frameColorOuter = Color.Black;
            frameColorInner = Color.White;
            chooseColorOuterBtn.BackColor = frameColorOuter;
            chooseColorInnerBtn.BackColor = frameColorInner;
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.RedoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.UndoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }

        private void chooseColorOuterBtn_Click(object sender, EventArgs e)
        {
            // colorDialog1 is the one you dropped from Toolbox
            colorOuter.Color = frameColorOuter; // start with current color

            if (colorOuter.ShowDialog() == DialogResult.OK)
            {
                frameColorOuter = colorOuter.Color;            // store chosen color
                chooseColorOuterBtn.BackColor = frameColorOuter;      // optional feedback
            }
        }

        private void chooseColorInnerBtn_Click(object sender, EventArgs e)
        {
            // colorDialog1 is the one you dropped from Toolbox
            colorInner.Color = frameColorInner; // start with current color

            if (colorInner.ShowDialog() == DialogResult.OK)
            {
                frameColorInner = colorInner.Color;            // store chosen color
                chooseColorInnerBtn.BackColor = frameColorInner;      // optional feedback
            }
        }
    }
}
