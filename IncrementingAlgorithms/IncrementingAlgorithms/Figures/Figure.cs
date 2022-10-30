using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public abstract class Figure
    {
        public abstract void Draw(Bitmap sourceBitmap, Color drawingColor);

        public abstract bool Validate(int sourceBitmapWidth, int sourceBitmapHeight);
    }
}
