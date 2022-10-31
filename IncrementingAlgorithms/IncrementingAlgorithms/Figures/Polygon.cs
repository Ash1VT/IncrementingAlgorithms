using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.Figures
{
    public class Polygon : Figure
    {
        private List<PointF> _points;
        public Polygon(List<PointF> points, Color drawingColor) : base(drawingColor)
        {
            _points = points;
        }
        public override void Draw(Bitmap sourceBitmap)
        {
            List<Line> lines = new List<Line>();

            for (int i = 0; i < _points.Count; i++)
            {
                if(i+1 != _points.Count)
                    lines.Add(new Line(_points[i], _points[i+1], DrawingColor));
                else
                {
                    lines.Add(new Line(_points[i], _points[0], DrawingColor));
                    break;
                }
            }

            foreach (var line in lines)
            {
                line.Draw(sourceBitmap);
            }

        }

        public override bool Validate(int sourceBitmapWidth, int sourceBitmapHeight)
        {
            foreach (var point in _points)
            {
                if (!Utils.ValidatePoint(point, sourceBitmapWidth, sourceBitmapHeight))
                    return false;
            }

            return true;
        }

        public override string GetFullCharacteristics()
        {
            string result = base.GetFullCharacteristics();
            for (int i = 0; i < _points.Count; i++)
            {
                result += $"Point {i + 1}: {_points[i].X} {_points[i].Y}\n";
            }

            return result;
        }
    }
}
