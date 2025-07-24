using Canvasia.src.display;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia.src
{
    public class PhotoManager
    {
        public static void LoadPhoto(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image loadedImage = Image.FromFile(openDialog.FileName);
                pictureBox1.Image = loadedImage;
                pictureBox2.Image = loadedImage;
            }
        }

        public static void ClearPhoto(PictureBox pictureBox)
        {
            Program.imgBefore = null;
            Program.imgAfter = null;
            pictureBox.Image = null;

            if (pictureBox.Image != null)
            {
                Program.stack.Add(new KeyValuePair<Image, Image>(null, null));
                Program.index++;
            }
        }

        public static void DownloadPhoto(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                MessageDisplay.ShowWarning("No image to save. Please load an image first.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Image";
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                saveFileDialog.DefaultExt = "jpg";
                saveFileDialog.FileName = "SavedPhoto";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                    MessageDisplay.ShowSuccess("Image saved successfully.");
                }
            }
        }
    }
}
