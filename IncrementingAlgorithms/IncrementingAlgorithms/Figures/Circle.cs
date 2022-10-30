using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Circle : Figure
    {
        private Point _center;
        private int _radius;

        public Circle(Point center, int radius)
        {
            _center = center;
            _radius = radius;
        }
        public override void Draw(Bitmap sourceBitmap, Color drawingColor)
        {

            int r2 = (int)Math.Pow(_radius, 2);
            int dst = 4 * r2;
            int dxt = (int)(_radius / 1.414213562373);
            int t = 0;
            int s = -4 * r2 * _radius;
            int e = (-s / 2) - 3 * r2;
            int ca = -6 * r2;
            int cd = -10 * r2;
            int x = 0;
            int y = _radius;

            sourceBitmap.SetPixel(_center.X, _center.Y + _radius, drawingColor);
            sourceBitmap.SetPixel(_center.X, _center.Y - _radius, drawingColor);
            sourceBitmap.SetPixel(_center.X + _radius, _center.Y, drawingColor);
            sourceBitmap.SetPixel(_center.X - _radius, _center.Y, drawingColor);

            for (int index = 1; index <= dxt; index++)
            {
                x++;
                if (e >= 0)
                    e += t + ca;
                else
                {
                    y--;
                    e += t - s + cd;
                    s += dst;
                }

                t -= dst;

                sourceBitmap.SetPixel(_center.X + x, _center.Y + y, drawingColor);
                sourceBitmap.SetPixel(_center.X + y, _center.Y + x, drawingColor);
                sourceBitmap.SetPixel(_center.X + y, _center.Y - x, drawingColor);
                sourceBitmap.SetPixel(_center.X + x, _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(_center.X - x, _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(_center.X - y, _center.Y - x, drawingColor);
                sourceBitmap.SetPixel(_center.X - y, _center.Y + x, drawingColor);
                sourceBitmap.SetPixel(_center.X - x, _center.Y + y, drawingColor);


            }


        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_center.X + _radius, _center.Y, sourceBitmapWidth, sourceBitmapHeight) && 
                   Utils.ValidatePoint(_center.X - _radius, _center.Y, sourceBitmapWidth, sourceBitmapHeight) && 
                   Utils.ValidatePoint(_center.X, _center.Y - _radius, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_center.X, _center.Y + _radius, sourceBitmapWidth, sourceBitmapHeight);
        }
    }
}
