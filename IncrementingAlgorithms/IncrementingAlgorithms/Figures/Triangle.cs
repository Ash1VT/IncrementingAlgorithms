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
        private Point _firstPoint;
        private Point _secondPoint;
        private Point _thirdPoint;

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            _firstPoint = firstPoint;
            _secondPoint = secondPoint;
            _thirdPoint = thirdPoint;
        }

        public override void Draw(Bitmap sourceBitmap, Color drawingColor)
        {
            Line firstLine = new Line(_firstPoint, _secondPoint);
            Line secondLine = new Line(_secondPoint, _thirdPoint);
            Line thirdLine = new Line(_firstPoint, _thirdPoint);
            firstLine.Draw(sourceBitmap, drawingColor);
            secondLine.Draw(sourceBitmap, drawingColor);
            thirdLine.Draw(sourceBitmap, drawingColor);
        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_firstPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_secondPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_thirdPoint, sourceBitmapWidth, sourceBitmapHeight);
        }
    }
}
