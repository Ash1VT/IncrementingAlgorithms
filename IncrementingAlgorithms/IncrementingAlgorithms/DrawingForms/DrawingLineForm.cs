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
    public partial class DrawingLineForm : FigureForm
    {
        public DrawingLineForm()
        {
            InitializeComponent();
        }
        private void DrawingLineForm_Load(object sender, EventArgs e)
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

            PointF firstPoint = new PointF(x1, y1);
            PointF secondPoint = new PointF(x2, y2);



            Figure = new Line(firstPoint, secondPoint, DrawingColor);
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
