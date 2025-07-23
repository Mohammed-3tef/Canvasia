using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia
{
    internal class DetectEdges
    {
        public static Image_Class ApplyDetectEdges(Image_Class image)
        {
            for (int i = 0; i < image.width; i++)
            {
                for (int j = 0; j < image.height; j++)
                {
                    int avg = 0;  // Initialize average value.
                    for (int k = 0; k < 3; k++)
                    {
                        avg += image.GetPixel(i, j, k);  // Accumulate pixel values.
                    }

                    avg /= 3;  // Calculate average.
                    byte val;

                    if (avg > 127) val = 255;
                    else val = 0;

                    // Set all channels to either 0 or 255 (to obtain black and white only)
                    image.SetPixel(i,j,0,val);
                    image.SetPixel(i, j, 1, val);
                    image.SetPixel(i, j, 2, val);
                }
            }

            for (int i = 0; i < image.width; i++)
            {
                bool flag = false;
                bool flag2 = false;
                for (int j = 1; j < image.height - 1; j++)
                {
                    if (j > 0 && image.GetPixel(i, j - 1, 0) == 255 && image.GetPixel(i, j, 0) == 0 && !flag)
                    {
                        flag2 = false;
                        flag = true;
                        image.SetPixel(i, j, 0, 0);
                        image.SetPixel(i, j, 1, 0);
                        image.SetPixel(i, j, 2, 0);
                    }

                    else if (j < image.width - 1 && image.GetPixel(i, j, 0) == 0 && image.GetPixel(i, j + 1, 0) == 255 && !flag2)
                    {
                        flag = false;
                        flag2 = true;
                        image.SetPixel(i, j, 0, 0);
                        image.SetPixel(i, j, 1, 0);
                        image.SetPixel(i, j, 2, 0);
                    }

                    else
                    {
                        image.SetPixel(i, j, 0, 255);
                        image.SetPixel(i, j, 1, 255);
                        image.SetPixel(i, j, 2, 255);
                    }
                }
            }
            return image;
        }
    }
}
