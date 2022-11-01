using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncrementingAlgorithms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //double x1 = 100;
            //double y1 = 100;
            //double x2 = 100;
            //double y2 = 200;

            //int degree = 180;
            //double radians = degree * Math.PI / 180;

            //double x2 = (x1 - x0) * Math.Cos(radians) - (y1 - y0) * Math.Sin(radians) + x0;
            //double y2 = (x1 - x0) * Math.Sin(radians) + (y1 - y0) * Math.Cos(radians) + y0;
            //Console.WriteLine(x2);
            //Console.WriteLine(y2);





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
