using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAlgorithms.FillingAlgorithms
{
    public class WaveFilling : FillingAlgorithm
    {
        public WaveFilling(Point startPoint, Color fillingColor) : base(startPoint, fillingColor)
        {
        }

        public override bool Fill(Bitmap sourceBitmap)
        {
            List<Point> stackA = new List<Point>();
            List<Point> stackB = new List<Point>();
            
            Color baseColor = sourceBitmap.GetPixel(StartPoint.X, StartPoint.Y);
            
            stackA.Add(StartPoint);
                        
            while (true)
            {
                if (stackA.Count > 0)
                    OneStep(sourceBitmap, baseColor, FillingColor, stackA, stackB);
                else 
                    break;
                if (stackB.Count > 0)
                    OneStep(sourceBitmap,  baseColor, FillingColor, stackB, stackA);
                else
                    break;
            }

            return true;
        }

        private void OneStep(Bitmap sourceBitmap, Color baseColor, Color fillingColor, List<Point> src, List<Point> dest)
        {
            int x, y;

            dest.Clear();
            
            for (int i = 0; i < src.Count; i++)
            {
                x = src[i].X;
                y = src[i].Y;
                NearPix(sourceBitmap,baseColor,fillingColor,x+1, y, dest);
                NearPix(sourceBitmap, baseColor, fillingColor, x - 1, y, dest);
                NearPix(sourceBitmap, baseColor, fillingColor,x, y + 1, dest);
                NearPix(sourceBitmap, baseColor, fillingColor,x, y - 1, dest);


            }

        }

        private void NearPix(Bitmap sourceBitmap, Color baseColor, Color fillingColor, int x, int y, List<Point> stack)
        {
            if (Utils.AreColorsEqual(sourceBitmap.GetPixel(x, y), baseColor))
            {
                sourceBitmap.SetPixel(x,y, fillingColor);
                stack.Add(new Point(x,y));
            }

        }
    }
}
