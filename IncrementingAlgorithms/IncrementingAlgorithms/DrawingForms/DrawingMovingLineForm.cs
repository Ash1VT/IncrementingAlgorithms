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
    public partial class DrawingMovingLineForm : FigureForm
    {

        private List<MovingLine> _movingLines;


        public DrawingMovingLineForm(List<MovingLine> movingLines)
        {
            _movingLines = movingLines;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(x1TextBox.Text);
            float y1 = float.Parse(y1TextBox.Text);

            float x2 = float.Parse(x2TextBox.Text);
            float y2 = float.Parse(y2TextBox.Text);

            PointF firstPoint = new PointF(x1, y1);
            PointF secondPoint = new PointF(x2, y2);


            int speed = int.Parse(speedTextBox.Text);
            
            int firstPointDistance = int.Parse(distanceTextBox.Text);

            bool clockwise = clockwiseCheckBox.Checked;


            MovingLine dependingLine = null;
            if (dependingLinesComboBox.SelectedItem.ToString() != "None")
            {
                dependingLine = (MovingLine)dependingLinesComboBox.SelectedItem;
            }

            Figure = new MovingLine(firstPoint, secondPoint, firstPointDistance, speed, clockwise, DrawingColor, dependingLine);
            FigureCreated = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FigureCreated = false;
            this.Close();
        }

        

        private void DrawingMovingLineForm_Load(object sender, EventArgs e)
        {
            DrawingColor = Color.Black;
            InitRgbLabels();
            InitDependingLines();
            dependingLinesComboBox.SelectedIndex = 0;
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

        private void InitDependingLines()
        {
            dependingLinesComboBox.Items.Add("None");
            dependingLinesComboBox.Items.AddRange(_movingLines.ToArray());
        }
    }
}
