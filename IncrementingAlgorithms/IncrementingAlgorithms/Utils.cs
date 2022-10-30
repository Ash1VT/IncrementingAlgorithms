using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms
{
    public static class Utils
    {
        public static Image CreateEmptyImage(int width, int height, Color backgroundColor)
        {
            Bitmap resultBitmap = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    resultBitmap.SetPixel(x, y, backgroundColor);
                }
            }

            return resultBitmap;
        }

        public static bool ValidatePoint(Point point, int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return point.X >=0 && 
                   point.X <= sourceBitmapWidth &&
                   point.Y >=0 &&
                   point.Y <= sourceBitmapHeight;
        }

        public static bool ValidatePoint(int x, int y, int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return x >= 0 &&
                   x <= sourceBitmapWidth &&
                   y >= 0 &&
                   y <= sourceBitmapHeight;
        }

        public static Point GetRotationalCenter(Point firstPoint, Point secondPoint, int firstPointDistance)
        {
            //GETS POINT ON A PASSED DISTANCE FROM FIRST POINT ON THE LINE
            double c = secondPoint.X - firstPoint.X;
            double d = secondPoint.Y - firstPoint.Y;

            double ad = 1;
            double bd = -2 * firstPoint.Y;
            double cd = firstPoint.Y * firstPoint.Y - (firstPointDistance * firstPointDistance * d * d) / (c * c + d * d);

            double D = (bd * bd - 4.0 * ad * cd);

            double y1 = ((-bd + Math.Sqrt(Math.Abs(D))) / (2.0 * ad));
            double y2 = ((-bd - Math.Sqrt(Math.Abs(D))) / (2.0 * ad));


            double y = secondPoint.Y <= firstPoint.Y ? y2 : y1;

            double deltaXSquared = (firstPointDistance * firstPointDistance - (y - firstPoint.Y) * (y - firstPoint.Y));

            double deltaX1 = Math.Sqrt(deltaXSquared);
            double deltaX2 = -Math.Sqrt(deltaXSquared);

            double x1 = deltaX1 + firstPoint.X;
            double x2 = deltaX2 + firstPoint.X;


            double x = secondPoint.X <= firstPoint.X ? x2 : x1;
            
           
            return new Point((int)Math.Round(x), (int)Math.Round(y));
        }

        public static double GetAngularSpeed(double speed, double radius)
        {
            return speed / radius;
        }

        public static int GetRotationalRadius(Point point, Point rotationalCenter)
        {
            return (int)Math.Sqrt(Math.Pow(point.X - rotationalCenter.X, 2) +
                                  Math.Pow(point.Y - rotationalCenter.Y, 2));
            
        }
        public static MovingLine MoveLine(MovingLine line, double time)
        {
            
            
            Point newFirstPoint = GetNewCoordinates(line.FirstPoint, line.RotationalCenter,
                line.AngularSpeed, time, line.Clockwise);

            Point newSecondPoint = GetNewCoordinates(line.SecondPoint, line.RotationalCenter,
                line.AngularSpeed, time, line.Clockwise);


            return new MovingLine(newFirstPoint, newSecondPoint,
                line.RotationalCenter, line.Speed, line.Clockwise, 
                line.AngularSpeed, line.FirstPointRotationalRadius, line.SecondPointRotationalRadius);
      
        }

        private static Point GetNewCoordinates(Point oldPoint, Point rotationalCenter, double angularSpeed, double time, bool clockwise)
        {
            double degrees = angularSpeed * time;

            double radians = degrees * Math.PI / 180;

            int direction = clockwise ? 1 : -1;

            double newX1 = ((oldPoint.X - rotationalCenter.X) * Math.Cos(radians)) -
                direction * ((oldPoint.Y - rotationalCenter.Y) * Math.Sin(radians)) + rotationalCenter.X;
            double newY1 = (direction * (oldPoint.X - rotationalCenter.X) * Math.Sin(radians)) +
                ((oldPoint.Y - rotationalCenter.Y) * Math.Cos(radians) + rotationalCenter.Y);

            return new Point((int)Math.Round(newX1), (int)Math.Round(newY1));

        }


    }
}
