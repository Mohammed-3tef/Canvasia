using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canvasia.src;
using Canvasia.src.display;

namespace Canvasia
{
    public class Filters
    {
        private static Bitmap ProcessBitmap(Bitmap image, Action<byte[], int, int, int> processPixels)
        {
            // Ensure 24bpp
            if (image.PixelFormat != PixelFormat.Format24bppRgb)
            {
                image = image.Clone(new Rectangle(0, 0, image.Width, image.Height),
                                    PixelFormat.Format24bppRgb);
            }

            int width = image.Width;
            int height = image.Height;

            // Lock and copy
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData data = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);

            int bytesPerPixel = Image.GetPixelFormatSize(image.PixelFormat) / 8; // 3
            int stride = data.Stride;
            int totalBytes = stride * height;

            byte[] pixels = new byte[totalBytes];
            Marshal.Copy(data.Scan0, pixels, 0, totalBytes);

            // Let caller modify pixels
            processPixels(pixels, width, height, stride);

            // Copy back and unlock
            Marshal.Copy(pixels, 0, data.Scan0, totalBytes);
            image.UnlockBits(data);

            return image;
        }

        // ------------------------------------------------------------------------------------------ PURPLE
        public static Bitmap ApplyPurpleFilter(Bitmap image, float intensity)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        pixels[pos + 1] = (byte)(pixels[pos + 1] * intensity);
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ DETECT EDGES
        public static Bitmap ApplyDetectEdges(Bitmap image)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                int bytesPerPixel = 3;

                // ---- STEP 1: Threshold to black/white ----
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * bytesPerPixel;

                        byte b = pixels[pos];
                        byte g = pixels[pos + 1];
                        byte r = pixels[pos + 2];

                        int avg = (r + g + b) / 3;
                        byte val = (avg > 127) ? (byte)255 : (byte)0;

