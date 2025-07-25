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

namespace Canvasia.pages.filter_pages.merge
{
    public partial class MergeFilterPage : Form
    {
        public MergeFilterPage()
        {
            InitializeComponent();

            //if (Program.stack.Count > 0 && Program.index >= 0 && Program.index < Program.stack.Count)
            //{
            //    pictureBox2.Image = Program.stack[Program.index];
            //}
            //else pictureBox2.Image = null;

            undoBtn.Enabled = Program.index > 0;
            redoBtn.Enabled = false;
        }

        private void loadPhotoBtn_Click(object sender, EventArgs e)
        {
            PhotoManager.LoadPhoto(pictureBox3);
            pictureBox2.Image = Program.stack.LastOrDefault();

            PhotoManager.LoadPhoto(pictureBox3);
            pictureBox1.Image = Program.stack.LastOrDefault();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {

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

            undoBtn.Enabled = false;
            redoBtn.Enabled = false;
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {

        }

        private void undoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
