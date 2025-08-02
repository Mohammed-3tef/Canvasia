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

namespace Canvasia.pages.lightenDarken
{
    public partial class LightenDarkenFilterPage : Form
    {
        public LightenDarkenFilterPage()
        {
            InitializeComponent();

            if (AppSettings.isDarkModeEnabled) AppSettings.ApplyDarkModeTheme(this);
            else AppSettings.ApplyLightModeTheme(this);

            if (Program.stack.Count > 0 && Program.index >= 0 && Program.index < Program.stack.Count)
            {
                pictureBox1.Image = Program.stack[Program.index];
            }
            else pictureBox1.Image = null;

            if (Program.index == 0) undoBtn.Enabled = false;
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

            if (trackBar1.Value == 50)
            {
                MessageDisplay.ShowWarning("Please select a level greater than 0.");
                return;
            }

            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
            }

            if (trackBar1.Value > 50)
                PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original =>
                    Filters.ApplyLightenFilter(original, (int)trackBar1.Value)
                );
            else 
                PhotoManager.ApplyFilter(pictureBox1, pictureBox2, original => 
                    Filters.ApplyDarkenFilter(original, (int)trackBar1.Value)
                );

            // Update undo/redo buttons
            redoBtn.Enabled = false;
            undoBtn.Enabled = Program.stack.Count > 1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.ClearPhoto(pictureBox1);
            PhotoManager.ClearPhoto(pictureBox2);
            undoBtn.Enabled = false;
            redoBtn.Enabled = false;

            trackBar1.Value = 50;
            levelLabel.Text = "0%";
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.DownloadPhoto(pictureBox2);
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.RedoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.UndoPhoto(pictureBox1, pictureBox2, undoBtn, redoBtn);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.levelLabel.Text = $"{(trackBar1.Value - 50).ToString()}%";
        }
    }
}
