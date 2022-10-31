using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.FillingAlgorithms
{
    public class SimpleFilling : FillingAlgorithm
    {

        public SimpleFilling(Point startPoint, Color fillingColor) : base(startPoint, fillingColor)
        {
        }
        public override bool Fill(Bitmap sourceBitmap)
        {

            Color baseColor = sourceBitmap.GetPixel(StartPoint.X, StartPoint.Y);
            Utils.RecursiveFilling(sourceBitmap, StartPoint, baseColor, FillingColor);

            return true;
        }



    }
}
