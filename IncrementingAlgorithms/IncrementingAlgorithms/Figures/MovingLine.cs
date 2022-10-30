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
        public Point RotationalCenter { get; }
        public int Speed { get; }


        public double AngularSpeed { get; }

        //public double SmallAngularSpeed { get; }

        public int FirstPointRotationalRadius { get; }

        public int SecondPointRotationalRadius { get; }

        public bool Clockwise { get; }

        public MovingLine(Point firstPoint, Point secondPoint, 
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




            //BigRotationalRadius = Utils.GetBigRotationalRadius(FirstPoint, SecondPoint, RotationalCenter);
            //SmallRotationalRadius = Utils.GetSmallRotationalRadius(FirstPoint, SecondPoint, RotationalCenter);

            //BigAngularSpeed = Utils.GetAngularSpeed(Speed, BigRotationalRadius);
            //SmallAngularSpeed = Utils.GetAngularSpeed(Speed, SmallRotationalRadius);
        }

        public MovingLine(Point firstPoint, Point secondPoint, 
            Point rotationalCenter, int speed, 
            bool clockwise, double angularSpeed, int firstPointRotationalRadius,
            int secondPointRotationalRadius) 
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
