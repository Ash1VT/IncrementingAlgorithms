using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Rectangle : Figure
    {
        private PointF _firstPoint;
        private PointF _secondPoint;
        private PointF _thirdPoint;
        private PointF _fourthPoint;

        public Rectangle(PointF startPoint, int width, int height)
        {
            _firstPoint = startPoint;
            _secondPoint = new PointF(startPoint.X + width, startPoint.Y);
            _thirdPoint = new PointF(startPoint.X, startPoint.Y + height);
            _fourthPoint = new PointF(startPoint.X + width, startPoint.Y + height);
        }
        public override void Draw(Bitmap sourceBitmap, Color drawingColor)
        {
            

            Line firstLine = new Line(_firstPoint, _secondPoint);
            Line secondLine = new Line(_secondPoint, _fourthPoint);
            Line thirdLine = new Line(_thirdPoint, _fourthPoint);
            Line fourthLine = new Line(_firstPoint, _thirdPoint);

            firstLine.Draw(sourceBitmap, drawingColor);
            secondLine.Draw(sourceBitmap, drawingColor);
            thirdLine.Draw(sourceBitmap, drawingColor);
            fourthLine.Draw(sourceBitmap, drawingColor);


        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_firstPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_secondPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_thirdPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_fourthPoint, sourceBitmapWidth, sourceBitmapHeight);
        }
    }
}
