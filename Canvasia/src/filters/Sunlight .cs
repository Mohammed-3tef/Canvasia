using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia
{
    internal class Sunlight
    {
        public static Image_Class ApplySunlightFilter(Image_Class image)
        {
            for (int i = 0; i < image.width; ++i)
            {
                for (int j = 0; j < image.height; ++j)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        image[i, j, 2] *= (byte)0.888;
                    }
                }
            }
            return image;
        }
    }
}
