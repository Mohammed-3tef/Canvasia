using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvasia
{
    internal class Image_Class
    {
        /**
         * @brief Checks if the given filename has a valid extension.
         *
         * @param filename The filename to check.
         * @return True if the filename has a valid extension, false otherwise.
         */
        private bool IsValidFilename(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Invalid filename: (empty)",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return false;
            }

            int dotIndex = filename.LastIndexOf('.');

            if (dotIndex <= 0 || dotIndex == filename.Length - 1)
            {
                MessageBox.Show("Invalid filename: " + filename,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /**
         * @brief Determines the image type based on the file extension.
         *
         * @param extension The file extension to determine the type.
         * @return The type of image format.
         */

        private string GetExtensionType(string extension)
        {
            // Normalize the extension (lowercase for safe comparison)
            extension = extension.ToLower();

            if (extension == ".png")
            {
                return "PNG_TYPE";
            }
            if (extension == ".bmp")
            {
                return "BMP_TYPE";
            }
            if (extension == ".tga")
            {
                return "TGA_TYPE";
            }
            if (extension == ".jpg" || extension == ".jpeg")
            {
                return "JPG_TYPE";
            }

            // Show error message in GUI
            MessageBox.Show("Unsupported image format: " + extension,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            return "UNSUPPORTED_TYPE";
        }

        private string filename;        // Stores the filename of the image.
        public int width = 0;           // Width of the image.
        public int height = 0;          // Height of the image.
        public int channels = 3;        // Number of color channels in the image.
        public byte[] imageData = null; // Pointer to the image data.

        /**
         * @brief Default constructor for the Image class.
         */
        public Image_Class() {}

        /**
         * @brief Constructor that loads an image from the specified filename.
         *
         * @param filename The filename of the image to load.
         */
        public Image_Class(string filename)
        {
            this.filename = filename;
            LoadNewImage(this.filename);
        }

        /**
         * @brief Constructor that creates an image with the specified dimensions.
         *
         * @param mWidth The width of the image.
         * @param mHeight The height of the image.
         */
        public Image_Class(int mWidth, int mHeight)
        {
            this.width = mWidth;
            this.height = mHeight;

            // Allocate managed byte array
            this.imageData = new byte[mWidth * mHeight * this.channels];
        }

        /**
         * @brief Constructor that creates an image by copying another image.
         *
         * @param other The Image we want to copy.
         */
        public Image_Class(Image_Class other)
        {
            this.width = other.width;
            this.height = other.height;
            this.channels = other.channels;
            this.imageData = (byte[])other.imageData.Clone();
        }

        /**
         * @brief Overloading the assignment operator.
         *
         * @param image The Image we want to copy.
         *
         * @return *this after copying data.
         */

        public Image_Class Assign(Image_Class image)
        {
            if (this == image)
            {
                return this;
            }

            this.imageData = null;

            this.width = image.width;
            this.height = image.height;
            this.channels = image.channels;
            this.imageData = new byte[width * height * channels];

            for (int i = 0; i < image.width * image.height * this.channels; i++)
            {
                this.imageData[i] = image.imageData[i];
            }

            return this;
        }

        /**
         * @brief Destructor for the Image class.
         */
        ~Image_Class()
        {
            if (imageData != null)
            {
                imageData = null;
            }
            this.width = 0;
            this.height = 0;
            this.imageData = null;
        }

        /**
         * @brief Loads a new image from the specified filename.
         *
         * @param filename The filename of the image to load.
         * @return True if the image is loaded successfully, false otherwise.
         * @throws std::invalid_argument If the filename or file format is invalid.
         */
        public bool LoadNewImage(string filename)
        {
            if (!IsValidFilename(filename))
            {
                MessageBox.Show("Couldn't Load Image",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentException("The file extension does not exist");
            }

            string extension = Path.GetExtension(filename);
            string extensionType = GetExtensionType(extension);
            if (extensionType == "UNSUPPORTED_TYPE")
            {
                MessageBox.Show("Unsupported File Format",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentException("File Extension is not supported, Only .JPG, .JPEG, .BMP, .PNG, .TGA are supported");
            }

            if (imageData != null)
            {
                imageData = null;
            }

            if (!File.Exists(filename))
            {
                MessageBox.Show("File Doesn't Exist",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentException("Invalid filename, File Does not Exist");
            }

            imageData = File.ReadAllBytes(filename);
            return true;
        }

        /**
         * @brief Saves the image to the specified output filename.
         *
         * @param outputFilename The filename to save the image.
         * @return True if the image is saved successfully, false otherwise.
         * @throws std::invalid_argument If the output filename or file format is invalid.
         */
        public bool SaveImage(string outputFilename)
        {
            if (!IsValidFilename(outputFilename))
            {
                MessageBox.Show("Not Supported Format",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentException("The file extension does not exist");
            }

            string extension = Path.GetExtension(outputFilename);
            string extensionType = GetExtensionType(extension);
            if (extensionType == "UNSUPPORTED_TYPE")
            {
                MessageBox.Show("File Extension is not supported, Only .JPG, .JPEG, .BMP, .PNG, .TGA are supported",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentException("File Extension is not supported, Only .JPG, .JPEG, .BMP, .PNG, .TGA are supported");
            }

            using (var ms = new MemoryStream(imageData))
            using (var bmp = new Bitmap(ms))
            {
                if (extensionType == "PNG_TYPE")
                    bmp.Save(outputFilename, System.Drawing.Imaging.ImageFormat.Png);
                else if (extensionType == "BMP_TYPE")
                    bmp.Save(outputFilename, System.Drawing.Imaging.ImageFormat.Bmp);
                else if (extensionType == "JPG_TYPE")
                    bmp.Save(outputFilename, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (extensionType == "TGA_TYPE")
                    throw new NotSupportedException("TGA format not supported by System.Drawing");
            }

            return true;
        }

        /**
         * @brief Gets the pixel value at the specified position and channel.
         *
         * @param x The x-coordinate of the pixel.
         * @param y The y-coordinate of the pixel.
         * @param c The color channel index (0 for red, 1 for green, 2 for blue).
         * @return Reference to the pixel value.
         * @throws std::out_of_range If the coordinates or channel index is out of bounds.
         */
        public byte GetPixel(int x, int y, int c)
        {
            if (x < 0 || x >= width)
            {
                MessageBox.Show("Out of width bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(x), "Out of bounds, Cannot exceed width value");
            }
            if (y < 0 || y >= height)
            {
                MessageBox.Show("Out of height bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(y), "Out of bounds, Cannot exceed height value");
            }
            if (c < 0 || c > 2)
            {
                MessageBox.Show("Out of channels bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(c), "Out of bounds, You only have 3 channels in RGB");
            }

            return imageData[(y * width + x) * channels + c];
        }

        /**
         * @brief Sets the pixel value at the specified position and channel.
         *
         * @param x The x-coordinate of the pixel.
         * @param y The y-coordinate of the pixel.
         * @param c The color channel index (0 for red, 1 for green, 2 for blue).
         * @param value The new value to set.
         * @throws std::out_of_range If the coordinates or channel index is out of bounds.
         */
        public void SetPixel(int x, int y, int c, byte value)
        {
            if (x < 0 || x >= width)
            {
                MessageBox.Show("Out of width bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(x), "Out of bounds, Cannot exceed width value");
            }
            if (y < 0 || y >= height)
            {
                MessageBox.Show("Out of height bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(y), "Out of bounds, Cannot exceed height value");
            }
            if (c < 0 || c > 2)
            {
                MessageBox.Show("Out of channels bounds",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw new ArgumentOutOfRangeException(nameof(c), "Out of bounds, You only have 3 channels in RGB");
            }

            imageData[(y * width + x) * channels + c] = value;
        }

        /**
         * @brief Overloaded function call operator to access pixels.
         *
         * @param row The row index of the pixel.
         * @param col The column index of the pixel.
         * @param channel The color channel index (0 for red, 1 for green, 2 for blue).
         * @return Reference to the pixel value.
         */

        public byte this[int row, int col, int channel]
        {
            get { return GetPixel(row, col, channel); }
            set { SetPixel(row, col, channel, value); }
        }

    }
}
