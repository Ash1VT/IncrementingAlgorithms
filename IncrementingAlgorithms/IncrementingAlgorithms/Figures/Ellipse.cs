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
        private PointF _center;
        private double _enx;
        private double _eny;

        public Ellipse(PointF center, int enx, int eny, Color drawingColor) : base(drawingColor)
        {
            _center = center;
            _enx = enx;
            _eny = eny;
        }
        public override void Draw(Bitmap sourceBitmap)
        {
            double a = Math.Abs(_enx - _center.X);
            double b = Math.Abs(_eny - _center.Y);

            int a2 = (int)Math.Pow(a, 2);
            int b2 = (int)Math.Pow(b, 2);

            int dds = 4 * a2;
            int ddt = 4 * b2;

            double dxt = (a2 / Math.Sqrt(a2 + b2));

            int t = 0;
            double s = -4 * a2 * b;
            double e = (-s / 2) - 2 * b2 - a2;
            
            int ca = -6 * b2;
            int cd = ca - 4 * a2;

            double x = _center.X;
            double y = _center.Y + b;


            sourceBitmap.SetPixel((int)x, (int)y, DrawingColor);
            sourceBitmap.SetPixel((int)x, (int)(2*_center.Y-y), DrawingColor);
            sourceBitmap.SetPixel((int)(2*_center.X-x), (int)(2*_center.Y-y), DrawingColor);
            sourceBitmap.SetPixel((int)(2*_center.X-x), (int)y, DrawingColor);

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
                sourceBitmap.SetPixel((int)x, (int)y, DrawingColor);
                sourceBitmap.SetPixel((int)x, (int)(2 * _center.Y - y), DrawingColor);
                sourceBitmap.SetPixel((int)(2 * _center.X - x), (int)(2 * _center.Y - y), DrawingColor);
                sourceBitmap.SetPixel((int)(2 * _center.X - x), (int)y, DrawingColor);

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
                sourceBitmap.SetPixel((int)x, (int)y, DrawingColor);
                sourceBitmap.SetPixel((int)x, (int)(2 * _center.Y - y), DrawingColor);
                sourceBitmap.SetPixel((int)(2 * _center.X - x), (int)(2 * _center.Y - y), DrawingColor);
                sourceBitmap.SetPixel((int)(2 * _center.X - x), (int)y, DrawingColor);

            }

        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return Utils.ValidatePoint(_center.X + (float)_enx, _center.Y, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X - (float)_enx, _center.Y, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X, _center.Y - (float)_eny, sourceBitmapWidth, sourceBitmapHeight) &&
       Utils.ValidatePoint(_center.X, _center.Y + (float)_eny, sourceBitmapWidth, sourceBitmapHeight);
        }

        public override string GetFullCharacteristics()
        {
            return base.GetFullCharacteristics() +
                   $"Center: {_center.X} {_center.Y}\n" +
                   $"EnX: {_enx}\n" +
                   $"EnY: {_eny}\n";
        }
    }
}
