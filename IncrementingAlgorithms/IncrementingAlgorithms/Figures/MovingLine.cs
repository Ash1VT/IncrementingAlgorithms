using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class MovingLine : Line
    {
        public PointF RotationalCenter { get; set; }
        public int Speed { get; }

        public double AngularSpeed { get; }


        public double FirstPointRotationalRadius { get; }

        public double SecondPointRotationalRadius { get; }

        public MovingLine DependingLine { get; set; }
        public bool Clockwise { get; }

        public MovingLine(PointF firstPoint, PointF secondPoint, 
            int firstPointDistance, 
            int speed, bool clockwise, Color drawingColor, MovingLine dependingLine = null) 
            : base(firstPoint, secondPoint, drawingColor)
        {
            RotationalCenter = Utils.GetRotationalCenter(firstPoint, secondPoint, firstPointDistance);
            Speed = speed;
            Clockwise = clockwise;


            FirstPointRotationalRadius = Utils.GetRotationalRadius(FirstPoint, RotationalCenter);
            SecondPointRotationalRadius  = Utils.GetRotationalRadius(SecondPoint, RotationalCenter);

            AngularSpeed = Utils.GetAngularSpeed(Speed, FirstPointRotationalRadius >= SecondPointRotationalRadius ? FirstPointRotationalRadius : SecondPointRotationalRadius);
            DependingLine = dependingLine;
        }

        public MovingLine(PointF firstPoint, PointF secondPoint, 
            PointF rotationalCenter, int speed, 
            bool clockwise, double angularSpeed, double firstPointRotationalRadius,
            double secondPointRotationalRadius, Color drawingColor, MovingLine dependingLine = null) 
            : base(firstPoint, secondPoint, drawingColor)
        {
            RotationalCenter = rotationalCenter;
            Speed = speed;
            Clockwise = clockwise;
            AngularSpeed = angularSpeed;
            FirstPointRotationalRadius = firstPointRotationalRadius;
            SecondPointRotationalRadius = secondPointRotationalRadius;
            DependingLine = dependingLine;

        }


        public override string GetFullCharacteristics()
        {
            return base.GetFullCharacteristics() +
                   $"Rotational center: {(int)Math.Round(RotationalCenter.X)} {(int)Math.Round(RotationalCenter.Y)}\n" +
                   $"Length: {Utils.GetLength(this)}\n" +
                   $"Speed: {Speed}\n" +
                   $"Angular speed: {AngularSpeed}\n";
        }

        public override string ToString()
        {
            return $"{(int)Math.Round(FirstPoint.X)} {(int)Math.Round(FirstPoint.Y)} -> {(int)Math.Round(SecondPoint.X)} {(int)Math.Round(SecondPoint.Y)}";
        }
    }
}
