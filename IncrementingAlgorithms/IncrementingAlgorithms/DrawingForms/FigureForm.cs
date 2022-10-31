using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms.DrawingForms
{
    public class FigureForm : Form
    {
        protected Color DrawingColor;

        public Figure Figure { get; set; }

        public bool FigureCreated { get; set; }


    }
}
