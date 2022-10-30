using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Ellipse : Figure
    {
        private Point _center;
        private int _enx;
        private int _eny;

        public Ellipse(Point center, int enx, int eny)
        {
            _center = center;
            _enx = enx;
            _eny = eny;
        }
        public override void Draw(Bitmap sourceBitmap, Color drawingColor)
        {
            int a = Math.Abs(_enx - _center.X);
            int b = Math.Abs(_eny - _center.Y);

            int a2 = (int)Math.Pow(a, 2);
            int b2 = (int)Math.Pow(b, 2);

            int dds = 4 * a2;
            int ddt = 4 * b2;

            int dxt = (int)(a2 / Math.Sqrt(a2 + b2));

            int t = 0;
            int s = -4 * a2 * b;
            int e = (-s / 2) - 2 * b2 - a2;
            
            int ca = -6 * b2;
            int cd = ca - 4 * a2;

            int x = _center.X;
            int y = _center.Y + b;


            sourceBitmap.SetPixel(x,y,drawingColor);
            sourceBitmap.SetPixel(x, 2*_center.Y-y, drawingColor);
            sourceBitmap.SetPixel(2*_center.X-x, 2*_center.Y-y, drawingColor);
            sourceBitmap.SetPixel(2*_center.X-x, y, drawingColor);

            for (int index = 1; index <= dxt; index++)
            {
                x++;
                if (e >= 0)
                    e += t + ca;
                else
                {
                    y--;
                    e += t - s + cd;
                    s += dds;

                }

                t -= ddt;
                sourceBitmap.SetPixel(x, y, drawingColor);
                sourceBitmap.SetPixel(x, 2 * _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(2 * _center.X - x, 2 * _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(2 * _center.X - x, y, drawingColor);

            }

            dxt = Math.Abs(y - _center.Y);
            e -= t / 2 + s / 2 + b2 + a2;
            ca = -6 * a2;
            cd = ca - 4 * b2;
            for (int index = 1; index <= dxt; index++)
            {
                y--;
                if (e <= 0)
                    e += -s + ca;
                else
                {
                    x++;
                    e += -s + t + cd;
                    t -= ddt;

                }


                s += dds;
                sourceBitmap.SetPixel(x, y, drawingColor);
                sourceBitmap.SetPixel(x, 2 * _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(2 * _center.X - x, 2 * _center.Y - y, drawingColor);
                sourceBitmap.SetPixel(2 * _center.X - x, y, drawingColor);

            }

        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_center.X + _enx, _center.Y, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X - _enx, _center.Y, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X, _center.Y - _eny, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X, _center.Y + _eny, sourceBitmapWidth, sourceBitmapHeight);
        }
    }
}
