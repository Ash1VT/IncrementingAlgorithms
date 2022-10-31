using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Triangle : Figure
    {
        private PointF _firstPoint;
        private PointF _secondPoint;
        private PointF _thirdPoint;

        public Triangle(PointF firstPoint, PointF secondPoint, PointF thirdPoint, Color drawingColor):base(drawingColor)
        {
            _firstPoint = firstPoint;
            _secondPoint = secondPoint;
            _thirdPoint = thirdPoint;
        }

        public override void Draw(Bitmap sourceBitmap)
        {
            Line firstLine = new Line(_firstPoint, _secondPoint, DrawingColor);
            Line secondLine = new Line(_secondPoint, _thirdPoint, DrawingColor);
            Line thirdLine = new Line(_firstPoint, _thirdPoint, DrawingColor);
            firstLine.Draw(sourceBitmap);
            secondLine.Draw(sourceBitmap);
            thirdLine.Draw(sourceBitmap);
        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_firstPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_secondPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_thirdPoint, sourceBitmapWidth, sourceBitmapHeight);
        }

        public override string GetFullCharacteristics()
        {
            return base.GetFullCharacteristics() +
                   $"First point: {_firstPoint.X} {_firstPoint.Y}\n" +
                   $"Second point: {_secondPoint.X} {_secondPoint.Y}\n" +
                   $"Third point: {_thirdPoint.X} {_thirdPoint.Y}\n";
        }
    }
}
