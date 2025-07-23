using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia
{
    internal class Infrared
    {
        public static Image_Class ApplyInfraredFilter(Image_Class image)
        {
            for (int i = 0; i < image.width; i++)
            {
                for (int j = 0; j < image.height; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte old_value = image.GetPixel(i, j, k);
                        image.SetPixel(i, j, k, (byte)(255 - old_value));                       // Change pixel values.
                        image.SetPixel(i, j, 0, 255);
                    }
                }
            }
            return image;
        }
    }
}
