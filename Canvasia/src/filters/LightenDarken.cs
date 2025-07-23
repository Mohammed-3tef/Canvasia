using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia
{
    internal class LightenDarken
    {
        public static Image_Class ApplyDarkenFilter(Image_Class image)
        {
            double darken = 0.5;                                                   // Initialize darken value.
            for (int i = 0; i < image.width; ++i)
            {
                for (int j = 0; j < image.height; ++j)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        byte oldValue = image.GetPixel(i, j, k);
                        byte newValue = (byte)(oldValue * darken);
                        image.SetPixel(i, j, k, newValue);                             // Change pixel values.
                    }
                }
            }
            return image;
        }

        public static Image_Class ApplyLightenFilter(Image_Class image)
        {
            double lighten = 1.5;                                                // Initialize lighten value.
            for (int i = 0; i < image.width; ++i)
            {
                for (int j = 0; j < image.height; ++j)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        byte oldValue = image.GetPixel(i, j, k);
                        byte newValue = (byte)(oldValue * lighten);      
                        if (newValue > 255)                                          // Check if channel value exceeds 255.
                            image.SetPixel(i, j, k, 255);
                        else
                            image.SetPixel(i, j, k, newValue);
                    }
                }
            }
            return image;
        }
    }
}
