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

        protected Color DrawingColor;

        protected Figure(Color drawingColor)
        {
            DrawingColor = drawingColor;
        }
        public abstract void Draw(Bitmap sourceBitmap);

        public abstract bool Validate(int sourceBitmapWidth, int sourceBitmapHeight);

        public virtual string GetFullCharacteristics()
        {
            return $"Type: {this.GetType().Name}\n";
        }
    }
}
