using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Line : Figure
    {
        public PointF FirstPoint { get; set; }
        public PointF SecondPoint { get; set; }



        public Line(PointF firstPoint, PointF secondPoint, Color drawingColor) : base(drawingColor)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
        public override void Draw(Bitmap sourceBitmap)
        {
            float xerr = 0, yerr = 0;
            float dx = SecondPoint.X - FirstPoint.X;
            float dy = SecondPoint.Y - FirstPoint.Y;

            int incX = GetDimensionInc(dx);
            int incY = GetDimensionInc(dy);


            dx = Math.Abs(dx);
            dy = Math.Abs(dy);


            float d = dx > dy ? dx : dy;

            float x = FirstPoint.X;
            float y = FirstPoint.Y;
            sourceBitmap.SetPixel((int)x, (int)y, DrawingColor);

            for (int i = 0; i <= d; i++)
            {
                xerr = xerr + dx;
                yerr = yerr + dy;

                if (xerr > d)
                {
                    xerr = xerr - d;
                    x = x + incX;
                }

                if (yerr > d)
                {
                    yerr = yerr - d;
                    y = y + incY;
                }

                sourceBitmap.SetPixel((int)x, (int)y, DrawingColor);
            }


        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(FirstPoint, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(SecondPoint, sourceBitmapWidth, sourceBitmapHeight);
        }

        public override string GetFullCharacteristics()
        {
            return base.GetFullCharacteristics() +
                   $"First point: {(int)Math.Round(FirstPoint.X)} {(int)Math.Round(FirstPoint.Y)}\n" +
                   $"Second point: {(int)Math.Round(SecondPoint.X)} {(int)Math.Round(SecondPoint.Y)}\n";
        }

        private int GetDimensionInc(float dimensionD)
        {
            if (dimensionD > 0)
                return 1;

            if (dimensionD == 0)
                return 0;

            return -1;
        }

    }
}
