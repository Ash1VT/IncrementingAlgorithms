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
    public partial class DrawingPolygonForm : FigureForm
    {
        public DrawingPolygonForm()
        {
            InitializeComponent();
        }

        private void DrawingPolygonForm_Load(object sender, EventArgs e)
        {

        }
        private void okButton_Click(object sender, EventArgs e)
        {
            int sides = int.Parse(sidesTextBox.Text);
            this.Visible = false;
            PointForm form = new PointForm(sides);
            form.ShowDialog();
            List<Point> points = form.Points;
            form.Dispose();

            Figure = new Polygon(points);

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
