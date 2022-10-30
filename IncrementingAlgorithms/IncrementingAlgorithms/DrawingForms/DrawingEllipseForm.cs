using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncrementingAlgorithms.Figures;

namespace IncrementingAlgorithms.DrawingForms
{
    public partial class DrawingEllipseForm : FigureForm
    {
        public DrawingEllipseForm()
        {
            InitializeComponent();
        }

        private void DrawingEllipseForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int xc = int.Parse(xcTextBox.Text);
            int yc = int.Parse(ycTextBox.Text);
            int enx = int.Parse(enXTextBox.Text);
            int eny = int.Parse(enYTextBox.Text);

            Figure = new Ellipse(
                new Point(xc, yc), 
                enx, eny
                );
            FigureCreated = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FigureCreated = false;
            this.Close();

        }
    }
}
