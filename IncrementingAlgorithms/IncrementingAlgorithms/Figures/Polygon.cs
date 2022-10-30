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
        public Polygon(List<PointF> points)
        {
            _points = points;
        }
        public override void Draw(Bitmap sourceBitmap, Color drawingColor)
        {
            List<Line> lines = new List<Line>();

            for (int i = 0; i < _points.Count; i++)
            {
                if(i+1 != _points.Count)
                    lines.Add(new Line(_points[i], _points[i+1]));
                else
                {
                    lines.Add(new Line(_points[i], _points[0]));
                    break;
                }
            }

            foreach (var line in lines)
            {
                line.Draw(sourceBitmap,drawingColor);
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
    }
}
