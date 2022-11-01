using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms.FillingAlgorithms
{
    public class LineFilling : FillingAlgorithm
    {
        public LineFilling(Point startPoint, Color fillingColor) : base(startPoint, fillingColor)
        {
        }

        public override bool Fill(Bitmap sourceBitmap)
        {
            Color baseColor = sourceBitmap.GetPixel(StartPoint.X, StartPoint.Y);

            LineFill(sourceBitmap, baseColor, StartPoint.X, StartPoint.Y, 1, StartPoint.X, StartPoint.X);

            
            return true;


        }

        private int LineFill(Bitmap sourceBitmap, Color baseColor, int x, int y, int dir, int preXl, int preXr)
        {
            int xl = x;
            int xr = y;

            Color color = sourceBitmap.GetPixel(x,y);


            
            while (Utils.AreColorsEqual(color, baseColor))
                color = sourceBitmap.GetPixel(--xl, y);
            
            color = sourceBitmap.GetPixel(x,y);

            while (Utils.AreColorsEqual(color, baseColor))                
                color = sourceBitmap.GetPixel(++xr, y);


            xl++;
            xr--;


            Line line = new Line(new PointF(xl, y),
                new PointF(xr, y),
                FillingColor);
            line.Draw(sourceBitmap);
            
            
            for (x = xl; x < xr; x++)
            {
                color = sourceBitmap.GetPixel(x, y + dir);
                if (Utils.AreColorsEqual(color, baseColor))
                    x = LineFill(sourceBitmap, baseColor, x, y + dir, dir, xl, xr);
            }
            //
            for (x = xl; x < preXl; x++)
            {
                color = sourceBitmap.GetPixel(x, y - dir);
                if (!Utils.AreColorsEqual(color, baseColor))
                    x = LineFill(sourceBitmap, baseColor, x, y - dir, -dir, xl, xr);
            }
            //
            for (x = preXr; x < xr; x++)
            {
                color = sourceBitmap.GetPixel(x, y - dir);
                if (!Utils.AreColorsEqual(color,baseColor))
                    x = LineFill(sourceBitmap, baseColor, x, y - dir, -dir, xl, xr);
            }

            return xr;
        }
    }
}
