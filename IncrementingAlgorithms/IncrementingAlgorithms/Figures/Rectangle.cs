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

        public Rectangle(PointF startPoint, int width, int height, Color drawingColor) : base(drawingColor)
        {
            _firstPoint = startPoint;
            _secondPoint = new PointF(startPoint.X + width, startPoint.Y);
            _thirdPoint = new PointF(startPoint.X, startPoint.Y + height);
            _fourthPoint = new PointF(startPoint.X + width, startPoint.Y + height);
        }
        public override void Draw(Bitmap sourceBitmap)
        {
            

            Line firstLine = new Line(_firstPoint, _secondPoint, DrawingColor);
            Line secondLine = new Line(_secondPoint, _fourthPoint, DrawingColor);
            Line thirdLine = new Line(_thirdPoint, _fourthPoint, DrawingColor);
            Line fourthLine = new Line(_firstPoint, _thirdPoint, DrawingColor);

            firstLine.Draw(sourceBitmap);
            secondLine.Draw(sourceBitmap);
            thirdLine.Draw(sourceBitmap);
            fourthLine.Draw(sourceBitmap);


        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_firstPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_secondPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_thirdPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_fourthPoint, sourceBitmapWidth, sourceBitmapHeight);
        }

        public override string GetFullCharacteristics()
        {
            return base.GetFullCharacteristics() +
                   $"First point: {_firstPoint.X} {_firstPoint.Y}\n" +
                   $"Second point: {_secondPoint.X} {_secondPoint.Y}\n" +
                   $"Third point: {_thirdPoint.X} {_thirdPoint.Y}\n" +
                   $"Fourth point: {_fourthPoint.X} {_fourthPoint.Y}\n";
        }
    }
}
