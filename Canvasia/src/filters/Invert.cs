using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia.src.filters
{
    internal class Invert
    {
        public static Image_Class InvertImage(Image_Class image)
        {
            for (int i = 0; i < image.width; ++i)
            {
                for (int j = 0; j < image.height; ++j)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        image[i, j, k] = (byte)(255 - image[i, j, k]);
                    }
                }
            }
            return image;
        }
    }
}
