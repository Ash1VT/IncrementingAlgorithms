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
    public partial class DrawingTriangleFrom : FigureForm
    {
        public DrawingTriangleFrom()
        {
            InitializeComponent();
        }
        private void DrawingTriangleFrom_Load(object sender, EventArgs e)
        {
            DrawingColor = Color.Black;
            InitRgbLabels();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(x1TextBox.Text);
            int y1 = int.Parse(y1TextBox.Text);
            int x2 = int.Parse(x2TextBox.Text);
            int y2 = int.Parse(y2TextBox.Text);
            int x3 = int.Parse(x3TextBox.Text);
            int y3 = int.Parse(y3TextBox.Text);

            Figure = new Triangle(
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3),
                DrawingColor
                );
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
