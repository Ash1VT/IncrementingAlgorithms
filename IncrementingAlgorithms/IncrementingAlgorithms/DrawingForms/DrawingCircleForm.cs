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
    public partial class DrawingCircleForm : FigureForm
    {

        public DrawingCircleForm()
        {
            InitializeComponent();
        }

        private void DrawingCircleForm_Load(object sender, EventArgs e)
        {
            DrawingColor = Color.Black;
            InitRgbLabels();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int xc = int.Parse(xcTextBox.Text);
            int yc = int.Parse(ycTextBox.Text);
            int radius = int.Parse(radiusTextBox.Text);

            Figure = new Circle(
                new Point(xc, yc), 
                radius, DrawingColor
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
