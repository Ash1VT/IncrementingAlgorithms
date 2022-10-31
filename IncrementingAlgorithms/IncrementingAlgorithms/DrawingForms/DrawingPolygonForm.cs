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
            DrawingColor = Color.Black;
            InitRgbLabels();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            int sides = int.Parse(sidesTextBox.Text);
            this.Visible = false;
            PointForm form = new PointForm(sides);
            form.ShowDialog();
            List<PointF> points = form.Points;
            form.Dispose();

            Figure = new Polygon(points, DrawingColor);

            FigureCreated = true;
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FigureCreated = false;
            this.Close();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DrawingColor = dialog.Color;
            }
            dialog.Dispose();
            InitRgbLabels();
        }

        private void InitRgbLabels()
        {
            rLabel.Text = DrawingColor.R.ToString();
            gLabel.Text = DrawingColor.G.ToString();
            bLabel.Text = DrawingColor.B.ToString();
        }
    }
}
