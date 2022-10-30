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
        public PointF RotationalCenter { get; }
        public int Speed { get; }


        public double AngularSpeed { get; }


        public double FirstPointRotationalRadius { get; }

        public double SecondPointRotationalRadius { get; }

        public MovingLine Line { get; set; }
        public bool Clockwise { get; }

        public MovingLine(PointF firstPoint, PointF secondPoint, 
            int firstPointDistance, 
            int speed, bool clockwise) 
            : base(firstPoint, secondPoint)
        {
            RotationalCenter = Utils.GetRotationalCenter(firstPoint, secondPoint, firstPointDistance);
            Speed = speed;
            Clockwise = clockwise;


            FirstPointRotationalRadius = Utils.GetRotationalRadius(FirstPoint, RotationalCenter);
            SecondPointRotationalRadius  = Utils.GetRotationalRadius(SecondPoint, RotationalCenter);

            AngularSpeed = Utils.GetAngularSpeed(Speed, FirstPointRotationalRadius >= SecondPointRotationalRadius ? FirstPointRotationalRadius : SecondPointRotationalRadius);

        }

        public MovingLine(PointF firstPoint, PointF secondPoint, 
            PointF rotationalCenter, int speed, 
            bool clockwise, double angularSpeed, double firstPointRotationalRadius,
            double secondPointRotationalRadius) 
            : base(firstPoint, secondPoint)
        {
            RotationalCenter = rotationalCenter;
            Speed = speed;
            Clockwise = clockwise;
            AngularSpeed = angularSpeed;
            FirstPointRotationalRadius = firstPointRotationalRadius;
            SecondPointRotationalRadius = secondPointRotationalRadius;

        }

    }
}