                        pixels[pos] = val;
                        pixels[pos + 1] = val;
                        pixels[pos + 2] = val;
                    }
                }

                // ---- STEP 2: Edge detection on columns ----
                // Make a copy of thresholded pixels so we can read original values
                byte[] originalBW = (byte[])pixels.Clone();

                for (int x = 0; x < width; x++)
                {
                    bool flag = false;
                    bool flag2 = false;

                    for (int y = 1; y < height - 1; y++)
                    {
                        int posPrev = (y - 1) * stride + x * bytesPerPixel;
                        int posCurr = y * stride + x * bytesPerPixel;
                        int posNext = (y + 1) * stride + x * bytesPerPixel;

                        byte prevR = originalBW[posPrev + 2];
                        byte currR = originalBW[posCurr + 2];
                        byte nextR = originalBW[posNext + 2];

                        if (prevR == 255 && currR == 0 && !flag)
                        {
                            flag2 = false;
                            flag = true;

                            pixels[posCurr] = 0;
                            pixels[posCurr + 1] = 0;
                            pixels[posCurr + 2] = 0;
                        }
                        else if (currR == 0 && nextR == 255 && !flag2)
                        {
                            flag = false;
                            flag2 = true;

                            pixels[posCurr] = 0;
                            pixels[posCurr + 1] = 0;
                            pixels[posCurr + 2] = 0;
                        }
                        else
                        {
                            pixels[posCurr] = 255;
                            pixels[posCurr + 1] = 255;
                            pixels[posCurr + 2] = 255;
                        }
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ INFRARED
        public static Bitmap ApplyInfraredFilter(Bitmap image, float intensity = 1.0f)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;

                        byte b = pixels[pos];
                        byte g = pixels[pos + 1];

                        // Compute inverted channels
                        byte invB = (byte)(255 - b);
                        byte invG = (byte)(255 - g);
                        byte invR = 255;

                        // Blend between original and infrared using intensity
                        pixels[pos] = (byte)(b + (invB - b) * intensity);       // B
                        pixels[pos + 1] = (byte)(g + (invG - g) * intensity);   // G
                        pixels[pos + 2] = (byte)(pixels[pos + 2] + (invR - pixels[pos + 2]) * intensity); // R
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ INVERT
        public static Bitmap InvertImage(Bitmap image)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        pixels[pos] = (byte)(255 - pixels[pos]);     // Blue
                        pixels[pos + 1] = (byte)(255 - pixels[pos + 1]); // Green
                        pixels[pos + 2] = (byte)(255 - pixels[pos + 2]); // Red
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ LIGHTEN & DARKEN
        public static Bitmap ApplyDarkenFilter(Bitmap image, int trackBarDarkness)
        {
            double darken = (double)trackBarDarkness / 50.0;
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        pixels[pos] = (byte)(pixels[pos] * darken);
                        pixels[pos + 1] = (byte)(pixels[pos + 1] * darken);
                        pixels[pos + 2] = (byte)(pixels[pos + 2] * darken);
                    }
                }
            });
        }

        public static Bitmap ApplyLightenFilter(Bitmap image, int trackBarBrightness)
        {
            double lighten = (double)trackBarBrightness / 50.0;
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        int b = (int)(pixels[pos] * lighten);
                        if (b > 255) b = 255;
                        pixels[pos] = (byte)b;

                        int g = (int)(pixels[pos + 1] * lighten);
                        if (g > 255) g = 255;
                        pixels[pos + 1] = (byte)g;

                        int r = (int)(pixels[pos + 2] * lighten);
                        if (r > 255) r = 255;
                        pixels[pos + 2] = (byte)r;
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ SUNLIGHT
        public static Bitmap ApplySunlightFilter(Bitmap image)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        int newBlue = (int)(pixels[pos] * 0.888);
                        if (newBlue > 255) newBlue = 255;
                        pixels[pos] = (byte)newBlue;
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ GRAYSCALE
        public static Bitmap ApplyGrayscaleFilter(Bitmap image)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        // Calculate average
                        byte b = pixels[pos];
                        byte g = pixels[pos + 1];
                        byte r = pixels[pos + 2];
                        byte avg = (byte)((r + g + b) / 3);
                        // Set all channels to average
                        pixels[pos] = avg;
                        pixels[pos + 1] = avg;
                        pixels[pos + 2] = avg;
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ BLACK AND WHITE
        public static Bitmap ApplyBlackAndWhiteFilter(Bitmap image)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                for (int y = 0; y < height; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int pos = row + x * 3;
                        // Calculate average
                        byte b = pixels[pos];
                        byte g = pixels[pos + 1];
                        byte r = pixels[pos + 2];
                        byte avg = (byte)((r + g + b) / 3);
                        // Set all channels to black or white based on average
                        byte val = (avg > 127) ? (byte)255 : (byte)0;
                        pixels[pos] = val;
                        pixels[pos + 1] = val;
                        pixels[pos + 2] = val;
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ BLUR
        public static Bitmap ApplyBlurFilter(Bitmap image, int radius = 25)
        {
            return ProcessBitmap(image, (pixels, width, height, stride) =>
            {
                int area = (2 * radius + 1) * (2 * radius + 1);

                // Build 3D prefix sum array: [width + 1, height + 1, 3]
                long[,,] prefix = new long[width + 1, height + 1, 3];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int pos = y * stride + x * 3;
                        for (int c = 0; c < 3; c++)
                        {
                            long val = pixels[pos + c];
                            prefix[x + 1, y + 1, c] =
                                val +
                                prefix[x, y + 1, c] +
                                prefix[x + 1, y, c] -
                                prefix[x, y, c];
                        }
                    }
                }

                // Create output buffer
                byte[] result = new byte[pixels.Length];

                for (int y = 0; y < height; y++)
                {
                    int y1 = Math.Max(0, y - radius);
                    int y2 = Math.Min(height - 1, y + radius);

                    for (int x = 0; x < width; x++)
                    {
                        int x1 = Math.Max(0, x - radius);
                        int x2 = Math.Min(width - 1, x + radius);

                        int count = (x2 - x1 + 1) * (y2 - y1 + 1);
                        int pos = y * stride + x * 3;

                        for (int c = 0; c < 3; c++)
                        {
                            long total =
                                prefix[x2 + 1, y2 + 1, c] -
                                prefix[x1, y2 + 1, c] -
                                prefix[x2 + 1, y1, c] +
                                prefix[x1, y1, c];

                            result[pos + c] = (byte)(total / count);
                        }
                    }
                }

                // Copy blurred result into original pixel buffer
                Buffer.BlockCopy(result, 0, pixels, 0, pixels.Length);
            });
        }

        // ------------------------------------------------------------------------------------------ FLIP IMAGE
        public static Bitmap FlipImage(Bitmap original, bool vertically = false)
        {
            return ProcessBitmap(original, (pixels, width, height, stride) =>
            {
                int bytesPerPixel = 3;
                if (vertically)
                {
                    // Flip vertically
                    for (int y = 0; y < height / 2; y++)
                    {
                        int row1 = y * stride;
                        int row2 = (height - 1 - y) * stride;
                        for (int x = 0; x < width; x++)
                        {
                            int pos1 = row1 + x * bytesPerPixel;
                            int pos2 = row2 + x * bytesPerPixel;
                            // Swap pixels
                            for (int c = 0; c < bytesPerPixel; c++)
                            {
                                byte temp = pixels[pos1 + c];
                                pixels[pos1 + c] = pixels[pos2 + c];
                                pixels[pos2 + c] = temp;
                            }
                        }
                    }
                }
                else
                {
                    // Flip horizontally
                    for (int y = 0; y < height; y++)
                    {
                        int row = y * stride;
                        for (int x = 0; x < width / 2; x++)
                        {
                            int pos1 = row + x * bytesPerPixel;
                            int pos2 = row + (width - 1 - x) * bytesPerPixel;
                            // Swap pixels
                            for (int c = 0; c < bytesPerPixel; c++)
                            {
                                byte temp = pixels[pos1 + c];
                                pixels[pos1 + c] = pixels[pos2 + c];
                                pixels[pos2 + c] = temp;
                            }
                        }
                    }
                }
            });
        }

        // ------------------------------------------------------------------------------------------ ROTATE IMAGE
        public static Bitmap RotateImage(Bitmap original, int angle)
        {
            // Normalize angle to [0, 360)
            angle = angle % 360;
            if (angle < 0) angle += 360;

            // Calculate new dimensions
            int newWidth = original.Width;
            int newHeight = original.Height;
            if (angle == 90 || angle == 270)
            {
                newWidth = original.Height;
                newHeight = original.Width;
            }

            Bitmap rotated = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.Clear(Color.Transparent);
                g.TranslateTransform(newWidth / 2f, newHeight / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-original.Width / 2f, -original.Height / 2f);
                g.DrawImage(original, new Point(0, 0));
            }
            return rotated;
        }

        // ------------------------------------------------------------------------------------------ CROP IMAGE
        public static Bitmap CropImage(Bitmap original, int startX, int startY, int cropWidth, int cropHeight)
        {
            // تحقق من أن جزء القص داخل حدود الصورة
            int adjustedWidth = Math.Min(cropWidth, original.Width - startX);
            int adjustedHeight = Math.Min(cropHeight, original.Height - startY);

            if (adjustedWidth <= 0 || adjustedHeight <= 0)
            {
                MessageDisplay.ShowError("Crop area is outside the image bounds.");
                return null;
            }

            Rectangle cropRect = new Rectangle(startX, startY, adjustedWidth, adjustedHeight);
            Bitmap cropped = new Bitmap(adjustedWidth, adjustedHeight);

            using (Graphics g = Graphics.FromImage(cropped))
            {
                g.DrawImage(original, new Rectangle(0, 0, adjustedWidth, adjustedHeight), cropRect, GraphicsUnit.Pixel);
            }

            return cropped;
        }

        // ------------------------------------------------------------------------------------------ RESIZE IMAGE
        public static Bitmap ResizeImage(Bitmap original, int newWidth, int newHeight)
        {
            Bitmap resized = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(resized))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // Draw original into new size
                g.DrawImage(original, 0, 0, newWidth, newHeight);
            }

            return resized;
        }

        // ------------------------------------------------------------------------------------------ SKEW IMAGE
        public static Bitmap SkewImage(Bitmap original, float skewAngle)
        {
            float radians = skewAngle * (float)Math.PI / 180f;
            float shearX = (float)Math.Tan(radians); // e.g., tan(30°) ≈ 0.577

            int skewOffset = (int)(original.Height * Math.Abs(shearX));
            int newWidth = original.Width + skewOffset;

            Bitmap skewed = new Bitmap(newWidth, original.Height);

            using (Graphics g = Graphics.FromImage(skewed))
            {
                g.Clear(Color.Transparent);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                var transform = new System.Drawing.Drawing2D.Matrix();

                // Clockwise: shift bottom to right -> negative shear
                transform.Shear(-shearX, 0);

                // Translate right to avoid cropping (since negative shear shifts left)
                transform.Translate(skewOffset, 0);

                g.Transform = transform;
                g.DrawImage(original, new Point(0, 0));
            }

            return skewed;
        }

        // ------------------------------------------------------------------------------------------ ADD FRAME
        public static Bitmap AddFrame(Bitmap original, int frameWidthOuter, Color frameColorOuter, int frameWidthInner, Color frameColorInner)
        {
            frameWidthInner /= 2;
            // new image size = original + frame on all sides
            int newWidth = original.Width + frameWidthOuter * 2;
            int newHeight = original.Height + frameWidthOuter * 2;

            // create a new bitmap
            Bitmap framed = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(framed))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Step 1: paint background with outer frame color
                using (SolidBrush outerBrush = new SolidBrush(frameColorOuter))
                {
                    g.FillRectangle(outerBrush, 0, 0, newWidth, newHeight);
                }

                // Step 2: draw the original image inside, leaving the outer frame border
                g.DrawImage(original, frameWidthOuter, frameWidthOuter, original.Width, original.Height);

                if (frameWidthInner > 0)
                {
                    // Step 3: draw the inner border **inside the image area** with 10px margin
                    int innerX = frameWidthOuter;
                    int innerY = frameWidthOuter;
                    int innerWidth = original.Width;   // reduce width by 10px on both sides
                    int innerHeight = original.Height; // reduce height by 10px on both sides

                    using (Pen innerPen = new Pen(frameColorInner, frameWidthInner))
                    {
                        // keep border drawn inward
                        innerPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                        g.DrawRectangle(innerPen, innerX, innerY, innerWidth, innerHeight);
                    }

                    // Step 3: draw the inner border **inside the image area** with 10px margin
                    innerX = frameWidthOuter + 5;
                    innerY = frameWidthOuter + 5;
                    innerWidth = original.Width - 10;   // reduce width by 10px on both sides
                    innerHeight = original.Height - 10; // reduce height by 10px on both sides

                    using (Pen innerPen = new Pen(frameColorInner, frameWidthInner))
                    {
                        // keep border drawn inward
                        innerPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                        g.DrawRectangle(innerPen, innerX, innerY, innerWidth, innerHeight);
                    }
                }
            }

            return framed;
        }

        // ------------------------------------------------------------------------------------------ MERGE IMAGES
        public static Bitmap mergeImages(Bitmap original, Bitmap secondImage)
        {
            int newWidth = Math.Min(original.Width, secondImage.Width);
            int newHeight = Math.Min(original.Height, secondImage.Height);

            Bitmap merged = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(merged))
            {
                int x = (original.Width - newWidth) / 2;
                int y = (original.Height - newHeight) / 2;

                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.5f;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(
                    original,
                    new Rectangle(0, 0, original.Width, original.Height),
                    x, y, original.Width, original.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );

                x = (secondImage.Width - newWidth) / 2;
                y = (secondImage.Height - newHeight) / 2;

                g.DrawImage(
                    secondImage,
                    new Rectangle(0, 0, secondImage.Width, secondImage.Height), 
                    x,y, secondImage.Width, secondImage.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }

            return merged;
        }
    }
}
