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

        
        public static bool ValidatePoint(PointF point, int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return point.X >=0 && 
                   point.X <= sourceBitmapWidth &&
                   point.Y >=0 &&
                   point.Y <= sourceBitmapHeight;
        }

        public static bool ValidatePoint(float x, float y, int sourceBitmapWidth, int sourceBitmapHeight)
        {
            return x >= 0 &&
                   x <= sourceBitmapWidth &&
                   y >= 0 &&
                   y <= sourceBitmapHeight;
        }

        public static PointF GetRotationalCenter(PointF firstPoint, PointF secondPoint, int firstPointDistance)
        {
            //GETS POINT ON A PASSED DISTANCE FROM FIRST POINT ON THE LINE
            float c = secondPoint.X - firstPoint.X;
            float d = secondPoint.Y - firstPoint.Y;

            float ad = 1;
            float bd = -2 * firstPoint.Y;
            float cd = firstPoint.Y * firstPoint.Y - (firstPointDistance * firstPointDistance * d * d) / (c * c + d * d);

            float D = (float)(bd * bd - 4.0 * ad * cd);

            float y1 = (float)((-bd + Math.Sqrt(Math.Abs(D))) / (2.0 * ad));
            float y2 = (float)((-bd - Math.Sqrt(Math.Abs(D))) / (2.0 * ad));


            float y = secondPoint.Y <= firstPoint.Y ? y2 : y1;

            float deltaXSquared = (firstPointDistance * firstPointDistance - (y - firstPoint.Y) * (y - firstPoint.Y));

            float deltaX1 = (float)Math.Sqrt(deltaXSquared);
            float deltaX2 = (float)-Math.Sqrt(deltaXSquared);

            float x1 = deltaX1 + firstPoint.X;
            float x2 = deltaX2 + firstPoint.X;


            float x = secondPoint.X <= firstPoint.X ? x2 : x1;
            
           
            return new PointF(x, y);
        }

        public static double GetAngularSpeed(double speed, double radius)
        {
            return speed / radius;
        }

        public static double GetRotationalRadius(PointF point, PointF rotationalCenter)
        {
            return Math.Sqrt(Math.Pow(point.X - rotationalCenter.X, 2) +
                                  Math.Pow(point.Y - rotationalCenter.Y, 2));
            
        }
        public static bool MoveLine(MovingLine line, PointF rotationalCenter, double angularSpeed, double time, bool clockwise)
        {
            
            
            PointF newFirstPoint = GetNewCoordinates(line.FirstPoint, rotationalCenter,
                angularSpeed, time, clockwise);

            PointF newSecondPoint = GetNewCoordinates(line.SecondPoint, rotationalCenter,
                angularSpeed, time, clockwise);

            PointF newRotationalCenter = GetNewCoordinates(line.RotationalCenter, rotationalCenter,
                angularSpeed, time, clockwise);

            line.FirstPoint = newFirstPoint;
            line.SecondPoint = newSecondPoint;
            line.RotationalCenter = newRotationalCenter;


            if (line.DependingLine != null)
            {
                MoveLine(line.DependingLine, rotationalCenter, angularSpeed, time, clockwise);
                MoveLine(line.DependingLine, line.DependingLine.RotationalCenter, line.DependingLine.AngularSpeed, time,
                    line.DependingLine.Clockwise);
            }

            return true;

        }

        private static PointF GetNewCoordinates(PointF oldPoint, PointF rotationalCenter, double angularSpeed, double time, bool clockwise)
        {
            double degrees = angularSpeed * time;

            double radians = degrees * Math.PI / 180;

            int direction = clockwise ? 1 : -1;

            float newX1 = (float)(((oldPoint.X - rotationalCenter.X) * Math.Cos(radians)) -
                direction * ((oldPoint.Y - rotationalCenter.Y) * Math.Sin(radians)) + rotationalCenter.X);
            float newY1 = (float)((direction * (oldPoint.X - rotationalCenter.X) * Math.Sin(radians)) +
                ((oldPoint.Y - rotationalCenter.Y) * Math.Cos(radians) + rotationalCenter.Y));

            return new PointF(newX1, newY1);

        }

        public static double GetLength(Line line)
        {
            double deltaX = line.SecondPoint.X - line.FirstPoint.X;
            double deltaY = line.SecondPoint.Y - line.FirstPoint.Y;

            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }

        public static List<MovingLine> GetMovingLines(List<Figure> figures)
        {
            return figures.FindAll(x => x is MovingLine).ConvertAll(
                new Converter<Figure, MovingLine>((Figure figure) => figure as MovingLine));
        }


        public static void RecursiveFilling(Bitmap sourceBitmap, Point point, Color baseColor, Color fillingColor)
        {
            int x = point.X;
            int y = point.Y;

            if (sourceBitmap.GetPixel(x, y).Equals(baseColor))
            {
                sourceBitmap.SetPixel(x, y, fillingColor);
                RecursiveFilling(sourceBitmap, new Point(x+1,y), baseColor, fillingColor);
                RecursiveFilling(sourceBitmap, new Point(x - 1, y), baseColor, fillingColor);
                RecursiveFilling(sourceBitmap, new Point(x, y + 1), baseColor, fillingColor);
                RecursiveFilling(sourceBitmap, new Point(x, y - 1), baseColor, fillingColor);
            }
        }
    }
}
