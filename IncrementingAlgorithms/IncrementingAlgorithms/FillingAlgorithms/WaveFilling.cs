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
            int numA = 1, numB = 0;
            List<Point> stackA = new List<Point>();
            List<Point> stackB = new List<Point>();
            stackA.Add(StartPoint);
            while (true)
            {
                Console.WriteLine(numA);
                Console.WriteLine(numB);
                if (numA > 0)
                    OneStep(sourceBitmap, ref numA, ref numB, stackA, stackB);
                else 
                    break;
                if (numB > 0)
                    OneStep(sourceBitmap, ref numB, ref numA, stackB, stackA);
                else
                    break;
            }

            return true;
        }

        private void OneStep(Bitmap sourceBitmap, ref int numSrc, ref int numDest, List<Point> src, List<Point> dest)
        {
            int x, y;

            numDest = 0;
            dest.Clear();
            for (int i = 0; i < numSrc; i++)
            {
                x = src[i].X;
                y = src[i].Y;
                NearPix(sourceBitmap,x+1, y, ref numDest, dest);
                NearPix(sourceBitmap, x - 1, y, ref numDest, dest);
                NearPix(sourceBitmap, x, y + 1, ref numDest, dest);
                NearPix(sourceBitmap, x, y - 1, ref numDest, dest);


            }

        }

        private void NearPix(Bitmap sourceBitmap, int x, int y, ref int numStack, List<Point> stack)
        {
            if (!sourceBitmap.GetPixel(x, y).Equals(Color.Black))
            {
                sourceBitmap.SetPixel(x,y, Color.Black);
                stack.Add(new Point(x,y));
                numStack++;
            }

        }
    }
}
