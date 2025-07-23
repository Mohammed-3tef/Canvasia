using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvasia
{
    internal class Purple
    {
        public static Image_Class ApplyPurpleFilter(Image_Class image)
        {
            for (int i = 0; i < image.width; ++i)
            {
                for (int j = 0; j < image.height; ++j)
                {
                    image[i, j, 1] *= (byte)0.7;
                }
            }
            return image;
        }
    }
}
