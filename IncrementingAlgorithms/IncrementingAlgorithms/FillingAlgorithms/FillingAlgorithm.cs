using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.FillingAlgorithms
{
    public abstract class FillingAlgorithm
    {
        protected Point StartPoint;

        protected Color FillingColor;
        protected FillingAlgorithm(Point startPoint, Color fillingColor)
        {
            StartPoint = startPoint;
            FillingColor = fillingColor;
        }

        public abstract bool Fill(Bitmap sourceBitmap);

    }
}
