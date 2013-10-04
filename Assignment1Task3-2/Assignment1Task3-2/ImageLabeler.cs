using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Assignment1Task3_2
{
    static class ImageLabeler
    {
        public static string LabelImage(ref Bitmap image)
        {
            StringBuilder labelStringBuilder = new StringBuilder();
            Dictionary<int, int> parentValues = new Dictionary<int, int>();
            int[,] labels = new int[image.Width, image.Height];
            int maxLabel = 0;
            bool setNewValue = false;

            // pass 1
            for (int y = 0; y < image.Height; ++y)
                for (int x = 0; x < image.Width; ++x)
                {
                    if (image.GetPixel(x, y).GetBrightness() < 1)
                    {
                        labels[x, y] = 1;
                        setNewValue = false;
                        if (x > 0 && labels[x - 1, y] != 0)
                        {
                            labels[x, y] = labels[x - 1, y];
                            setNewValue = true;
                        }
                        if (y > 0 && labels[x, y - 1] != 0)
                        {
                            if (!setNewValue)
                            {
                                labels[x, y] = labels[x, y - 1];
                                setNewValue = true;
                            }

                            else if (labels[x, y - 1] != labels[x, y])
                                parentValues[labels[x, y]] = labels[x, y - 1];
                        }
                        if (!setNewValue)
                            labels[x, y] = ++maxLabel;
                    }
                    else
                        labels[x, y] = 0;
            }

            // pass 2
            var orderedParents = parentValues.Keys.OrderByDescending(k => parentValues[k]).ToList();
            foreach (int key in orderedParents)
                for (int y = 0; y < image.Height; ++y)
                    for (int x = 0; x < image.Width; ++x)
                        if(labels[x, y] == key)
                            labels[x, y] = parentValues[key];

            // build string for debug view
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                    labelStringBuilder.Append(labels[x, y]);
                labelStringBuilder.Append("\n");
            }

            return labelStringBuilder.ToString();
        }
    }
}
