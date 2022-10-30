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
        private PointF _center;
        private double _radius;

        public Circle(PointF center, double radius)
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
            double s = -4 * r2 * _radius;
            double e = (-s / 2) - 3 * r2;
            int ca = -6 * r2;
            int cd = -10 * r2;
            int x = 0;
            double y = _radius;

            sourceBitmap.SetPixel((int)_center.X, (int)(_center.Y + _radius), drawingColor);
            sourceBitmap.SetPixel((int)_center.X, (int)(_center.Y - _radius), drawingColor);
            sourceBitmap.SetPixel((int)(_center.X + _radius), (int)_center.Y, drawingColor);
            sourceBitmap.SetPixel((int)(_center.X - _radius), (int)_center.Y, drawingColor);

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

                sourceBitmap.SetPixel((int)(_center.X + x), (int)(_center.Y + y), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X + y), (int)(_center.Y + x), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X + y), (int)(_center.Y - x), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X + x), (int)(_center.Y - y), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X - x), (int)(_center.Y - y), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X - y), (int)(_center.Y - x), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X - y), (int)(_center.Y + x), drawingColor);
                sourceBitmap.SetPixel((int)(_center.X - x), (int)(_center.Y + y), drawingColor);


            }


        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_center.X + (float)_radius, _center.Y, sourceBitmapWidth, sourceBitmapHeight) && 
                   Utils.ValidatePoint(_center.X - (float)_radius, _center.Y, sourceBitmapWidth, sourceBitmapHeight) && 
                   Utils.ValidatePoint(_center.X, _center.Y - (float)_radius, sourceBitmapWidth, sourceBitmapHeight) &&
                   Utils.ValidatePoint(_center.X, _center.Y + (float)_radius, sourceBitmapWidth, sourceBitmapHeight);
        }
    }
}
