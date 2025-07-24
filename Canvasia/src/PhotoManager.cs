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
        public static void LoadPhoto()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image loadedImage = Image.FromFile(openDialog.FileName);
                Program.stack.Add(loadedImage);
            }
        }

        public static void ApplyFilter(PictureBox pictureBox1, PictureBox pictureBox2, Func<Bitmap, Bitmap> filterFunction)
        {
            if (pictureBox1.Image == null) return;

            using (var temp = new Bitmap(pictureBox1.Image))
            {
                Bitmap filtered = filterFunction(temp);
                pictureBox2.Image = filtered;

                // مسح التعديلات المستقبلية إذا رجعنا بالتاريخ وعدّلنا
                if (Program.index < Program.stack.Count - 1)
                {
                    Program.stack.RemoveRange(Program.index + 1, Program.stack.Count - Program.index - 1);
                }

                // إضافة الحالة الجديدة إلى سجل التعديلات
                Program.stack.Add(filtered);
                Program.index = Program.stack.Count - 1;
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

        public static void UndoPhoto(PictureBox pictureBox1, PictureBox pictureBox2, Button undoBtn, Button redoBtn)
        {
            if (Program.index <= 0 || Program.stack.Count == 0) return;

            Program.index--;

            // استرجاع الصور من الستاك مع الحماية
            if (Program.index >= 0 && Program.index < Program.stack.Count)
            {
                var keyImg = Program.stack[Program.index];

                pictureBox1.Image = keyImg != null ? new Bitmap(keyImg) : null;
                pictureBox2.Image = null;
            }

            undoBtn.Enabled = Program.index > 0;
            redoBtn.Enabled = Program.index < Program.stack.Count - 1;
        }

        public static void RedoPhoto(PictureBox pictureBox1, PictureBox pictureBox2, Button undoBtn, Button redoBtn)
        {
            if (Program.index >= Program.stack.Count - 1) return;

            Program.index++;

            // استرجاع الصور من الستاك مع الحماية
            if (Program.index >= 0 && Program.index < Program.stack.Count)
            {
                var keyImg = Program.stack[Program.index];

                pictureBox1.Image = keyImg != null ? new Bitmap(keyImg) : null;
                pictureBox2.Image = null;
            }

            undoBtn.Enabled = Program.index > 0;
            redoBtn.Enabled = Program.index < Program.stack.Count - 1;
        }

        public static void ClearPhoto(PictureBox pictureBox)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = null;
            Program.stack.Clear();
            Program.index = 0;
        }
    }
}
